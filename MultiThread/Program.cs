using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    class Program
    {
        private static void testFunctionNonParamVoidReturn()
        {
            for (Int32 i = 0; i < 100; i++)
            {
                Console.WriteLine("Line number: {0}", i);
            }
        }
        private static void testFunctionObjParamVoidReturn(object par1)
        {
            for (Int32 i = 0; i < (Int32)par1; i++)
            {
                Console.WriteLine("Line number: {0} - par1: {1}", i, par1);
            }
        }

        static void Main(string[] args)
        {
            Int32 useCase = 5;

            // Use foregroung thread.
            // Application can NON terminate until all foreground thread has terminate
            if (useCase == 1)
            {
                Thread t = new Thread(testFunctionNonParamVoidReturn);
                t.IsBackground = false;
                t.Start();
                for (Int32 i = 0; i < 10; i++)
                {
                    Console.WriteLine("Main thread Line number: {0}", i);
                }
            }

            // Use background thread.
            // Application CAN terminate even if some foreground thread hasn't terminate
            if (useCase == 2)
            {
                Thread t = new Thread(testFunctionNonParamVoidReturn);
                t.IsBackground = true;
                t.Start();
                for (Int32 i = 0; i < 10; i++)
                {
                    Console.WriteLine("Main thread Line number: {0}", i);
                }
            }

            // Use foreground thread.
            // Pass argument to thread
            if (useCase == 3)
            {
                Int32 threadParameter = 4;
                Thread t = new Thread(testFunctionObjParamVoidReturn);
                t.IsBackground = false;
                t.Start(threadParameter);
            }

            // Use foreground thread.
            // Share local variable with thread
            if (useCase == 4)
            {
                var exitFormThread = false;
                Thread t = new Thread(() =>
                {
                    while (!exitFormThread)
                    {
                        Console.WriteLine("Running ...");
                        Thread.Sleep(1000);
                    }

                });
                t.IsBackground = false;
                t.Start();
                Console.WriteLine("Press any key to exit.");
                Console.Read();
                exitFormThread = true;

            }


            if (useCase == 5)
            {
                Task t = Task.Run(action: testFunctionNonParamVoidReturn);
                t.Wait();
                
                Action a = testFunctionNonParamVoidReturn;
                Task t1 = Task.Run(a);
                t1.Wait();

                var r = Task.Run(() =>
                                   {
                                       return 42;
                                   });

                Console.WriteLine(r);

                var r1 = Task<Int32>.Run(() =>
                {
                    return 42;
                }).ContinueWith((arg) =>
                                 {
                                     Int32 res = arg.Result;
                                     return res * 2;
                                 });

                Console.WriteLine(r1.Result);
                Console.ReadLine();
            }
        }
    }
}
