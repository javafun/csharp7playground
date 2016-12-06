using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pair1 = (42, "hello");
            Console.Write(Method(pair1).message);

            var pair2 = (code: 43, message: "world");
            Console.Write(pair2.message);
        }

        public static (int code, string message) Method((int, string) x)
        {
            return x;
        }

    }
}
