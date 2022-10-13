using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace javakar
{
    internal class Roughwork
    {

        public void Math1()
        {
   
            string mum = "RqaEzty";
            List<string> list = new List<string>();
            List<string> ans1 = new List<string>();
            foreach (char c in mum)
            {
                string str=c.ToString();
                list.Add(str);
            }
            for(int i = 0; i < list.Count; i++)
            {
                if(i > 0)
                {
                    ans1.Add("-");
                }
                int loop=i+1;
                string str1=list[i];
                string check = "";
                for(int j = 0; j < loop; j++)
                {
                    if (j == 0)
                    {
                        string n = str1.ToString().ToUpper();
                        check = n;
                        ans1.Add(n);
                    }
                    else if(str1 == check)
                    {
                        ans1.Add(str1.ToString().ToLower());
                    }
                    else
                    {
                        ans1.Add(str1);
                    }
                }
                check = "";
            }
            string str2 = "";
            for(int k = 0; k < ans1.Count; k++)
            {
                str2 += ans1[k];
            }
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}

