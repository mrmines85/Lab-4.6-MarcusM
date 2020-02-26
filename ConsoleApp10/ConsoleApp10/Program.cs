using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] tasks = new string[7];

            for (int x = 0; x < days.Length; x++)
            {

                Console.WriteLine("Type in a new Task for " + days[x]);
                tasks[x] = days[x] + " : " + Console.ReadLine();

            }

            for (int x = 0; x < days.Length; x++)
            {
                Console.WriteLine(tasks[x]);
            }
        }
    }
}
