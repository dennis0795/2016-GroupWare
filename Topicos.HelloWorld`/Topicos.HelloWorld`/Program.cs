using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.HelloWorld_
{
    class Program
    {
         static string GenerateHelloWorld(string userName)
        {
            string result;
            result = "Hello World " + userName;
            return (result);

        }
        static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("Write the name of the user: ");
            userName = Console.ReadLine();
            Console.WriteLine(GenerateHelloWorld(userName));
            Console.ReadLine();
        
        }
    }
}
