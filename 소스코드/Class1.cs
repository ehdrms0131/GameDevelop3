using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    partial class Class1
    {
        private string Name { get; set; }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

    partial class Class1
    {
        public void Print2()
        {
            Console.WriteLine("싸발");
        }
    }

    class mainClass
    {
        public static void Main()
        {

        }
    }
}
