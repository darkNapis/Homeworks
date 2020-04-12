using System;

namespace HomeworkClass5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            //string normal = "we love C#";

            //string reverse = "";

            //int reverseLength;

            //reverseLength = normal.Length - 1;

            //while (reverseLength >= 0)
            //{
            //    reverse = reverse + normal[reverseLength];
            //    reverseLength--;
            //}

            //Console.WriteLine(reverse);

            //// Task 2

            //string words = "I love C#";

            //string[] countWords = words.Split(" ");

            //Console.WriteLine("I love C# contains " + countWords.Length + " words.");

            // Task 3

            //string sentence = "We want this situation with covid-19 to ends!".Replace(" ", "").ToLower();
            //char[] toChar = sentence.ToCharArray();

            //var maxChar = " ";
            //var count = 0;

            //for (int i = 0; i < toChar.Length; i++)
            //{
            //    var currentCount = 0;
            //    for (int j = i; j < toChar.Length; j++)
            //    {
            //        if (toChar[i] == toChar[j])
            //        {
            //            currentCount++;
            //        }                  
            //    }
            //    if (currentCount > count)
            //    {                 
            //        maxChar = toChar[i].ToString();
            //        count = currentCount;                   
            //    }
            //}
            //Console.WriteLine($"The highest frequency of character {maxChar} appears number of times: {count}");
            //Console.ReadLine();

            //Console.WriteLine($"The highest frequency of character  appears number of times: " + countMax);
            //Console.ReadLine();

            // Task 4

            //string wholeText = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";

            //string wholeTextAfter = wholeText.Substring(wholeText.IndexOf(',') + 1);

            //Console.WriteLine(wholeTextAfter);

            // Task 5

            //var today = DateTime.Now;

            //var year = today.Year;
            //var month = today.Month;
            //var day = today.Day;
            //var hour = today.Hour;
            //var minute = today.Minute;
            //var second = today.Second;

            //Console.WriteLine($"Year = {year}");
            //Console.WriteLine($"Month = {month}");
            //Console.WriteLine($"Day = {day}");
            //Console.WriteLine($"Hour = {hour}");
            //Console.WriteLine($"Minute = {minute}");
            //Console.WriteLine($"Second = {second}");

            // Task 6

            //for (int year = 2008; year <= 2020; year++)
            //{               
            //    if (DateTime.IsLeapYear(year))
            //    {
            //        Console.WriteLine("{0} is a Leap Year.", year);
            //    }
            //}

            // Task 7

            //            Dog dog1 = new Dog();

            //            Console.WriteLine("Enter the dog's name: ");

            //            dog1.Name = Console.ReadLine();

            //            Console.WriteLine("Enter the dog's race: ");
            //            dog1.Race = Console.ReadLine();

            //            Console.WriteLine("Please enter your dog's color:");
            //            dog1.Color = Console.ReadLine();

            //            Console.WriteLine("Choose one option and tell us what your dog is doing at the moment:");
            //            Console.WriteLine("Option 1 = Eat");
            //            Console.WriteLine("Option 2 = Play");
            //            Console.WriteLine("Option 3 = ChaseTail"); 

            //            var op = Convert.ToString(Console.ReadLine());

            //            switch (op)
            //            {
            //                case "1":
            //                    {                      
            //                        dog1.Eat();                                     
            //                        break;
            //                    }
            //                case "2":
            //                    {                   
            //                        dog1.Play();                     
            //                        break;
            //                    }
            //                case "3":
            //                    {   
            //                         dog1.ChaseTail();
            //                         break;
            //                    }
            //                default:
            //                    {
            //                        Console.WriteLine("You choose wrong option");
            //                        break;
            //                    }
            //            }

            // Task 8

            //Human human1 = new Human();

            //Console.WriteLine("Enter your first name: ");
            //human1.FirstName = Console.ReadLine();

            //Console.WriteLine("Enter your last name: ");
            //human1.LastName = Console.ReadLine();

            //Console.WriteLine("Enter your age: ");
            //human1.Age = Convert.ToInt32(Console.ReadLine());

            //human1.GetPersonStats();

        }

        //public class Human
        //{
        //    public Human()
        //    {

        //    }

        //    public string FirstName;
        //    public string LastName;
        //    public int Age;

        //    public void GetPersonStats()
        //    {
        //        Console.WriteLine($"I'm {FirstName} {LastName}, and I'm {Age} years old");
        //    }

        //    public class Dog
        //    {
        //        public Dog()
        //        {

        //        }

        //        public string Name;
        //        public string Race;
        //        public string Color;


        //        public void Eat()
        //        {          
        //            Console.WriteLine($"Your {Color} {Race} {Name} is now eating.");
        //        }

        //        public void Play()
        //        {
        //            Console.WriteLine($"Your {Color} {Race} {Name} is now playing.");
        //        }

        //        public void ChaseTail()
        //        {
        //            Console.WriteLine($"Your {Color} {Race} {Name} is now chaising its tail.");
        //        }
    }
}
