using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game10_15.상수와_열거형
{
    class Time10상수와열거형2
    {
        enum Gender :sbyte
        {
            Man=10,Woman=20
        }
        private static void Main()
        {
            Gender man = Gender.Man;
            Gender woman = Gender.Woman;
            Console.WriteLine(man == Gender.Man ? "Man" : "Woman");
            Console.WriteLine((int)woman);
        }
    }
}
