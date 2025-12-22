using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    /*
    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }
    }
    */

    /*
    class MyClass
    {
        int a, b, c;

        // 생성자
        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b}, {c})");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a: {a}, b:{b}, c:{c}");
        }
    }
    */

    class WaterHeater
    {
        protected int temperature;

        // temperature 필드는 protected 로 수식되었으므로 외부에서 직접 접근할 수 없음. 이렇게 public 메소드를 통해 접근해야 됨
        public void SetTemperature(int temperature)
        {
            if(temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }

            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            /*
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
            */

            /*
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PrintFields();
            */

            try
            {
                WaterHeater heater = new WaterHeater();
                // public 메소드인 SetTemperature 로 접근해야됨
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);

            }

            Console.ReadKey();
        }
    }
}
