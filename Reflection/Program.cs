using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        private static Assembly ResolveEventHandler(Object sender, ResolveEventArgs args)
        {
            String dllName = new AssemblyName(args.Name).Name + ".dll";
            Console.WriteLine("ResolveEventHandler calleded for assembly : {0}", dllName);
            return null;
        }

        public static Assembly ReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
        {
            String dllName = new AssemblyName(args.Name).Name + ".dll";
            Console.WriteLine("ReflectionOnlyAssemblyResolve calleded for assembly : {0}", dllName);
            return null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Load External assembly wih Assembly.LoadFrom");
            var a = Assembly.LoadFrom(@"C:\Users\Maurizio\Source\Repos\70-483\ReflectionAssembly\bin\Debug\ReflectionAssembly.dll");
            Console.WriteLine("Assembly Loaded: {0}", a.FullName);

            WriteAssemblyExportedMethod(a);


            Console.WriteLine("Load not existing assembly wih Assembly.Load");
            try
            {
                a = Assembly.LoadFrom(@"NotExist.dll");
                Console.WriteLine("Assembly Loaded: {0}", a.FullName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Assembly Load Exception: {0}", ex);
            }

            Console.WriteLine("Assembly Loaded: {0}", a.FullName);

            Console.ReadKey();

        }

        private static void WriteAssemblyExportedMethod(Assembly a)
        {
            // Execute this loop once for each Type
            // publicly-exported from the loaded assembly
            foreach (Type t in a.ExportedTypes)
            {
                // Display the full name of the type
                Console.WriteLine(t.FullName);
                AppDomain adCallingThreadDomain = System.Threading.Thread.GetDomain();
                var ci = adCallingThreadDomain.CreateInstance(a.FullName, t.FullName);
                var ciau = adCallingThreadDomain.CreateInstanceAndUnwrap(a.FullName, t.FullName);
            }
        }

    }
}
