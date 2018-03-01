using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms_string
{
    class WeightedUniformStrings
    {
        //to slow solution
        //public static void uniformWeight(string s,int[] x,int n)
        //{
        //    int count = 0;
        //    string[] result = new string[n];
        //    int _n = s.ToCharArray().Length;
        //    for (int i = 0; i < _n; i++)
        //    {
        //        if (i > 0 && s[i] == s[i - 1])
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            int _x = 0;
        //            while (count > 0)
        //            {
        //                _x += (int)s[i - 1]-96;
        //                if (x.Contains(_x))
        //                    result[Array.FindIndex(x,y=>y==_x)] = "YES";

        //                count--;
        //            }

        //            if (i == _n - 1)
        //            {
        //                _x = (int)s[i] - 96;
        //                if (x.Contains(_x))
        //                    result[Array.FindIndex(x, y => y == _x)] = "YES";
        //            }


        //            count++;
        //        }
        //    }

        //    for (int i = 0; i < result.Length; i++)
        //        if (result[i] == "YES")
        //            Console.WriteLine("Yes");
        //        else
        //        {
        //            Console.WriteLine("No");
        //        }
        //}
        public static string uniformWeight(string s, int[] x, int n)
        {

            return string.Empty;
        }


        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            int n1 = s.Length;
            int n = Convert.ToInt32(Console.ReadLine());
            //very clever
            bool[] array = new bool[10 * 1000 * 1000];//s.Select(x => (int)x-96).ToArray();
            int tempRes = 0;

            for (int i = 0; i < n1; i++)
            {
                if (i > 0 && s[i] == s[i - 1])
                    tempRes++;
                else
                    tempRes = 1;

                array[((int)s[i] - 96) * tempRes] = true;
            }

            string[] result = new string[n];
            for (int a0 = 0; a0 < n; a0++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                result[a0] = array[x] ? "Yes" : "No";
            }

            foreach (string s1 in result)
                Console.WriteLine(s1);


        }
    }
}
