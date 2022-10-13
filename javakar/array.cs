using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace javakar
{
    internal class array
    {
        public void decode()
        {
            string[] nam = new string[] { "Javakar" };
            foreach (string s in nam)
            {
                foreach (char s2 in Convert.ToString(s))
                {
                    char x = s2;
                    Console.WriteLine(x);
                }
            }



        }
    }
}