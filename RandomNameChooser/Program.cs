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
            try
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
            }
            catch
            {
                Console.WriteLine("An error occured while picking a random name", Color.Red);
                Console.ReadLine();

            }

        }
    }
}
