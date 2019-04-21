using System;

namespace MyConsoleApp
{
    public abstract class A
    {
        public A()
        {
            Console.WriteLine("A Default Constuctor");
        }
        public A(string input)
        {
            Console.WriteLine("Class A Called " + input);
        }

        public abstract void Print();
        //{
            //Console.WriteLine("Clas A Print() called");
        //}
    }
}
