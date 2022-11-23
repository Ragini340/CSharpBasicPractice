using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AccessSpecifierPOC
    {
        private void Test1()
        {
            Console.WriteLine("Private Method");
        }
        internal void Test2()
        {
            Console.WriteLine("Internal Method");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }
        protected internal void Test4()
        {
            Console.WriteLine("Protected internal Method");
        }
        public void Test5()
        {
            Console.WriteLine("Public Method");
        }
        static void Main(string[] args)
        {
            AccessSpecifierPOC obj = new AccessSpecifierPOC();
            obj.Test1();
            obj.Test2();
            obj.Test3();
            obj.Test4();
            obj.Test5();
            Console.ReadLine();

        }
    }
}
