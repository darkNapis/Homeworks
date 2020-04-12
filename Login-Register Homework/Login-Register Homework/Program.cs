using System;

namespace Login_Register_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Log in or Register");
            int login = 1;
            int register = 2;
            if(login == 1)
            {
                Console.WriteLine("Log in:");
            }
            else if(register == 2)
            {
                Console.WriteLine("Register:");
            }
            else
            {
                Console.WriteLine("You choose invalid input");
            }

            int Obidi;
            string korIme = "Darko Nikolikj";
            string loz = "blabla";

            Console.WriteLine("Login");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Vnesete Korisnicko ime");
                string korIme2 = Console.ReadLine();
                Console.WriteLine("Vnesete Lozinka");
                string loz2 = Console.ReadLine();


            }
        }
    }
}
