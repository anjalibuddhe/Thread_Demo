using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    public class SampleThradDemo
    {

        public void M1()
        {
            Monitor.Enter(this);
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                   Monitor.Wait(this, 3000);
                }
            }
            Monitor.Exit(this);

            Monitor.Pulse(this);
            //Monitor.PulseAll(this);
        }
        //public void M1()
        //{
        //    Thread t1 = Thread.CurrentThread;
        //    Console.WriteLine(t1.Name);
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine(i);
        //        //Thread.Sleep(1000);
        //    }

        //}
        //public void M2()
        //{
        //    Thread t1 = Thread.CurrentThread;
        //    Console.WriteLine(t1.Name);
        //    for (int i = 10; i <= 15; i++)
        //    {
        //        Console.WriteLine(i);
        //        Thread.Sleep(2000);
        //    }

        //}

        public class Program
        {
            static void Main(string[] args)
            {
                SampleThradDemo obj=new SampleThradDemo();

                //obj.M1();
                //obj.M2(); 

                Thread t1 = new Thread(new ThreadStart(obj.M1));
                //Thread t2 = new Thread(new ThreadStart(obj.M2));
                t1.Name = "First Thread"; // assign a name to thread
               // t2.Name = "Second Thread";

                t1.Priority = ThreadPriority.Lowest;
               // t2.Priority = ThreadPriority.Highest;

                t1.Start();
                // t1.Join();
                // t1.Join(3000);
               // t2.Start();




            }
        }
    }
}
