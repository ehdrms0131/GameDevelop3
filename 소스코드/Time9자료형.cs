using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game10_15
{
    class Time9자료형
    {
        private static void Main()
        {
            //부호 x byte o sbyte
            //실수 decimal 16바이트 뒤에 m
            string s = "적을수있음";
            float f = 1.234f;
            double d = 1.234;//d선택
            object o = "만능자료형";
            //형변환 형식은 같음

            float fNum = 3.14f;
            string str = fNum.ToString();
            Console.WriteLine(str);
        }
    }
}
