using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        class emp {
            int emp_id;
            string emp_name;
            string emp_depart;
            int emp_exp;
            int emp_salary;

            public emp(int emp_id,string emp_name,string emp_depart, int emp_exp,int emp_salary)
            {
                this.emp_id = emp_id;
                this.emp_name = emp_name;
                this.emp_depart = emp_depart;
                this.emp_exp = emp_exp;
                this.emp_salary= emp_salary;
            }

            public string ToString()
            {
                return  emp_name;
                   

              /*  Console.WriteLine("id:"+emp_id);
                Console.WriteLine("Name:" + emp_name);
                Console.WriteLine("depart" + emp_depart);
                Console.WriteLine("exp" + emp_exp);
                Console.WriteLine("salary" + emp_salary);*/

            }
        }
        static void Main(string[] args)
        {
            emp p = new emp(1,"Rohit","bcs",2,350000);
            // p.display();
            Console.WriteLine(p.ToString());

            
        }
    }
}
