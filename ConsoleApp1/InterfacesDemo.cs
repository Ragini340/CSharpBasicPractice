using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IEmployee
    {
        void Create();
    }
    interface ICustomer
    {
        void Create();

    }
    class EmployeeCustomer : IEmployee, ICustomer
    {
        #region Explicit Implementation 
        void ICustomer.Create()  
        {
            Console.WriteLine("Customer is created");
        }
        void IEmployee.Create()
        {
            Console.WriteLine("Employee is created");
        }
        #endregion
        public void create()
        {
            Console.WriteLine("Customer and Employee are created");
        }
    }
    interface ISimpleInterface
    {
        void SimpleFunction();
    }
    interface IExampleInterface
    {
        void ExampleFunction();
    }
    class SimpleExampleClass : ISimpleInterface, IExampleInterface
    {
        public void ExampleFunction() => Console.WriteLine("Example Function implemented as an Example");
        public void SimpleFunction()=>Console.WriteLine("Simple Function implemented in a simple manner");
        
    }
    class InterfacesDemo
    {
        static void Main(string[] args)
        {
            ISimpleInterface simple = new SimpleExampleClass();
            simple.SimpleFunction();

            IExampleInterface example = new SimpleExampleClass();
        }

    }
}
