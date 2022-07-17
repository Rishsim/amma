using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Sample
    {
        static void Main(string[] args)
        {
            Demo s = new Demo();

            s.z1(10,"ramya",20);
            s.z1(5);

        }
    }
}
