using System;
using System.Drawing;
using System.Threading;
using Console = Colorful.Console;

namespace RandomNameChooser
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;

            while (again)
            {
                Console.WriteLine("Seziure attack!");
                Thread.Sleep(2000);
                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    Console.BackgroundColor = Color.White;
                    Console.Clear();
                    
                    Console.BackgroundColor = Color.Black;
                    Console.Clear();
                   
                }
                Console.BackgroundColor = Color.Black;
                Console.WriteLine(DateTime.Now.ToString("[hh:mm:ss]"), Color.Pink);
                Console.Write("How many names: ", Color.Pink);
                int amountNames = Convert.ToInt32(Console.ReadLine());
                string[] names = new string[amountNames];
                for (int i = 0; i < names.Length; i++)
                {
                    Console.Clear();
                    Console.Write("Enter Name: ", Color.Aqua);
                    names[i] = Console.ReadLine();
                }

                Console.Clear();
                Console.WriteLine("Names: " + string.Join(", ", names));
                System.Console.WriteLine("Enter to continue");
                Console.Read();

                Random rnd = new Random();
                var index = rnd.Next(names.Length);

                Console.WriteLine($"Picked Name: {names[index]}", Color.Green);
                string namePicked = Console.ReadLine();
                Console.ReadLine();

                Console.Write("do you wanna run it again? y/n ");
                string runAgain = Console.ReadLine();

                if (runAgain == "y")
                {
                    again = true;
                }
                else
                {
                    again = false;
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                }
            }

        }

    }
}

