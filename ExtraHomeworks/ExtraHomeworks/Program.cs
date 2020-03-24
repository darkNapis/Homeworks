using System;

namespace ExtraHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            // Write a C# Sharp program to find the sum of first 10 natural numbers
            //*Hint: The first 10 natural number are: 1 2 3 4 5 6 7 8 9 10

            //Console.WriteLine("Enter a number");

            //var input = Convert.ToInt32(Console.ReadLine());

            //var sum = 0;

            //for (int i = 1; i <= input; i++)
            //{
            //    sum = sum + i;             
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            // Task 2
            // Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.

            int[] numbers = new int[10];

            int numberOfElements = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numberOfElements = i + 1;

                Console.WriteLine("enter the " + numberOfElements + " number:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int avg = 0;

            foreach (var num in numbers)
            {
                sum += num;
                avg = sum / 10;
            }

            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.ReadLine();

            // Task 3
            // Declare and init array of 10 integers by your choise. 
            // Find maximum and minimum element in that array and their indexes.

            //int[] arr = new int[10] { 1, 2, 3, 4, 7, 10, 32, 5, 9, 8 };

            //int max = 0;
            //int min = 10000;
            //int indexOfMax = 0;
            //int indexOfMin = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if(arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    indexOfMax = Array.IndexOf(arr, max);
            //}
            //Console.WriteLine("Max number is " + max + " and his index number is on " + indexOfMax);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //    indexOfMin = Array.IndexOf(arr, min);
            //}
            //Console.WriteLine("Min number is " + min + " and his index number is on " + indexOfMin);
            //Console.ReadLine();

            // Task 4
            // arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9]
            // Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates

            //int[] arrayWithDuplicates = new int[] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };
            //int counter = 0;

            //for (int i = 0; i < arrayWithDuplicates.Length; i++)
            //{
            //    for (int d = i + 1; d < arrayWithDuplicates.Length; d++)
            //    {
            //        if (arrayWithDuplicates[i] == arrayWithDuplicates[d])
            //        {
            //            counter++;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine("Total number of duplicate elements found in array: " + counter);
            //Console.ReadLine();

            // Task 5
            // oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            // Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays

            //int[] oddEvenArray = { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            //int[] oddArray = new int[12];
            //int[] evenArray = new int[12];

            //int a;
            //int b = 0;
            //int c = 0;

            //for (a = 0; a < oddEvenArray.Length; a++)
            //{
            //    if (oddEvenArray[a] % 2 == 0)
            //    {
            //        evenArray[b] += oddEvenArray[a];
            //        b++;

            //    }
            //    else
            //    {
            //        oddArray[c] += oddEvenArray[a];
            //        c++;
            //    }
            //}

            //for (a = 0; a < b; a++)
            //{
            //    Console.WriteLine("Even elements are: " + evenArray[a]);
            //}

            //for (a = 0; a < c; a++)
            //{
            //    Console.WriteLine("Odd elements are: " + oddArray[a]);
            //}
            //Console.ReadLine();

            // Task 6
            // Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            // the day with strings.Example: user enters 1, you should print Monday.

            //int dayNum;

            //Console.Write("Input Day Number: ");
            //dayNum = Convert.ToInt32(Console.ReadLine());

            //switch (dayNum)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("Monday");
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("Tuesday");
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.WriteLine("Wednesday");
            //            break;
            //        }
            //    case 4:
            //        {
            //            Console.WriteLine("Thursday");
            //            break;
            //        }
            //    case 5:
            //        {
            //            Console.WriteLine("Friday");
            //            break;
            //        }
            //    case 6:
            //        {
            //            Console.WriteLine("Saturday");
            //            break;
            //        }
            //    case 7:
            //        {
            //            Console.WriteLine("Sunday");
            //            break;
            //        }
            //    default:
            //        Console.Write("Invalid day number. Please try again...");
            //        break;
            //}
            //Console.ReadLine();

            // Task 7
            //userNames = ["user1", "user2", "user3"]
            //passwords = ["first", "second", "third"]
            //Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //Create a logic when user enters specific username to provide a correct password for that user, and when that
            //happens you should print on the screen "You are logged in successfully".
            //If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and 
            //repeat the proccess from begining while he / she doesn't input correct username and password.

            //Note: Every element in userNames corresponds with the element in passwords at same index.
            //Example: password for "user1" is "first", password for "user2" is "second", password for "user3" is "third".

            //string[] userNames = new string[] { "user1", "user2", "user3" };
            //string[] passwords = new string[] { "first", "second", "third" };

            //while (true)
            //{
            //    Console.WriteLine("Please enter your username:");
            //    string userInput = (Console.ReadLine());

            //    Console.WriteLine("Please enter your password:");
            //    string passwordInput = (Console.ReadLine());

            //    if ((userInput == userNames[0] && passwordInput == passwords[0]) 
            //        || (userInput == userNames[1] && passwordInput == passwords[1]) 
            //        || (userInput == userNames[2] && passwordInput == passwords[2]))
            //    {
            //        Console.WriteLine("You are logged in successfully!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect username or password!");
            //    }
            //}
            //Console.ReadLine();
        }
    }
}
