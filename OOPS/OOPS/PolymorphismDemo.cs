using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class PolymorphismDemo
    {
       public void sound()
        {
            Console.WriteLine("The Sound of Parent is wwww");
        }
    }

    public class Child : PolymorphismDemo
    {
        public void sound()
        {
            Console.WriteLine("The Sound of Child is hohohoh");
        }
    }
}
