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
            Console.ReadLine();


        }
    }
}
