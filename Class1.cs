using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        void add()
        {
            int num, sum = 0;
            double avg = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter a number {i + 1} ");
                num = Convert.ToInt32(Console.ReadLine());

                sum += num;

                avg = sum / 5.0;
            }

            Console.WriteLine("Sum of numbers" + sum);

            Console.WriteLine("Avrage of number " + avg);
            Console.ReadKey();

        }

        void swap()
        {
            
            Console.WriteLine("Enter a Chracter");
            string strr= Console.ReadLine();

            if (strr.Length >= 2)
            {
                char[] arr= strr.ToCharArray();
                char temp = arr[0];
                arr[0] = arr[strr.Length-1];
                arr[strr.Length-1] = temp;

                 string strr1= new string(arr);

                Console.WriteLine("After a swapping  " + strr1);

            }
            else
            {
                Console.WriteLine("Plz enter atleat more character");
            }
        }

        void lowercase()
        {
            Console.WriteLine("Enter a string");
            string strr=Console.ReadLine();

            string strr2 = strr.ToUpper();

            Console.WriteLine();
            Console.WriteLine("All letters are uppercase \n"+strr2);

        }
        void addofnum()
        {
            Console.WriteLine("Enter a number");
            int a=Convert.ToInt32(Console.ReadLine());

            int sum = 0,digit,og=a;

            while (a != 0)
            {
                digit = a % 10;
                sum += digit;
                a /=10;
               


            }
            Console.WriteLine($"Sum of Every number{og}: {sum}");
        }

        static void Main(string[] args)
        {
            Class1 p= new Class1();
            // p.add();
            // p.swap();
            // p.lowercase();
            p.addofnum();

            Console.ReadLine();
           
            
        }
    }
}
