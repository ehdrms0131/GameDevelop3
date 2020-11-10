using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game10_15.참조에의한_매개변수_전달
{
    class 참조복사2ref
    {
        static ref int GetRefData(ref int r_value)
        {
            return ref r_value;//반환 타입 (레퍼런스 인트)리턴값:레퍼런스밸류(주소값 반환)
            //가리킴보다는 공유,참조
        }
        static void Main()
        {
            //로컬함수:main안에 함수 더 있는것 마찬가지로 일회성 강함
            //람다함수:일회성이 강함
            int a = 10;
            int b = GetRefData(ref a);
            Console.WriteLine(b);
            //레퍼런스
            Console.WriteLine(a);
            if (a == b)
            {
                Console.WriteLine("같음");
            }
            else
            {
                Console.WriteLine("같음");
            }
        }
    }
}