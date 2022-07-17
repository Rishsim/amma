using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Demo
    {
        public void z1()
        {
            Console.WriteLine("this is my first method z1" );
        }
        public void z1(int i)
        {
            Console.WriteLine("this is my second method z1");
            Console.WriteLine("this is intvalue"+ i);
        }
        public void z1(string j)
        {
            Console.WriteLine("this is my third method z1");
        }

        public void z1(int i,string j,int k)
        {
            Console.WriteLine("this is my fourth method z1");
        }
        


    }
}
