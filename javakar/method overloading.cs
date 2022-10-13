using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace javakar
{
    public class method_overloading
    {
        string[] caco = new string[10];
        string[] caco2 = new string[10];
        public void Cars()
        {

            string[] cars = new string[] { "tata", "kia" };
            {
                int q = 0;
                foreach (string d in cars)
                {
                    if (d == "tata")
                    {
                        string h = "Tata";
                        caco[q] = h;
                        q++;
                        Console.WriteLine(h);

                    }
                    else if (d == "kia")
                    {
                        string j = "Kia";
                        caco[q] = j;
                        q++;
                        Console.WriteLine(j);
                    }
                    else if (d == "hundai")
                    {
                        string k = "Hundai";
                        caco[q] = k;
                        q++;
                    }
                }

            }
        }
        public void colors()
        {
            string[] colors = new string[] { "white", "Orange", "black" };

            int e = 0;
            foreach (string b in colors)

            {
                if (b == "orange")
                {
                    string g = "Orange";
                    caco2[e] = g;
                    e++;
                    Console.WriteLine(g);
                }
                else if (b == "black")
                {
                    string s = "Black";
                    caco2[e] = s;
                    e++;
                }
                else if (b == "white")
                {
                    string r = "White";
                    caco2[e] = r;
                    e++;
                }
                else
                {
                    string t = "NO INPUT";
                    caco2[e] = t;
                    e++;
                    Console.WriteLine(t);
                }




            }


        }

    }
}




