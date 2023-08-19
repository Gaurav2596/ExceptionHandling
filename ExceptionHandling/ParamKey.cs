using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class ParamKey
    {
        public void AcceptNames(params string[] names)
        {
            Console.WriteLine("Count is" + names.Length);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Name
    {
        static void Main(string[] args)
        {
            ParamKey p = new ParamKey();
            p.AcceptNames("Gaurav","Jayesh");
            p.AcceptNames("Ganesh", "Ram", "Ramesh");
        }
    }
}

