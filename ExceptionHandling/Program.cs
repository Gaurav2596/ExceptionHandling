using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student stud = new Student();
            //try
            //{
            //    stud.AcceptDetails("", 20);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            Calculation c = new Calculation();
            int result = c.Square(5);
            Console.WriteLine(result);

            Console.WriteLine(c.Multiply(4, 5));
        }
    }
}
