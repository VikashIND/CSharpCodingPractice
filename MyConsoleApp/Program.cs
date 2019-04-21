using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatorOverloading obj = new OperatorOverloading();

            OperatorOverloading obj1 = new OperatorOverloading();
            obj1.Num1 = 10;
          obj1.Str1 = "Vikash ";
            OperatorOverloading obj2 = new OperatorOverloading();
            obj2.Num1 = 10;
            obj2.Str1 = "Kumar";

            obj = obj1 + obj2;
            Console.WriteLine($"Numer:{obj.Num1}, String:{obj.Str1}");
            Console.Read();
        }
    }


    public class B : A
    {
        public B()
        {
            Console.WriteLine("B Default Constructor");
        }
        public B(string input) : base(input)
        {
            Console.WriteLine("Cass B Called " + input);
        }
        public override void Print()
        {
            Console.WriteLine("Clas B Print() called");
        }
    }
}
