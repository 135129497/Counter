using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            char cha;
            s1 = Convert.ToString(Console.ReadLine());
            s2 = Convert.ToString(Console.ReadLine());
            cha = Convert.ToChar(Console.ReadLine());
            Counter c1 = new Counter();
            c1.Count(s1,s2,cha);
        }
    }
}
