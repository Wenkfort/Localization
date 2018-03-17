using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static List<String> world = new List<string> {"green", "red", "red", "green", "green" };
        static double pHit = 0.6;
        static double pMiss = 0.2;
        static double[] p = new double[] { 0.2, 0.2, 0.2, 0.2, 0.2 };

        static void Main(string[] args)
        {
            //String Z = "red";
            //double[] res = sense(p, Z);
            //foreach (double d in res) Console.WriteLine(d);
            string[] meaurements = new string[] { "green", "red"};
            foreach (string Z in meaurements)
            {
                p = sense(p, Z);
                foreach (double i in p) Console.Write("{0,4:F2} ", i);
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static double[] sense(double [] p, string Z)
        {
            double[] ans = new double[p.Length];
            for (int i = 0; i < p.Length; i++) ans[i] = p[i] * ((world[i] == Z) ? pHit : pMiss);
            var sum = ans.Sum();
            for (int i = 0; i < p.Length; i++) ans[i] /= sum;

            return ans;
        }
    }
}
