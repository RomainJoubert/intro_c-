using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Message welcome = new Message(9, 13, 18);
                Console.WriteLine(welcome.getHelloMessage(DateTime.Now));
            }
            while (Console.ReadLine() != "exit");
        }

    }
}
