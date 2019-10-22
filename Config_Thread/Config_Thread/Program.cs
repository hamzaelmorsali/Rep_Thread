using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Config_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(() =>
            {
                  Console.WriteLine("MyThread start");
                Thread.Sleep(1000);
                Console.WriteLine("MyThread finish");


            });
            myThread.Start();
            Thread.Sleep(500);
            Console.WriteLine("Main Thread ");
            

            string SomeVariable = "hamza el morsali";

            var workerThread = new Thread((o) =>
            {
                Console.WriteLine("Saluti da:{0}", o);

             });
            workerThread.Start(SomeVariable);
            var list = new List<Thread>();
            for (int index = 0; index < 5; index++)
            {
                var myThread2 = new Thread((currentindex) =>
                {
                    Console.WriteLine("Thread number"+" "+"{0} start", currentindex);
                    Thread.Sleep(500);
                                       
                    Console.WriteLine("Thread number"+" "+"{0} finish", currentindex);

                });
                myThread2.Start(index);
                list.Add(myThread2);
            }

            foreach(Thread thread in list)
            {
                thread.Join();
            }
            Console.WriteLine("execution af all thread finish");
            var workerthread=new Thread(()=>
            {
                Console.WriteLine("thread more long start");
                Thread.Sleep(5000);
                Console.WriteLine(" worker Thread finish");

            });
            workerthread.Start();
            workerthread.Join(500);
            if (workerthread.ThreadState != ThreadState.Stopped)
            {
                workerthread.Abort();
            }
            Console.WriteLine("Application finish");
            Console.ReadLine();

        }
    }
}
