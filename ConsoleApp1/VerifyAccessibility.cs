using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Consuming members of a class from same class
    class VerifyAccessibility:AccessSpecifierPOC
    {
        static void Main()
        {
            VerifyAccessibility obj = new VerifyAccessibility();
            obj.Test2();
            obj.Test3();
            obj.Test4();
            obj.Test5();
            Console.ReadLine();
        }
    }
}
