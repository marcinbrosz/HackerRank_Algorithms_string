using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algorithms_string
{
    class SeparatetheNumbers
    {
        static long separateNumbers(string s)
        {
            //check that first element is 0 and lengths s is less than 2 ("1"-> always NO)
            if (s[0] == '0'||s.Length<2)
                return 0;

            //list where keeps element in sequences
            List<long> temp2 = new List<long>();
            //checker that sequences is correct
            bool check = false;
            //mode: 1 first element is 1 lenght, 
            //      2 first element is 2 lenght e.t.c
            int mode = 0;

            while (true)
            {
                //start mode=1
                mode++;
                //constraint task
                if (mode > 32)
                    return 0;


                long i2 = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    //mode must be smaller that  lenght s=> '123', mode=2 is wrong-> 12,3...
                    if (mode<=s.Length/2)
                    {

                        long a;
                        try
                        {
                                a = Int64.Parse(s.Substring(i, mode));
                        }
                        catch
                        {
                            return 0;
                        }

                        //check that i==0 or last element in list +1( previous value in s) is equal current values   
                        if (temp2.Any()?temp2.Last() + 1 == a:i==0)
                        {
                            check = true;
                            temp2.Add(a);
                            //count when add new elemnt in temp2
                            i2++;
                            //must add mode to i->  mode=3,"100101102" -> first loop a=100, i must be higher
                            i += mode - 1;

                        }//when length next value is higher than mode
                        else if (temp2.Any()?((temp2.Last() + 1).ToString().Length > mode):false)
                        {
                            check = true;

                            long b;

                            try
                            { 
                                b = Int64.Parse(s.Substring(i, (temp2.Last() + 1).ToString().Length));
                            }
                            catch
                            {
                                return 0;
                            }

                            if (temp2.Last() + 1 == b)
                            {
                                temp2.Add(b);
                                i += mode - 1+1;//+1 because mode is now mode+1
                                i2++;
                            }
                            else
                            {
                                temp2.Clear();
                                check = false;
                                break;
                            }
                        }
                        else
                        {
                            temp2.Clear();
                            check = false;
                            break;
                        }
                    }
                    else if(mode > s.Length)
                    {
                        return 0;
                    }

                }

                if(check)
                    return temp2.First();
            }
                
            return 0;
        }

        static void Main(String[] args)
        {
            //separateNumbers("998999100010011002100310041005");
            //long q = Convert.ToInt64(Console.ReadLine());
            //string[] result = new string[q];

            string[] s = {"90071992547409929007199254740993",
"45035996273704964503599627370497",
"22517998136852482251799813685249",
"11258999068426241125899906842625",
"562949953421312562949953421313",
"90071992547409928007199254740993",
"45035996273704963503599627370497",
"22517998136852481251799813685249",
"11258999068426240125899906842625",
"562949953421312462949953421313"};
            for (int a0 = 0; a0 < s.Length; a0++)
            {
                //string s = Console.ReadLine();
                string g = s[a0];
                long res = separateNumbers(s[a0]);
                Console.WriteLine(res>0?"YES"+" "+res:"NO");
            }
            //for (long i = 0;i < q;i++)
            //    Console.WriteLine(result[i]+" "+string[i]);

            Console.ReadLine();

        }
    }
}
