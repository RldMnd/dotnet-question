/*
 * Что выведет программа и почему? Что если вместо Task.Delay() использовать Thread.Sleep()?
 */

namespace ThreadingExample
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Start!");
            
            var t = Writer();

            Console.WriteLine("Finish!");
        }

        private static async Task Writer()
        {
            await Task.Delay(50);
            Console.WriteLine("writer");
        }
    }
}