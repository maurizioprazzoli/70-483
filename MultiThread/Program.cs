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
        private static void testFunctionInForegroundThread()
        {
            for (Int32 i = 0; i < 100000; i++)
            {
                Console.WriteLine("Line number: {0}", i);
            }
        }

        private static void testFunctionInBackgroungThread()
        {
            for (Int32 i = 0; i < 100000; i++)
            {
                Console.WriteLine("Line number: {0}", i);
            }
        }

        private static void testFunctionInForegroundThreadWithParam(object par1)
        {
            for (Int32 i = 0; i < (Int32)par1; i++)
            {
                Console.WriteLine("Line number: {0} - par1: {1}", i, par1);
            }
        }

        static void Main(string[] args)
        {
            Int32 useCase = 4;

            // Use foregroung thread.
            // Application can complete until all foreground thread has terminate
            if (useCase == 1)
            {
                Thread t = new Thread(testFunctionInForegroundThread);
                t.IsBackground = false;
                t.Start();
                for (Int32 i = 0; i < 10; i++)
                {
                    Console.WriteLine("Main thread Line number: {0}", i);
                }
            }

            // Use background thread.
            // Application can complete until all foreground thread has terminate
            if (useCase == 2)
            {
                Thread t = new Thread(testFunctionInBackgroungThread);
                t.IsBackground = true;
                t.Start();
                for (Int32 i = 0; i < 10; i++)
                {
                    Console.WriteLine("Main thread Line number: {0}", i);
                }
            }

            // Use foreground thread.
            // Pass argument to thread
            // Application can complete until all foreground thread has terminate
            if (useCase == 3)
            {

                Thread t = new Thread(testFunctionInForegroundThreadWithParam);
                t.IsBackground = false;
                t.Start(4);
            }

            // Use foreground thread.
            // Pass argument to thread
            // Application can complete until all foreground thread has terminate
            if (useCase == 4)
            {
                var exitFormThread = false;
                Thread t = new Thread(() => {
                                                while(!exitFormThread)
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

        }
    }
}
