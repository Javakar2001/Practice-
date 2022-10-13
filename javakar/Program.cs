
using System;
using System.IO;
using System.Text;
namespace javakar
{
    internal class Program
    {
        public static void Main(string[] args)
        
        
        {
            Console.WriteLine("main Input");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 2)
            {
                method_overloading y = new method_overloading();
                y.Cars();
                y.colors();
            }
            else if (x == 1)
            {
                brand h = new brand(18, "java");
                brand h1 = new brand(h);
                h.Display();
            }
            else if (x == 3)
            {

                Working2 cs = new Working2();
                Working3 cs1 = new Working3();
                cs.Inher();
                cs.display();
                cs1.ram();

            }
            else if (x == 4)
            {
                array Rets = new array();
                //Rets.str1();
                //Rets.array();
                Rets.decode();
            }
            else if (x == 5)
            {
                Codewars d = new Codewars();
                d.Duplicate();
                d.Multiindex();
                d.Sqroot();
                d.Yesno();
                d.Ascendingodd();
                d.Ascendingdecending();
                d.Phonenumber();
                d.Mul();
                d.Intdec();

            }
            else if (x == 0)
            {
                Roughwork r = new Roughwork();
                r.Math1();
            }
            else
            {
                square_root k = new square_root();
                k.run(2, 3);
                k.run(2, 3, 4);
                Data data = new Data();
                data.Snake(out int value);
                data.StreamWriterMethod();

            }
        }
    }
      
}
