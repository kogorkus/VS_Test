using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    delegate void Del();
    class Program
    {


        static void Main(string[] args)
        {
            Del MyDel = DoSmth;
            MyDel += DoSmthElse;
            MyDel();
        }
        public static void DoSmth()
        {
            Console.WriteLine("Smth`s done!");
        }
        public static void DoSmthElse()
        {
            Console.WriteLine("Smth else is done too!");
        }
    }

}

