using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitBreakerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Test objTest = new Test();
           Console.WriteLine( objTest.TestCirciutBreaker());
           Console.WriteLine(objTest.TestCirciutBreaker());
           Console.WriteLine(objTest.TestCirciutBreaker());

            Console.ReadLine();
        }
    }
}
