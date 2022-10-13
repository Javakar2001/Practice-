using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace javakar
{
    internal class binary_to_decimal
    {
        public void Binary()
        {
            Console.WriteLine("Binary=");
            string input = Console.ReadLine();
            int X = Convert.ToInt32(input, 2);
            Console.WriteLine("{0}", X);
            Console.ReadLine();
        }
    }
}
   
