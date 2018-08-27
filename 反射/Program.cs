using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 反射
{
    class Program
    {
        static async void Main(string[] args)
        {
            //普通调用
            //Thread Th = new Thread(new ThreadStart(newThread));
            //Th.Start();

            // 委托调用
            //Thread Th = new Thread(()=> {

            //    Console.WriteLine("开启了新的线程"); 

            //}); 

            //Th.Start();

            ////线程池创建
            //ThreadPool.SetMaxThreads(5,5); 

            //for (int i = 0; i < 100; i++)
            //{ 

            //    ThreadPool.QueueUserWorkItem((state) => {

            //        Console.WriteLine($"线程池创建了新的线程 {a}");

            //    });

            //}

           

            //利用Task 运行
            //var Task1 = new Task(()=> {

            //    Console.WriteLine("Task1 Start ...");

            //});


            //var Task2 = new Task(() => {

            //    Console.WriteLine("Task2 Start ...");

            //});

            //var Task3 = new Task(() => {

            //    Console.WriteLine("Task3 Start ...");

            //}); 

            
           
          


            //Task1.RunSynchronously();
            //Task2.RunSynchronously();
            //Task3.RunSynchronously();

            
            //Console.WriteLine(" End ...  "); 

           

            var str = await GetGuid();

            Console.WriteLine($" str : {str}");
            Console.WriteLine("ts");
           




            Console.ReadKey();



        }


        static void newThread()
        {

            Console.WriteLine($"Thread Start {DateTime.Now.ToString()}"); 

        }

        static async Task<string> GetGuid()
        {
            await Task.Delay(1000);

            return new Guid().ToString(); 
        } 


    }
}
