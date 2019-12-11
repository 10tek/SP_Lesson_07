using System;
using System.Threading;
using System.Threading.Tasks;

namespace SyncLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var action = new Func<int>(CalculateSophisticNumber);
            //action();

            var result = action?.BeginInvoke(null,null);
            Console.WriteLine(result);
            Console.WriteLine("ГЛАВНЫЙ ПОТОК ЗАВЕРШИЛ РАБОТУ");
        }

        private static int CalculateSophisticNumber()
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - выполняет работу");
            Thread.Sleep(5000);
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - закончил  работу");
            return 20000;
        }
    }
}
