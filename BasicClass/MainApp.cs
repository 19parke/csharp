using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    /*
    class Cat
    {
        //public string Name;
        //public string Color;

        //public void Meow()
        //{
        //    Console.WriteLine($"{Name} : 야옹");
        //}

        //public Cat()
        //{
        //    Name = "";
        //    Color = "";
        //}

        //public Cat(string _Name, string _Color)
        //{
        //    Name = _Name;
        //    Color = _Color;
        //}

        //~Cat()
        //{
        //    Console.WriteLine($"{Name} : 잘가");
        //}

        //public string Name;
        //public string Color;

        //public void Meow()
        //{
        //    Console.WriteLine($"{Name} : 야옹");
        //}
    }
    */

    //인스턴스에 소속된 필드의 경우 

    /*
     
     class MyClass
    {
        public int a;
        public int b;
    }

    public static void Main()
    {
        MyClass obj1 = new MyClass();
        obj1.a = 1;
        obj1.b = 2;

        MyClass obj2 = new MyClass();
        obj2.a = 3;
        obj2.b = 4;
    }
     
     */

    // 클래스에 소속된 필드의 경우 (static)
    /*
     class MyClass
    {
        public static int a;
        public static int b;
    }

    public static void Main()
    {
        인스턴스를 만들지 않고 클래스의 이름을 통해 필드에 직접 접근합니다. 

        MyClass.a = 1;
        MyClass.b = 2;
    } 
     
     */

    // static 으로 수식한 필드는 프로그램 전체에 걸쳐 하나 밖에 존재하지 않음
    // 프로그램 전체에 걸쳐 공유해야 하는 변수가 있다면 정적 필드 이용
    // 정적 메소드 : 인스턴스가 아닌 클래스 자체에 소속 , 정적 메소드가 클래스의 인스턴스를 생성하지 않아도 호출 가능 

    /*
    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }
    */

    // 얕은 복사 , shallow copy : 객체를 복사할 때 참조만 복사하는 것 (주소만 복사하는 것) 
    // 깊은 복사 , deep copy : 별도의 힙 공간에 객체를 보관하기 바라는 곳, 자동으로 해주는 구문 X , 객체를 힙에 새로 할당해서 그곳에 자신의 멤버를 일일이 복사해 넣습니다.

    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            /*
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "나비";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "검정색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
            */

            /*
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검정색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
            */

            /*
            Console.WriteLine($"Global.Count : {Global.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global.Count : {Global.Count}");
            */

            Console.WriteLine("Shallow Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Console.WriteLine("Deep Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Console.ReadKey();
        }
    }
}
