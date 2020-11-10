using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game10_15.생성자종료자
{
    class Sample
    {
        public int A;
        public int B;
        public int C;
        public Sample(int A)
        {
            this.A = A;//this 구분
            Console.WriteLine("A = " + this.A);
        }
        public Sample(int A,int B):this(A)//this (B)를 해도 달라지는건 없음,그러나 10을 넣으면 A에 10이 들어감
        {
            this.B = B;
            Console.WriteLine("B = " + this.B);
        }
        public Sample(int A,int B,int C):this(A,B)
        {
            this.C = C;
            Console.WriteLine("C = " + this.C);
        }
    }
    class this생성자
    {
        public static void Main()
        {
            new this생성자().Entry();
        }
        public void Entry()
        {
            Sample sample = new Sample(1, 2, 3);
        }
    }
}
