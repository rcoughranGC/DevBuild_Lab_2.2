using System;

namespace Lab2_2
{
    class Program
    {
        static bool KeepGoing()
        {
            while (true) // intentional potential infinite loop to force y/n
            {
                Console.WriteLine("\nWould you like to go again? (y/n)");
                string response = Console.ReadLine();
                if (response.ToLower().StartsWith("y"))
                {
                    return true;
                }
                else if (response.ToLower().StartsWith("n"))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                }
            }
        }

        // Attempt to get an integer
        static int GetNumber()
        {
            int userInteger = 0;
            bool inRange = false;
            while (!inRange)
            { 
                Console.Write("\nEnter an integer: ");
                int.TryParse(Console.ReadLine(), out userInteger);

                // Validate range (greater than 0, max of 1290)
                if (userInteger <= 0)
                {
                    Console.WriteLine("The integer must greater than 0, please try again");
                }
                else if(userInteger > 1290)
                {
                    Console.WriteLine("Max integer is 1290, please try again.");
                }
                else
                {
                    inRange = true;
                }
            } 
            return userInteger;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            do
            {
                int numToPower = GetNumber();
                
                Console.WriteLine("\nNumber\t\tSquared\t\tCubed");
                Console.WriteLine("=======\t\t=======\t\t=======");

                for (int i = 1; i <= numToPower; i++)
                {
                    int squared = (int)Math.Pow(i, 2);
                    int cubed = (int)Math.Pow(i, 3);
                    
                    Console.WriteLine(String.Format($"{ i,7 }\t\t{ squared,7 }\t\t{ cubed,7 }"));
                }
            } 
            while (KeepGoing());
        }
    }
}
