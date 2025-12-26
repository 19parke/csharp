using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            // setter 이용 > Name 을 통해 name 에 접근
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);

            // getter 이용
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            Console.ReadKey();
        }
    }
}


// Getter Setter 기본 형태 BUT!! C#은 메소드 보다 프로퍼티

/*
class MyClass
{
    private int myField;
    public int GetMyField() { return myField; }
    public void SetMyField(int NewValue) { myField = NewValue; }
}


MyClass obj = new MyClass();
obj.SetMyField(3);
Console.WriteLine(obj.GetMyField());
*/

// C# 에서의 get , set 선언
/*
class MyClass
{
    private int myField;
    public int MyField
    {
        get
        {
            return myField;
        }

// set을 선언하지 않으면 읽기 전용 프로퍼티가 됨
        set
        {
            myField = value;
        }
    }
}

MyClass obj = new MyClass();
obj.MyField = 3;
Console.WriteLine(obj.MyField);
*/

