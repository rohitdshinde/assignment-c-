using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        void Q1()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else if (n % 2 == 1)
            {
                Console.WriteLine("Number is odd");
            }
        }

        void Q2()
        {
            int[] arr = { 5, 8, 4, 6, 1, 25 };
            /* (int i in arr)
            {
                if(i%5 == 0) { Console.WriteLine(arr[i]); }
            }*/
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine($"Number is divisable by index {i} is {arr[i]}");
                }
            }

        }
        void Q3()
        {
            int fact = 1;
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);
        }
        void Q4()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter a number");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int k in a)
            {
                if (k < 10)
                {
                    Console.WriteLine("number is less than 10 is" + k);
                }
            }
        }
        void Q5()
        {
            int count = 0;
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;

                }

            }
            if (count == 2)
            {
                Console.WriteLine("Prime");

            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
        void Q6()
        {


            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int tmp = n, sum = 0;

            while (tmp != 0)
            {

                int digit = tmp % 10;
                sum = sum * 10 + digit;
                tmp = tmp / 10;


            }
            if (n == sum)
            {
                Console.WriteLine("Paildrome YES");
            }
            else
            {
                Console.WriteLine("Paildrome Not");
            }
        }
        void Q7()
        {
            try
            {
                Console.WriteLine("Enter a number");
                double number = double.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentException("Number is negative");
                }
                double square = Math.Sqrt(number);
                Console.WriteLine($"the square of {number} is {square}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input" + ex);
            }
        }
        void Q8()
        {
            try
            {
                Console.WriteLine("Enter the first number");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Second number");
                double num2 = double.Parse(Console.ReadLine());

                double result = num1 / num2;
                Console.WriteLine("Result is" + result);



            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
        void Q9()
        {
            Console.WriteLine("Enter three letters");
            string strr = Console.ReadLine();

            if (strr.Length == 3)
            {

                char letter1 = strr[0];
                char letter2 = strr[1];
                char letter3 = strr[2];

                Console.WriteLine($"Letters in reverse order  {letter3}{letter2}{letter1}");
            }
            else
            {
                Console.WriteLine("please enter exactly three line");
            }
        }


        /*
        void Q10()
        {
            Console.WriteLine("Enter  a chracter:");
            char a = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsDigit(a))
            {
                Console.WriteLine("the chracter is digit");
            }
            else if (char.IsLetter(a))
            {
                Console.WriteLine("the chracter is letter");
            }
            else if (Isvowel(a))
            {
                Console.WriteLine("the character is vowel");
            }
            else
            {
                Console.WriteLine("The chracter is symbol");
            }




        }
        static bool Isvowel(char ch)
        {
            ch = char.ToLower(ch);
            return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
        }




    }
        */

        void Q11()
        {
            Console.WriteLine("Enter a height");
            double height = double.Parse(Console.ReadLine());

            string cat;

            if (height < 150)
            {
                cat = "short";

            }
            else if (height >= 150 && height < 170)
            {
                cat = "Avrage";

            }
            else if (height >= 170 && height < 200)
            {
                cat = "tall";
            }
            else
            {
                cat = "very tall";
            }

            Console.WriteLine($"Your height catgeory is {cat}");
        }
        void Q12()
        {
                Console.WriteLine("Enter Student Details:");

                Console.Write("Roll Number: ");
                int rollNo = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Marks in Subject 1: ");
                int subject1Marks = int.Parse(Console.ReadLine());

                Console.Write("Marks in Subject 2: ");
                int subject2Marks = int.Parse(Console.ReadLine());

                Console.Write("Marks in Subject 3: ");
                int subject3Marks = int.Parse(Console.ReadLine());

                int totalMarks = subject1Marks + subject2Marks + subject3Marks;
                double percentage = (totalMarks / 300.0) * 100;

                string division;

                if (percentage >= 60)
                {
                    division = "First Division";
                }
                else if (percentage >= 45)
                {
                    division = "Second Division";
                }
                else if (percentage >= 33)
                {
                    division = "Third Division";
                }
                else
                {
                    division = "Fail";
                }

                Console.WriteLine("\nStudent Report:");
                Console.WriteLine($"Roll Number: {rollNo}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Total Marks: {totalMarks}");
                Console.WriteLine($"Percentage: {percentage:F2}%");
                Console.WriteLine($"Division: {division}");   

    }
    static void Main(string[] args)
        {
            Class3 n = new Class3();
            //n.Q1();
            //n.Q2();
            //n.Q3();
            //n.Q4();
            //n.Q5();
            //n.Q6();
            //n.Q7();
            //n.Q8();
            //n.Q9();
            //n.Q10();
            //n.Q11();
            n.Q12();
        }

    }
}