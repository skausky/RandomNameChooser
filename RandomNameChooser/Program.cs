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
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("How many names: ", Color.Aqua);
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.Write("How many names: ", Color.Pink);
                    Thread.Sleep(100);
                    Console.Clear();


                }
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
                    Environment.Exit(0);
                }
            }

        }

    }
}

