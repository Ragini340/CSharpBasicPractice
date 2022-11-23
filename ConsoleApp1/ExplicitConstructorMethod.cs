using System;


namespace ConsoleApp1
{
    class ExplicitConstructorMethod
    {
        public ExplicitConstructorMethod()
        {
            Console.WriteLine("Explicit constructor is called");
        }
        static void Main(String[] args)
        {
            ExplicitConstructorMethod obj = new ExplicitConstructorMethod();
            Console.ReadKey();



        }
    }
}
