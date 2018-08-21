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
                Message welcome = new Message(new RealDateTime());
                Console.WriteLine(welcome.getHelloMessage());
            }
            while (Console.ReadLine() != "exit");
        }

    }
}
