using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HackerRank_Algorithms_string
{
    class Program
    {
        static string word = "hackerrank";

        static string hackerrankInString(string s)
        {
            if (s.Length < word.Length)
                return "NO";

            //wuth regex
            //return Regex.IsMatch(s, @"h.*a.*c.*k.*e.*r.*r.*a.*n.*k.*")?"YES":"NO";



            //with for solution 1
            //for (int i=0;i<word.Length;i++)
            //    if (s.Contains(word[i]))
            //    {
            //        int n = s.IndexOf(word[i]);
            //        s = string.Join( "",s.Skip(n+1));

            //    }
            //    else
            //        return "NO";


            //return "YES";


            //with for solution 2
            int j = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == word[j])
                {
                    j++;
                    if (j == word.Length)
                        break;
                }

            }


            return j==word.Length?"YES":"NO";
        }

        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                string result = hackerrankInString(s);
                Console.WriteLine(result);
            }
        }
    }
}
