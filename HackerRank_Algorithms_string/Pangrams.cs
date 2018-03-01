using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HackerRank_Algorithms_string
{
    class Pangrams
    {

        static string pangrams(string s)
        {
            //second solution
            //bool[] matches = new bool[26];
            //s = s.ToLower();
            //for(int i = 0; i < s.Length; i++)
            //    if((int)s[i]>=97&& (int)s[i]<=122)
            //        matches[(int)s[i]-97] = true;

            //foreach(bool b in matches)
            //    if(b==false)
            //        return "not pangram";

            //return "pangram";

            //with hashset->eliminates duplicate strings
            //return new HashSet<char>(s.ToLower().Replace(" ","")).Count==26? "pangram" : "not pangram";


            //with linq
            return s.ToLower().Replace(" ","").Select(x=>x).Distinct().Count()== 26 ? "pangram" : "not pangram";

            //first solution
            //String match = "abcdefghijklmnopqrstuvwxyz";
            //foreach(char c in match.ToLower())
            //{
            //    if (!s.ToLower().Contains(c))
            //        return "not pangram";
            //}

            //return "pangram";
        }
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            string s = "We promptly judged antique ivory buckles for the next prize";
            Console.WriteLine(pangrams(s));
            Console.ReadLine();
        }
    }
}
