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
                if(init == "2.4")
                {
                    Q.Q2_4();
                }
                if (init == "2.6")
                {
                    Q.Q2_6();
                }
                if(init == "2.7")
                {
                    Q.Q2_7();
                }
                if (init == "2.10")
                {
                    Q.Q2_10();
                }
                if(init == "2.13")
                {
                    Q.Q2_13();
                }
                if(init == "2.14")
                {
                    Q.Q2_14();
                }
                if(init == "2.17")
                {
                    Q.Q2_17();
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

        static string key;
        static public void Q1_2()
        {
            
            string[] arr = new string[10];
            int flag = 0;
            arr[0] = "1";
            flag++;
            arr[1] = "3";
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
                        arr[flag] = Console.ReadLine();
                        flag++;
                    }
                    if (r == "D")
                    {
                        arr[flag] = " ";
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
                                arr[clist] = Console.ReadLine();
                                break;
                            }
                        }
                        

                    }
                    if (r == "H")
                    {
                        while(true)
                        {
                            Console.WriteLine("Which do you want check ?          number or ALL\nGo back ?               Y/N");
                            string w = Console.ReadLine();
                            if (w == "Y")
                            {
                                break;
                            }
                            else if (w == "ALL")
                            {
                                foreach (string n in arr)
                                {
                                    Console.WriteLine(n);
                                }
                            }
                            else 
                            {
                                
                                key = w;
                                int x = Array.FindIndex(arr,Find);
                                if (x != -1)
                                    Console.WriteLine(key + "  数据存在！\n");
                                else
                                    Console.WriteLine(key + "   数据不存在！\n");
                            }
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

        static bool Find(string data)
        {
            if (data == key)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        static public void Q2_4()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            DateTime dy = new DateTime(dt.Year, 1, 1);
            Console.WriteLine((dt - dy).Days);
            Console.Write("\n");
        }
        static public void Q2_6()
        {
            int[] arr = new int[] { 12, 45, 23, 67, 45, 40, 89 };
            int q;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        q = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = q;
                    }
                }
            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }
        static public void Q2_7()
        {
            int[] arr = new int[] { 12, 45, 23, 67, 45, 40, 89 };
            Array.Sort(arr);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");

        }
        static public void Q2_10()
        {
            string a = "absent";
            char[] b = a.ToCharArray();
            Array.Sort(b);
            foreach (char item in b)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");

        }

        static public void Q2_13()
        {
            string[] a = { "absent", "student", "absolute", "solve" };
            string[] b = a.ToArray();
            Array.Sort(b);
            foreach (string item in b)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }
        static public void Q2_14()
        {
            object[] a = { 12, 45, 23, 67, 45, 40, 89 };
            Array.Sort(a);
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }
        static public void Q2_17()
        {
            string p = Console.ReadLine();
            if(p == "z")
            {
                Console.Write("Please type :");
                string word = Console.ReadLine() + " ";
                Regex rx = new Regex("(?<word>\\p{L}+)[,|，|\\s|.|。]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                MatchCollection matches = rx.Matches(word);
                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    Console.WriteLine(groups["word"].Value);
                }
            }
            else
            {
                par(' ',',','.');

            }
        }
        static public void par(params char[] s1)
        {
            string word = Console.ReadLine() + " ";
            string[] s2 = word.Split(s1);
            foreach (string item in s2)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }
    }
}
