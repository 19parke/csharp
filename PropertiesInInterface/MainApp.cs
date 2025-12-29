using System;

namespace PropertiesInInterface
{
    /*
    interface INamedValue
    {
        string Name
        {
            get;
            set;
        }

        string Value { get; set; }

    }

    class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    */

    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }

        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get;
            set;
        }
    }
     

    class MainApp
    {
        static void Main(string[] args)
        {
            /*
            NamedValue name = new NamedValue() { Name = "이름", Value = "박상현" };
            NamedValue height = new NamedValue() { Name = "키", Value = "177cm" };
            NamedValue weight = new NamedValue() { Name = "몸무게", Value = "90kg" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");
            */

            Product product_1 = new MyProduct() { ProductDate = new DateTime(2018, 1, 10) };

            Console.WriteLine("Product:{0}, Product Date : {1}", product_1.SerialID, product_1.ProductDate);

            Product product_2 = new MyProduct() { ProductDate = new DateTime(2018, 2, 3) };

            Console.WriteLine("Product: {0}, Product Date : {1}", product_2.SerialID, product_2.ProductDate);
        }
    }

}