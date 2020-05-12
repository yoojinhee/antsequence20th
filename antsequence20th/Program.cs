using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "1";//12
            String re;
            char head;
            for (int i=0; i<20; i++)
            {
                head = s[0];//1
                int cnt = 1;
                re = "";
                for(int j=1; j<s.Length; j++)//2
                {
                    if (s[j].Equals(head))//
                    {
                        cnt++;//1
                    }
                    else
                    {
                        re += head;
                        re += cnt;
                        cnt = 1;
                        head = s[j];
                    }
                }
                re += head;//1
                re += cnt;//1
                s = re;
                Console.WriteLine(s);
            }
        }
    }
}
