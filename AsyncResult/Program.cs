//using Microsoft.CSharp;
//using System;
//using System.CodeDom;
//using System.CodeDom.Compiler;
//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AsyncResult
//{
//    class Program
//    {
//        private static object myObject;
//        public delegate bool MyDelegate(Int32 a);

//        XmlTraceListener

//        static void Main(string[] args)
//        {
            
//            XmlTraceListener

//            int.Pa
//            ArrayList array1 = new ArrayList();
//            int var1 = 10;
//            int var2;
//            array1.Add(var1);
//            //var2 = ((List<int>)array1)[0];
//            var2 = Convert.ToInt32(array1[0]);
            
//            var listener = new XmlWriterTraceListener("./Error.log");
//            listener.WriteLine("ciao");
//            listener.Flush();
//            listener.Close();


//            CodeCompileUnit compileUnit = new CodeCompileUnit();
//            CodeNamespace myNamespace = new CodeNamespace("MyNamespace");
//            myNamespace.Imports.Add(new CodeNamespaceImport("System"));
//            CodeTypeDeclaration myClass = new CodeTypeDeclaration("MyClass");
//            CodeEntryPointMethod start = new CodeEntryPointMethod();
//            CodeMethodInvokeExpression cs1 = new CodeMethodInvokeExpression(
//            new CodeTypeReferenceExpression("Console"), "WriteLine", new CodePrimitiveExpression("Hello World!"));
//            compileUnit.Namespaces.Add(myNamespace);
//            myNamespace.Types.Add(myClass);
//            myClass.Members.Add(start);
//            start.Statements.Add(cs1);

//            CSharpCodeProvider provider = new CSharpCodeProvider();
//            using (StreamWriter sw = new StreamWriter("HelloWorld.cs", false))
//            {
//                IndentedTextWriter tw = new IndentedTextWriter(sw, " ");
//                provider.GenerateCodeFromCompileUnit(compileUnit, tw,
//                new CodeGeneratorOptions());
//                tw.Close();
//            }


//            EventLog.CreateEventSource("AppSource", "AppLog");
//            {
//                EventLog eventLog = new EventLog() { Source = "AppSource", EnableRaisingEvents = true };
//                eventLog.WriteEntry("Prova", EventLogEntryType.Error);
//            }

//            {
//                EventLog eventLog = new EventLog() { Source = "AppSource" };
//                eventLog.WriteEntry("Prova");
//            }

//            {
//                EventLog eventLog = new EventLog() { Source = "AppSource", EnableRaisingEvents = true };
//                eventLog.WriteEntry("Prova");
//            }

//            // Create the source, if it does not already exist.
//            if (!EventLog.SourceExists("MySource"))
//            {
//                //An event log source should not be created and immediately used.
//                //There is a latency time to enable the source, it should be created
//                //prior to executing the application that uses the source.
//                //Execute this sample a second time to use the new source.
//                EventLog.CreateEventSource("MySource", "MyNewLog");
//                Console.WriteLine("CreatedEventSource");
//                Console.WriteLine("Exiting, execute the application a second time to use the source.");
//                // The source is created.  Exit the application to allow it to be registered.
//                return;
//            }

//            // Create an EventLog instance and assign its log name.
//            EventLog myLog = new EventLog("myNewLog");
//            myLog.Source = "MySource";
//            myLog.WriteEntry("aaa");

//            // Read the event log entries.
//            foreach (EventLogEntry entry in myLog.Entries)
//            {
//                Console.WriteLine("\tEntry: " + entry.Message);
//            }

//            // Debug.Assert(false, "message", "detail message", new object[] { "a", "b", "c" });

//            // Clear the default listener:
//            Trace.Listeners.Clear();
//            // Add a writer that appends to the trace.txt file:
//            Trace.Listeners.Add(new TextWriterTraceListener("trace.txt"));
//            // Obtain the Console's output stream, then add that as a listener:
//            //System.IO.TextWriter tw = Console.Out;
//            // Trace.Listeners.Add(new TextWriterTraceListener(tw));
//            // Set up a Windows Event log source and then create/add listener.
//            // CreateEventSource requires administrative elevation, so this would
//            // typically be done in application setup.
//            if (!EventLog.SourceExists("DemoApp"))
//                EventLog.CreateEventSource("DemoApp", "Application");
//            Trace.Listeners.Add(new EventLogTraceListener("DemoApp"));

//            Debug.Assert(false);

//            Trace.TraceInformation("Trace.TraceInformation");
//            Trace.TraceWarning("Trace.TraceWarning");
//            Trace.TraceError("Trace.TraceError");


//            Console.WriteLine("Before calling DelayFunction");
//            var ret = DelayFunctionT(5).Result;
//            Console.WriteLine("After calling DelayFunction");
//            Console.WriteLine("Return result: {0}", ret);
//            Console.ReadKey();

//            Console.WriteLine("Before calling DelayFunction");
//            MyDelegate myDelegate = new MyDelegate(DelayFunction);
//            var xx = myDelegate.BeginInvoke(5, testCallBack, myObject);
//            Console.WriteLine("After calling BeginInvoke");

//            ret = myDelegate.EndInvoke(xx);
//            Console.WriteLine("After calling DelayFunction");
//            Console.WriteLine("Return result: {0}", ret);
//            Console.ReadKey();

//            //var ad = async(Int32 par) => { await DelayFunctionT(par)};
//        }

//        private static void testCallBack(IAsyncResult ar)
//        {
//            throw new NotImplementedException();
//        }

//        public static bool DelayFunction(Int32 seconds)
//        {
//            Console.WriteLine("Before calling sleep for {0} seconds", seconds);
//            System.Threading.Thread.Sleep(1000 * seconds);
//            Console.WriteLine("After calling sleep");
//            return true;
//        }

//        public static async Task<bool> DelayFunctionT(Int32 seconds)
//        {
//            Console.WriteLine("Before calling sleep for {0} seconds", seconds);
//            await Task.Delay(1000 * seconds);
//            Console.WriteLine("After calling sleep");
//            return true;
//        }

//        public class TestAsync
//        {

//        }
//    }
//}
