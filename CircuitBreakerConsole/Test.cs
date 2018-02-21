
using BaseCircuitBreaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitBreakerConsole
{
  public  class Test
    {
        private static readonly CircuitBreaker mycircuitBreaker = new CircuitBreaker(3, TimeSpan.FromMinutes(15));

        public string TestCirciutBreaker()
        {
            if (mycircuitBreaker.AttemptCall(() => { DoSomething(); }).IsClosed)
            {
                return "Called code";
            }
            else
                return "Too many failures ,Resource not available";
        }

        public void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Doing something");
                throw new NotImplementedException();
            }
        }


    }
}
