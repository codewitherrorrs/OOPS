namespace OOPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ObjectAndClass obj = new ObjectAndClass();
            //obj.addition(20, 30);

            Inherit inherit= new Inherit();
            inherit.addition(30, 30);
            inherit.addition(25.3, 30.65);
            inherit.addition(3.030, 23.030);
            inherit.addition("Hello"," World");
            Console.WriteLine(inherit.addition());
        }
    }
}