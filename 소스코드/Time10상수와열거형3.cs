using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game10_15.상수와_열거형
{
    class Time10상수와열거형3
    {
       private static void Main()
        {
            //null 비어있음
            //nullable 변수가 실제로 메모리가 존재하는지 검사
            int? num = 10;//num의 주소가 있더라도 값이 없을수 있기때문
            int? n2 = null;
            Console.WriteLine(num.HasValue);
            Console.WriteLine(n2.HasValue);
        }
    }
}
