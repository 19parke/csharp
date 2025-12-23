using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    /*
    struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return string.Format($"{X}, {Y}, {Z}");
        }
    }
    */

    /*
    readonly struct RGBColor
    {
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;

        public RGBColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }
    */

    /*
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;

        
        // readonly에 빨간줄
        public readonly double GetFahrenheit()
        {
            // target 에 빨간줄 , '읽기 전용엔 target을 할당 할 수 없습니다'
            target = currentInCelsius * 1.8 + 32;
            return target;
        }
        
    }
    */

    class MainApp
    {
        static void Main(string[] args)
        {
            /*
            // 선언만으로 인스턴스 생성
            Point3D p3d1;
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Console.WriteLine(p3d1.ToString());

            // 생성자를 이용한 인스턴스 생성도 가능
            Point3D p3d2 = new Point3D(100, 200, 300);
            Point3D p3d3 = p3d2;
            p3d3.Z = 400;

            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());
            */

            /*
            RGBColor Red = new RGBColor(255, 0, 0);
            // 컴파일 에러
            //Red.G = 100;
            */

            // 튜플 Tuple

            // 명명되지 않은 튜플
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            // 명명된 튜플 
            var b = (Name: "박은혜", Age: 26);
            Console.WriteLine($"{b.Name}, {b.Age}");

            // 분해 
            var (name, age) = b;
            Console.WriteLine($"{name}, {age}");

            // 분해 2
            var (name2, age2) = ("박은혁", 22);
            Console.WriteLine($"{name2}, {age2}");

            // 명명된 튜플 = 명명되지 않은 튜플
            b = a;
            Console.WriteLine($"{b.Name}, {b.Age}");

            Console.ReadKey();
        }
    }
}