using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace javakar
{
    public class Working
    {
        public int k ;
        public void Inher()

        {
            int a = 10;
            int b = 10;
            k = a + b;
            Console.WriteLine(k);
        }
    }
    public class Working2 : Working
    {
        public int m; 
      public void display()
        {
            Console.WriteLine("Enter the number1");
            int c = Convert.ToInt32(Console.ReadLine());
             m = c + k;
            Console.WriteLine(m);
            
        }


    }
    public class Working3 : Working
    {
        public void ram()
        {
            Console.WriteLine("Enter the number2");
            int s=Convert.ToInt32(Console.ReadLine());
            int j = s + k;
            Console.WriteLine($"Number{j}");   
        }
    }

}
