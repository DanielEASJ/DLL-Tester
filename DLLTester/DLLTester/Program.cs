using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewMyMathDll;

namespace DLLTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathy m = new Mathy();
            Console.WriteLine(m.Add(2,4));
            Console.WriteLine(m.Add2(10,100,1000));


            Console.ReadLine();
        }
    }
}
