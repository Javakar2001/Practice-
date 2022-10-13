using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace javakar
{
    public class addition
    {
        public void Run()
        {
            Console.WriteLine("input 1=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input 2=");
            int b = Convert.ToInt32(Console.ReadLine());
            int d = a + b;
            Console.WriteLine(d);
        }


        public void kar()
        {
            Console.WriteLine("input");
            string a = Convert.ToString(Console.ReadLine());
            int k = a.Length;
            int s = k / 2;
            int o = s;
            Console.WriteLine($"{DateTime.Now}: " + o);
            Console.ReadLine();
        }

    }
}

