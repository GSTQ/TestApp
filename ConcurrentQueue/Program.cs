using System;
using System.Threading.Tasks;

namespace ConcurrentQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestAsync();
            Console.ReadKey();
        }

        private static async void TestAsync()
        {
            var queue = new ConcurentQueue<String>();

            await Task.Factory.StartNew(async () =>
            {
                var data = await queue.Pop();
                Console.WriteLine(data);
            });

            await Task.Factory.StartNew(async () =>
            {
                var data = await queue.Pop();
                Console.WriteLine(data);
            });

            await Task.Factory.StartNew(async () =>
            {
                var data = await queue.Pop();
                Console.WriteLine(data);
            });

            await Task.Factory.StartNew(async () =>
            {
                var data = await queue.Pop();
                Console.WriteLine(data);
            });

            await Task.Factory.StartNew(async () =>
            {
                var data = await queue.Pop();
                Console.WriteLine(data);
            });

            await Task.Factory.StartNew(() =>
            {
                queue.Push("Task1");
            });

            await Task.Factory.StartNew(() =>
            {
                queue.Push("Task2");
            });

            await Task.Factory.StartNew(() =>
            {
                queue.Push("Task3");
            });

            await Task.Factory.StartNew(() =>
            {
                queue.Push("Task4");
            });

            await Task.Factory.StartNew(() =>
            {
                queue.Push("Task5");
            });
        }
    }
}
