using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms_string
{
    class CaesarCipher
    {
        static string CaesarCipher(string unencrypted, int cipher)
        {

            //very short
            //string res = string.Empty;
            //foreach (char c in unencrypted)
            //{
            //    if (char.IsLetter(c))
            //    {
            //        char a = char.IsUpper(c) ? 'A' : 'a';
            //        res += (char)(a + ((c - a + cipher) % 26));
            //    }
            //    else
            //        res += c;
            //}



            List<char> result = new List<char>();
            int count = 'z' - 'a';
            //adder 
            void AdderCaesarCipher(char x, char lastChar)
            {
                if (cipher > count)
                {

                    double divCipher = (double)cipher / count;
                    if (divCipher > 1.0)
                    {
                        int cipher_temp = (int)(count * Math.Round(divCipher - (int)divCipher, 2)) - (int)divCipher;

                        result.Add(
                            char.IsLetter((char)(x + cipher_temp)) && (char)(x + cipher_temp) <= lastChar
                                ? (char)(x + cipher_temp) : (char)('a' + (x + cipher_temp) - 'z' - 1));

                    }
                }
                else
                {
                    result.Add(
                        char.IsLetter((char)(x + cipher)) && (char)(x + cipher) <= lastChar
                            ? (char)(x + cipher) : (char)('a' + (x + cipher) - 'z' - 1));
                }


            }
            foreach (char x in unencrypted)
            {
                if (char.IsLetter(x) && char.IsLower(x))
                {
                    AdderCaesarCipher(x, 'z');
                }
                else if (char.IsLetter(x) && char.IsUpper(x))
                {
                    AdderCaesarCipher(x, 'Z');
                }
                else
                {
                    result.Add(x);
                }
            }

            return string.Concat(result.Select(x => x));
        }


        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CaesarCipher(s, k));
        }
    }
}
