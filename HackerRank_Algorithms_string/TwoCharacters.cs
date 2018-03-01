using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HackerRank_Algorithms_string
{
    class TwoCharacters
    {


        //sprawdza czy string ma taka forme yxyxy 
        static int super_reduced(string s)
        {
            string result = s;
            for (int i = 0; i < result.Length; i++)
            {
                if ((i + 1) < result.Length)
                    if (result[i] == result[i + 1])
                        return 0;
            }

            return s.Length;
        }
        public static readonly int NUM_LETTERS = 26;
        static int TwoCharacters_ver2(string s)
        {
            int length = s.Length;
            int[,] pair = new int[NUM_LETTERS, NUM_LETTERS];
            int[,] count = new int[NUM_LETTERS, NUM_LETTERS];

            for (int i = 0; i < length; i++)
            {
                char letter = s[i];
                int letterNum = letter - 'a';

                /* Update row */
                for (int col = 0; col < NUM_LETTERS; col++)
                {
                    if (pair[letterNum, col] == letter)
                    {
                        count[letterNum, col] = -1;
                    }
                    if (count[letterNum, col] != -1)
                    {
                        pair[letterNum, col] = letter;
                        count[letterNum, col]++;
                    }
                }

                /* Update column */
                for (int row = 0; row < NUM_LETTERS; row++)
                {
                    if (pair[row, letterNum] == letter)
                    {
                        count[row, letterNum] = -1;
                    }
                    if (count[row, letterNum] != -1)
                    {
                        pair[row, letterNum] = letter;
                        count[row, letterNum]++;
                    }
                }
            }

            /* Find max in "count" array */
            int max = 0;
            for (int row = 0; row < NUM_LETTERS; row++)
            {
                for (int col = 0; col < NUM_LETTERS; col++)
                {
                    max = Math.Max(max, count[row, col]);

                }
            }

            return max;
        }
        static int TwoCharacters1(string s)
        {
            int countLetter = 0;
            int deletedLetter = 0;
            List<char> diffLetter = new List<char>();
            int result = 0;
            foreach (char c in s)
            {
                if (!diffLetter.Any() || !diffLetter.Contains(c))
                    diffLetter.Add(c);
            }
            countLetter = diffLetter.Count();
            if (countLetter > 2)
                deletedLetter = countLetter == 2 ? countLetter : countLetter - 2;
            else
                return countLetter < 2 ? 0 : 2;
            string temp = string.Empty;


            for (int j = 0; j < countLetter; j++)
            {

                //int y = 0;
                char temp_char = diffLetter[j];
                //temp = Regex.Replace(temp, temp_char.ToString(), "");
                for (int i = 0; i < diffLetter.Count; i++)
                {
                    temp = s;
                    temp = Regex.Replace(temp, temp_char.ToString(), "");
                    //int y_temp = y;
                    if (i != j & i > j & i < diffLetter.Count)
                    {
                        for (int x = 0; x < deletedLetter - 1; x++)
                        {
                            if (i < diffLetter.Count)
                            {
                                temp = Regex.Replace(temp, diffLetter[i].ToString(), "");

                                if (deletedLetter - 1 > 1)
                                    i++;
                            }



                        }
                        if (deletedLetter - 1 > 1)
                            i -= 2;

                        int t = super_reduced(temp);
                        result = t > result ? t : result;


                    }

                }
            }


            return result;
        }

        static void Main(String[] args)
        {
            int len = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            Console.WriteLine(s.Length < 2 ? "0" : TwoCharacters_ver2(s).ToString());
        }
    }
}
