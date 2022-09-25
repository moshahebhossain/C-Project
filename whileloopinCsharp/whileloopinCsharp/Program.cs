using System;

namespace whileloopinCsharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your target?");
            int userTarget = int.Parse(Console.ReadLine());

            int Start = 0;
            while (Start <= userTarget);
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }
    }
}
