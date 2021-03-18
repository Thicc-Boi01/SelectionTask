using System;

namespace SelectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Please enter your user name");

            string username = Console.ReadLine();

            if (username == "Hard")
            {
                Console.WriteLine("Please enter your password");

                string password = Console.ReadLine();

                if (password == "Copy")
                {
                    Console.WriteLine("Logging in...");
                    Console.WriteLine("Welcome Tom");
                }
                else
                {
                    Console.WriteLine("Incorect Password");
                }
            }
            else {
                Console.WriteLine("User Does Not Exist");
            }
        }
    }
}
