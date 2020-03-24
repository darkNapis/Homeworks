using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework3

            // Task1

            //Console.WriteLine("Enter a number");

            //int input = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= input; i++)
            //{
            //    Console.WriteLine(i);   
            //}

            //Console.WriteLine("Enter a number");

            //int input1 = int.Parse(Console.ReadLine());

            //for (int i = input1; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            // Task 2

            //Console.WriteLine("Enter a number");

            //int input = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= input; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }      
            //}

            //Console.WriteLine("Enter a number");

            //int input = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= input; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Task 3

            string[] names = new string[] { };

            while (true)
            {
                Console.WriteLine("Please enter a name:");

                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = Console.ReadLine();

                Console.WriteLine("Do you want to add another name?");
                string answer;

                while (true)
                {
                    answer = Console.ReadLine().ToLower();

                    if (answer != "y" && answer != "n")
                    {
                        Console.WriteLine("Please enter correct answer (Y or N)");
                    }
                    else
                    {
                        break;
                    }
                }

                if (answer == "n")
                {
                    break;
                }
            }

            for (var i = 0; i < names.Length; i++)
            {
                var name = names[i];

                if (i != names.Length - 1)
                {
                    name += ", ";
                }

                Console.Write(name);
            }
            Console.ReadLine();
        }
    }
}
