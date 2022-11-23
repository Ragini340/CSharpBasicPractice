using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VerifyAccessibility1
    {
        static void Main(string[] args)
        {
            AccessSpecifierPOC obj = new AccessSpecifierPOC();
            obj.Test2();
            obj.Test4();
            obj.Test5();
            Console.ReadLine();
        }
    }
}
