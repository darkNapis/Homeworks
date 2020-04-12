using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Input the type of arithmetic operation = ");
            var function = Convert.ToChar(Console.ReadLine());
                       
            Console.WriteLine("Enter the first number = ");
            double first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number = ");
            double second = Convert.ToInt32(Console.ReadLine());

            switch (function)
            {
                case '+':
                    {                       
                        Console.WriteLine("The result is: " + Sum(first, second));
                        Console.WriteLine("Thank you for using the calculator. The aplication will automatically close");
                        break;
                    }
                case '-':
                    {                        
                        Console.WriteLine("The result is: " + Sum1(first, second));
                        Console.WriteLine("Thank you for using the calculator. The aplication will automatically close");
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine("The result is: " + Sum2(first, second));
                        Console.WriteLine("Thank you for using the calculator. The aplication will automatically close");
                        break;
                    }
                case '/':
                    {
                        if(first != 0 && second != 0) 
                            {
                            Console.WriteLine("The result is: " + Sum3(first, second));
                            Console.WriteLine("Thank you for using the calculator. The aplication will automatically close");
                        }
                        else
                        {
                            Console.WriteLine("Division with zero is not posible");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Invalid choice. Try again...");    
                    break;
            }
            Console.ReadLine();
        }

        public static double Sum(double first, double second)
        {
            return first + second;
        }

        public static double Sum1(double first, double second)
        {
            return first - second;
        }

        public static double Sum2(double first, double second)
        {
            return first * second;
        }

        public static double Sum3(double first, double second)
        {
            return first / second;
        }
    }
}
