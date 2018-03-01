using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms_string
{
    class SuperReducedString
    {
        static string super_reduced_string(string s)
        {
            string result = s;
            for (int i = 0; i < result.Length; i++)
            {
                if ((i + 1) < result.Length)
                    if (result[i] == result[i + 1])
                    {
                        result = result.Remove(i, 2);
                        i = -1;
                    }

            }

            return string.IsNullOrEmpty(result) ? "Empty String" : result;
        }
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = super_reduced_string(s);
            Console.WriteLine(result);
        }

    }
}
