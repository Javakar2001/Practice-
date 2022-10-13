using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace javakar
{
    public class brand
    {
        int age;
        string name;
        public brand(brand b)
        {
            name = b.name;
            age = b.age;
        }
        public brand(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Result :" + age + name);

        }
        
    }

}
