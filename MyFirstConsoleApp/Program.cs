using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // get data from a user
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            bool isStudent = true;

            //Signed = negative possible. u in front = unsigned, no negative, twice as high positive. 
            // 32 bit signed number.
            int favoriteNumber = 28;

            // 64 bit signed number. Takes up 2x memory space. 
            long bigNumber = 9_125_054_737_495_432_028;

            //16 bit signed number
            short smallerNumber = 32_767;

            // stuff with decimals 
            decimal accountBalance = 0.58m;
            double stockBalance = 0.64d;


            // var is a shorthand for the real type. Introduced in 2005, most common used in workspace
            // type inference. 
            var myStuff = 5 * 5;
            // this still won't work
            // myStuff = "string"

            // Arrays must be initialized with data type and total values that it can hold
            // Arrays are not as much fun in C#, given they cannot grow past initial declared size or type
            var studentsArray = new string[5];


            // instance / instantiation / new creates a new instance of something. call constructor()
            //             list of string
            var students = new List<string>();

            students.Add("Casey");
            students.Add("Juan");
            students.Add("Tad");
            students.Add("Rando");

            students.Remove("Rando");

            for (var i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            foreach(var student in students)
            {
                Console.WriteLine(student);
            }

            // csharp one equal for set and two for equality. three isn't used because type is static
        }
    }
}
