using System;

namespace dowhileloopinCsharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your target?");
            int userTarget = int.Parse(Console.ReadLine());

            int Start = 0;
            while (Start <= userTarget)
            {
                Console.WriteLine(Start + " ");
                Start = Start + 2;
            }

            Console.WriteLine("Do you want to continue - Yes or No?");


            String UserChoice = Console.ReadLine();
            if (UserChoice != "Yes" && UserChoice != "no")
            {
                Console.WriteLine("Invalid choice, please say yes or no");

            }
            while (UserChoice != "Yes" && UserChoice != "no") ;
        } 
    }
}
