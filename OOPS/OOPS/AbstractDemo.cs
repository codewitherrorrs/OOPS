using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract class AbstractDemo
    {
        public abstract void Sum();
    }
    class Children : AbstractDemo
    {
        public override void Sum() 
        {
            int account = 256485;
            double balance = 2500.50;
            Console.WriteLine($"The Account Number is : {account} and Balance is ; {balance}");
        }
    }
}
