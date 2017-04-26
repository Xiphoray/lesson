using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace lesson
{
    class Program
    {

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("type your question:");
                string init = Console.ReadLine();
                if(init == "1.1")
                {
                    Q.Q1_1();
                }
                if(init == "1.2")
                {
                    Q.Q1_2();
                }
                
                Console.WriteLine("Do you want to leave?        Y/N");
                string b = Console.ReadLine();
                if (b == "Y")
                {
                    break;
                }
            }
        }

        
    }
    class Q
    {
        static public void Q1_1()
        {
            while(true)
            {
                Console.WriteLine("type your numbers :");
                string dataStr = Console.ReadLine() + " ";
                double Sum = 0;
                Regex rx = new Regex("(?<num>\\d+)[；|;|\\s]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                MatchCollection matches = rx.Matches(dataStr);
                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    Console.WriteLine("{0}", groups["num"].Value);
                    string a = groups["num"].Value;
                    double z = Convert.ToDouble(a);
                    Sum += Math.Sqrt(z);
                }
                Console.WriteLine(Sum+"\n");

                Console.WriteLine("Do you want to leave Q1.1 ?          Y/N");
                string b = Console.ReadLine();
                if (b == "Y")
                {
                    break;
                }
            }
            
        }
        static public void Q1_2()
        {
            int[] arr = new int[10];
            int flag = 0;
            arr[0] = 1;
            flag++;
            arr[1] = 3;
            flag++;
            while(true)
            {
                while(true)
                {

                    Console.WriteLine("Add ?          A\nDelete ?          D\nChange ?          C\nCheck ?          H\nGo back ?          Y/N");
                    string r = Console.ReadLine();
                    if (r == "Y")
                    {
                        break;
                    }

                    if (r == "A")
                    {
                        Console.WriteLine("Type your number :");
                        int newnum = Convert.ToInt16(Console.ReadLine());
                        arr[flag] = newnum;
                        flag++;
                    }
                    if (r == "D")
                    {
                        arr[flag] = 0;
                        flag--;
                    }
                    if (r == "C")
                    {
                        while(true)
                        {
                            Console.WriteLine("Which do you want to change ?");
                            int clist = Convert.ToInt16(Console.ReadLine());
                            if(clist >= flag)
                            {
                                Console.WriteLine("There is no number");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("What do you want to change to ?");
                                int cnum = Convert.ToInt16(Console.ReadLine());
                                arr[clist] = cnum;
                                break;
                            }
                        }
                        

                    }
                    if (r == "H")
                    {
                        foreach (int n in arr)
                        {
                            Console.WriteLine(n);
                        }
                    }
                }


                Console.WriteLine("Do you want to leave Q1.2 ?          Y/N");
                string b = Console.ReadLine();
                if (b == "Y")
                {
                    break;
                }
            }



        }

    }
}
