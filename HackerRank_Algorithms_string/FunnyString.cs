using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms_string
{
    class FunnyString
    {
        static string funnyString(string s)
        {
            int[] s1 = s.Select(x=>(int)x).ToArray();
            int n = s1.Length;
            for(int i = 0,j=n-1; i < n-1; i++,j--)
            {
                if (Math.Abs(s1[i + 1] - s1[i]) != Math.Abs(s1[j - 1] - s1[j]))
                    return "Not Funny";
            }
            return "Funny";
        }

        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                string result = funnyString(s);
                Console.WriteLine(result);
            }
        }
    }
}
