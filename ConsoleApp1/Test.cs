using System;


namespace ConsoleApp1
{
    class Test
    {
        int num1;
        int num2;
        int result;
     private void Add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private void Subtract()
        {
            result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Main(String[] args)
        {
            Test obj = new Test();
            obj.num1 = 10;
            obj.num2 = 20;
            obj.Add();
            obj.Subtract();
        }
    }
}
