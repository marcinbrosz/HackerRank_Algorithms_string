using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRank_Algorithms_string
{
    class CamelCase
    {
        static int CamelCase1(string s)
        {

            //with linq
            //return s.Select((x, i) => i>0 & x.ToString() == x.ToString().ToUpper() ? 1 : 0)
            //        .Sum()+1;


            //with Regex
            return s.Length - Regex.Replace(s, @"[A-Z]", "").Length + 1;
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            Console.Write(CamelCase1(s));
        }
    }
}
