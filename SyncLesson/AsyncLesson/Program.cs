using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLesson
{
    class Program
    {
        private static Func<int, int> action;

        static void Main(string[] args)
        {
            action = new Func<int, int>(CalculateSophisticNumber);
            //action();

            var result7 = action?.BeginInvoke(123, ProcessResult, null);
            var result0 = action?.BeginInvoke(123, ProcessResult, null);
            var result = action?.BeginInvoke(123, ProcessResult, null);
            var result8 = action?.BeginInvoke(123, ProcessResult, null);
            var result6 = action?.BeginInvoke(123, ProcessResult, null);
            var result5 = action?.BeginInvoke(123, ProcessResult, null);
            var result4 = action?.BeginInvoke(123, ProcessResult, null);
            var result2 = action?.BeginInvoke(321, ProcessResult, null);
            var result3 = action?.BeginInvoke(322,  ProcessResult, null);

            //while (!result.IsCompleted)
            //{
            //    Console.WriteLine("РАБ РАБОТАЕТ");
            //    Thread.Sleep(500);
            //}
            
            Console.WriteLine("ГЛАВНЫЙ ПОТОК ЗАВЕРШИЛ РАБОТУ");
            Console.ReadKey();
        }

        private static int CalculateSophisticNumber(int number)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - выполняет работу");
            Thread.Sleep(5000);
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - закончил  работу");
            return number;
        }

        private static void ProcessResult(IAsyncResult result)
        {
            Console.WriteLine(action.EndInvoke(result));
        }
    }
}
