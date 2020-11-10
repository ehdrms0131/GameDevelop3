using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game10_15.AirConitioner
{
    class OnAndOff
    {
        public void OnCheck(bool on)
        {
            if (on == true)
            {
                Console.WriteLine("전원 on");
            }
            else
            {
                Console.WriteLine("전원 off");
            }
        }
    }
    class Temperature
    {
        int t = 20;
        public int Get()
        {
            return t;
        }
        public void Set(int t)
        {
            this.t = t;
        }
        public void print()
        {
            Console.WriteLine("현재 온도는 " + t + "도 입니다");
        }
        public void Up(int u)
        {
            t = t + u;
        }
        public void Down(int d)
        {
            t = t - d;
        }
    }
class AirConditioner
    {
        public static void Main()
        {
            Console.WriteLine("기본온도는 20도입니다.");
            OnAndOff o = new OnAndOff();
            Temperature t = new Temperature();
            o.OnCheck(true);

            t.Up(10);
            t.print();

            t.Down(5);
            t.print();

            o.OnCheck(false);
            //캡슐화
            //접근제한자 인터널 internal
            //종료자(종결자) ~클래스이름
            
            //3대특성
            //은닉성
            //다형성-ex)override
            //상속성
        }
    }
}
