using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girrafe1
{
    class Program
    {
        static void Main(string[] args)
        {

           //string characterName = "Eliud";
            //int characterAge;
            //characterAge = 7;
            //// This is a simple C# console application that prints "Hello, World!" to the console.
            //Console.WriteLine("Hello, World! " + characterName);
            //// Print the character's name and age
            //Console.WriteLine("Character Name: " + characterName);
            //Console.WriteLine("Character Age: " + characterAge);
            //characterName = "Nickson";
            //characterAge = 8;
            //// Print the updated character's name and age
            //Console.WriteLine("my name is " + characterName + " and I am " + characterAge + " years old.");
            //// single character 
            //char grade = 'A';
            ////number 
            //double gpa = 4.5;
            //decimal num1 = 722.345M;
            //// booleans
            //bool isMale = true;
            //bool isFemale = false;
            // Wait for user input before closing the console window
            //string color, pluralNoun, celebrity;
            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();
            //Console.Write("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();
            //Console.Write("Enter a celebrity: ");
            //celebrity = Console.ReadLine();


            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I love " + celebrity);

            //arrays
            string[] friends = new string[5];
            friends[0] = "Kevin";
            friends[1] = "Karen";
            friends[2] = "Oscar";
            friends[3] = "Jim";
            friends[4] = "Dwight";
            // Print the first friend's name
            Console.WriteLine("First friend: " + friends[0]);
            // Print all friends' names
            Console.WriteLine("All friends:");
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }
            // List of integers
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine(luckyNumbers.Length); // Print the length of the array
            // Print all lucky numbers
            
            foreach (int number in luckyNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(luckyNumbers[2]); // Print the third lucky number
            luckyNumbers[1] = 100; // Change the second lucky number

            //Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine("----updated lucky Numbers:---- ");
            foreach ( int num in luckyNumbers)
            {
                Console.WriteLine(num);
            }

            // Call the SayHi method
            //SayHi("Eliud", 7);
            //Console.WriteLine("the cube is " + cube(3));
            // Call the cube method
            int resultCube = cube(3);
            Console.WriteLine("The cube of 3 is: " + resultCube);

            //if statements
            int age = 19;
            bool isMale = false;

            if (age >= 18 && isMale)
            {
                Console.WriteLine("You are a male adult."); //this whole block is false if one of the conditions is false
            }
            else
            {
                Console.WriteLine("You are either a not a male or you're a minor or both .");
            }

            //if statements with OR 
            if (age >= 18 || isMale)
            {
                Console.WriteLine("You are either an adult or  male or both."); // this whole block is true if one of the conditions is true
            } else             {
                Console.WriteLine("You are neither an adult nor male .");
            }


            Console.WriteLine("the max number is : " + getMax(10, 90, 30));
            Console.WriteLine(GetDay(0));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }

        //methods make sure to call it in the main method
        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + ", you are " + age + " years old.");
        //}

        //return methods 
        static int cube ( int num )
        {
            int result = num * num * num;
            return result;
        }

        static int getMax(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
            

        }

        //switch statements 
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName; 
        }
    }
}