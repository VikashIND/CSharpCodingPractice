using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyConsoleApp
{
    public class OperatorOverloading
    {
        public int Num1 { get; set; }
        public string Str1 { get; set; }

        public static OperatorOverloading operator +(OperatorOverloading obj1, OperatorOverloading obj2)
        {

            OperatorOverloading obj = new OperatorOverloading();
            obj.Num1 = obj1.Num1 + obj2.Num1;
            obj.Str1 = obj1.Str1 + obj2.Str1;
            return obj;
        }
    }
}
