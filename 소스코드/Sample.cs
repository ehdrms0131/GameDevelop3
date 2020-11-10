using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game10_15.생성자종료자
{
    class Sample
    {
        public Sample()
        {
            Console.WriteLine("Sample Called");
        }
        ~Sample()
        {
            Console.WriteLine("Sample Deleted");
        }
        public static void Main()
        {

        }
    }
}
