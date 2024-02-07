using System;
using System.Collections.Generic;
using System.Linq;
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

            if (n%2 == 0 ) 
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
            int[] arr = {5,8,4,6,1,25};
            /* (int i in arr)
            {
                if(i%5 == 0) { Console.WriteLine(arr[i]); }
            }*/
            for(int i = 0; i < arr.Length; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine($"Number is divisable by index {i} is {arr[i]}");
                }
            }
            
        }
        void Q3()
        {
            int fact=1;
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
           
            for(int i = 1;i <=n;i++)
            {
                fact = fact * i;
            }
           
            Console.WriteLine(fact);
        }
        void Q4()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter a number");
            for (int i = 0;i <a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            foreach(int k in a)
            {
                if (k < 10)
                {
                    Console.WriteLine("number is less than 10 is" +k);
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

            while (tmp != 0) {
               
               int digit=tmp%10;
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


        static void Main(string[] args)
        {
            Class3 n= new Class3();
            //n.Q1();
            //n.Q2();
            // n.Q3();
            //n.Q4();
            // n.Q5();
           // n.Q6();

            Console.ReadKey();
        }
    }
}
