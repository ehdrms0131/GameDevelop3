using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game10_15.상수와_열거형
{
    class Time10상수와열거형
    {
        enum Button : sbyte
        {
            //열거
            yes = 10,
            no = 20,
            ok = 30,
            cancel = 40
        }

        private static void Main()
        {
            //상수는 변하지 않는 값
            const float pi = 3.14f;
            //pi = 1.1f;
            // 열거형
            // enum
            // 한속성에대해 열거하는것
        }
    }
}
