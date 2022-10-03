using MDSY.Framework.Buffer;
using MDSY.Framework.Buffer.Common;
using MDSY.Framework.Buffer.Interfaces;
using MDSY.Framework.Buffer.Services;
using System.Linq;
using System;
using MDSY.Framework.Control.CICS;
using System.Xml.Linq;
using MDSY.Framework.Core;
using MDSY.Framework.IO.Common;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using GOV.KS.DCF.CSS.Common.BL;
using MDSY.Framework.Data.SQL;
using System.Data.Common;
using System.Data.SqlClient;

namespace GOV.KS.DCF.CSS.Test
{
  class Program
  {
    StringBuilder collectResponses = new StringBuilder();
    private ConcurrentBag<string> responseData = new ConcurrentBag<string>();
    private IDictionary<string, EABBase> programInstanceCache = new Dictionary<string, EABBase>();
    int returnCd = 0;
    static void Main(string[] args)
    {
      var app = new Program();
      app.RunBatch("SWEPB704");
      Console.ReadLine();
    }
    public void RunQueryTest()
    {
      DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
      DBConversation LocalDbConv = new DBConversation();

      LocalDbConv.ExecuteSqlQueryWithUR("Select * from [SRCKTK2].[CKT_DB_NAME]");

      LocalDbConv.ExecuteSql("INSERT into [SRCKTK2].[CKT_DB_NAME] " +
          "([PROVIDER_ID],[PROVIDER_TYPE],[ORG_OR_LAST_NAME],[FIRST_NAME],[MIDDLE_INITIAL])" +
          "VALUES ('00000002', 'BB', 'LAST','FIRST', 'M')");

      if(LocalDbConv.SQLErrorStatus == ErrorStatus.DuplicatesViolation)
        Console.WriteLine("Duplicates Violation!");


    }
    public void RunExample()
    {
      DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
      DBConversation LocalDbConv = new DBConversation();

      var programName = "SWEXIR90";

      //Set up parms to be passed
      List<object> parms = new List<object>();
      //Parm W_IA
      List<byte> byteList = new List<byte>();
      byteList.AddRange(Encoding.UTF8.GetBytes(string.Empty.PadLeft(96)));
      byteList.AddRange(Encoding.UTF8.GetBytes("      03E       "));
      byteList.AddRange(Encoding.UTF8.GetBytes("    FAT         "));
      byteList.AddRange(Encoding.UTF8.GetBytes("   REP-EGBERT   "));
      byteList.AddRange(Encoding.UTF8.GetBytes("       0000000{ "));
      byteList.AddRange(Encoding.UTF8.GetBytes("           2 000{"));
      parms.Add(byteList.ToArray());
      //Parm W_OA
      parms.Add(Encoding.UTF8.GetBytes(string.Empty.PadLeft(200)));
      //Parm W_OA
      parms.Add(Encoding.UTF8.GetBytes(string.Empty.PadLeft(1024)));

      //Call EAB program 
      returnCd = CallEABProgram(programName, LocalDbConv.Connection, LocalDbConv.Transaction, parms.ToArray());

      LocalDbConv.CloseConnection();
      Console.WriteLine(String.Format("Program: {0} has finished with return code of {1}", programName, returnCd.AsString()));
      Console.ReadLine();

    }
    private int CallEABProgram(string programName, DbConnection connection, DbTransaction transaction, object[] parms)
    {
      int returnCode = 0;
      EABBase programInstance;

      //Check program cache
      if(!programInstanceCache.ContainsKey(programName.Trim()))
      {
        Type programType = ProgramUtilities.GetBLType(programName);
        if(programType == null)
          throw new Exception(string.Concat("Called Program not found: ", programName));
        programInstanceCache.Add(programName.Trim(), (EABBase)Activator.CreateInstance(programType));
      }
      programInstance = programInstanceCache[programName.Trim()];

      //Set Passed connection if needed
      //if (connection != null)
      //    programInstance.DbConv.SetNewConnection(connection);
      ////Set Passed transaction if needed
      //if (transaction != null)
      //    programInstance.DbConv.SetNewTransaction(transaction);

      returnCode = programInstance.ExecuteMain(parms.ToArray());

      return returnCode;
    }

    private int RunBatch(string programName)
    {
      Environment.SetEnvironmentVariable("RPT99", "c:\\temp\\RPT99;133;LSEQ;Flat");
      Environment.SetEnvironmentVariable("RPT98", "c:\\temp\\RPT98;133;LSEQ;Flat");
      var debug = true;
      var exeDirectory =
        Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
      var refDirectory = Path.GetDirectoryName(
        Path.GetDirectoryName(Path.GetDirectoryName(exeDirectory)));

      var batchDirectory = Path.Combine(
        refDirectory,
        "..",
        "..",
        "cool-gen-kansasdcf",
        "Batch",
        Path.GetRelativePath(refDirectory, exeDirectory));

      // batchDirectory = "\\\\eavjes3\\eavProjects\\KansasCSS\\eavJESCatalog\\Loadlibs\\SR.CSE.PROD.BATCH.LOAD";

      try
      {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.UseShellExecute = false;        
        startInfo.RedirectStandardOutput = true;
        
        var arguments = string.Concat("trancode=", programName);

        if (debug)
        {
          arguments += " debug=true";
        }

        startInfo.Arguments = arguments;
        startInfo.FileName = Path.Combine(batchDirectory, "Batch.exe");
        startInfo.WorkingDirectory = batchDirectory;
        startInfo.EnvironmentVariables["RPT99"] = Environment.GetEnvironmentVariable("RPT99");
        startInfo.EnvironmentVariables["RPT98"] = Environment.GetEnvironmentVariable("RPT98");

        Process p = Process.Start(startInfo);
        // Run application -- read output and wait to complete
        string output = p.StandardOutput.ReadToEnd();
        p.WaitForExit();
        string CPU_Time = p.UserProcessorTime.ToString();
        int returnCode = p.ExitCode;
        if(output.Trim() == string.Empty)
        {
          output = string.Concat("Error!: Process Exit Code = ", returnCode.ToString());
        }
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message + ex.StackTrace);
      }

      return 0;
    }

    private int RunBatch2(string programName)
    {
      try
      {
        string[] bargs = new string[1] { programName };
        //KansasDCF.Cse.Batch.Program.Main(bargs);


      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message + ex.StackTrace);
      }

      return 0;
    }
  }

}