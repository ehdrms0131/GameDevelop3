using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game10_15.참조에의한_매개변수_전달
{
    class 참조복사
    {
        static void AddValue(ref int value,int number)//값복사
        {
            value += number;
        }
        static void Main()
        {
            //참조복사
            //call by Reference:참조에 의한 호출
            //pass by Reference:참조에 의한 전달
            int num = 10;
            AddValue(ref num, 10);//변하지않음
            Console.WriteLine(num);
            //ref->c#
            //c->pointer
            //컴파일 하면 20
        }
    }
}
