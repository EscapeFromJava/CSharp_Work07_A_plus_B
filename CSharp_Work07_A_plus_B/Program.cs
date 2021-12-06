using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_Work07_A_plus_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"INPUT.txt";
            string s = File.ReadAllText(input);
            string[] ss = s.Split(' ');
            int x1 = Convert.ToInt32(ss[0]);
            int x2 = Convert.ToInt32(ss[1]);
            s = (x1 + x2).ToString();
            string output = @"OUTPUT.txt";
            File.WriteAllText(output, s);
        }
    }
}
