using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class ObjectAndClass
    {
        public void addition(int a,int b)
        {
            Console.WriteLine($"The Addition of a and b : {a+b}");
        }

        public void addition(float a, float b)
        {
            Console.WriteLine($"The Addition of a and b : {a + b}");
        }

        public void addition(double a, double b)
        {
            Console.WriteLine($"The Addition of a and b : {a + b}");
        }

        public void addition(string a, string b)
        {
            Console.WriteLine($"The Addition of a and b : {a + b}");
        }

        public string addition()
        {
            bool a = true;
            bool b = false;
            if (a == b)
            {
               return "True";
            }
            else
            {
               return "False";
            }
        }

        public virtual void Sum(int a,int b)
        {
            Console.WriteLine($"The Sum of Parent Class : {a+b}");
        }
    }

    class Inherit : ObjectAndClass
    {
        public override void Sum(int a,int b)
        {
            Console.WriteLine($"The Sum of Child Class : {a+b}");
        }
    }
}
