using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace javakar
{
    public class Data
    {
        public void Snake(out int value)
        {
            value = 10;
            Console.WriteLine(value);
        }
        public void StreamWriterMethod()
        {
            FileStream f = new FileStream($"D:\\output.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("hello");
            for (int i = 0; i < 10; i++)
            {
                s.WriteLine("hello");

            }
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully...");
        }
    }
}
