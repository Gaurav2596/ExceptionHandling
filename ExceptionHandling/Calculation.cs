using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Calculation
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
        public static class ExtensionClass
        {
            public static int Square(this Calculation c,int x)
            {
                return x*x;
            }
            public static int Multiply(this Calculation c,int x,int y) 
            {
                return x*y;
            }
        }
    }
