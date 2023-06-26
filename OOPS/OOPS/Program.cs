namespace OOPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
           /* PolymorphismDemo pd = new PolymorphismDemo();
            pd.sound();
            Child cd = new Child();
            cd.sound(); */

            Children cd = new Children();
            cd.Sum();
            /*ObjectAndClass obj = new ObjectAndClass();
            obj.Sum(20, 30);*/

            /*Inherit inherit= new Inherit();
            inherit.addition(30, 30);
            inherit.addition(25.3, 30.65);
            inherit.addition(3.030, 23.030);
            inherit.addition("Hello"," World");
            Console.WriteLine(inherit.addition());
            inherit.Sum(50,50);*/
        }
    }
}