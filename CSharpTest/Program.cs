using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpTest
{
    class Program
    {
        [DllImport("DllTest")]
        public static extern int add(int a, int b);

        [DllImport("DllTest")]
        public static extern bool is_expired(string bundleName, string appKey, string appSecret);

        static void Main(string[] args)
        {
            Console.WriteLine(add(10, 20));

            Console.WriteLine(is_expired("hello", "hello", null));

            Console.WriteLine(is_expired("world", null, "world"));

            Console.WriteLine(is_expired("helloworld", "hello", "world"));

            Console.ReadKey();
        }
    }
}
