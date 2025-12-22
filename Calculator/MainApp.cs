using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
/*
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class MainApp
    {
        static void Main()
        {
            int result = Calculator.Plus(3, 5);
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
*/

    /*
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price: {price}");
        }
    }
    */

    class MainApp
    {
        /*
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {
            if(name == "")
            {
                Console.WriteLine("이름을 입력해주세요.");
                return;
            }
            Console.WriteLine($"Name:{name}, Phone: {phone}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"10번째 피보나치 수 : {Fibonacci(10)}");

            PrintProfile("", "123-4567");
            PrintProfile("박은혜", "456-1230");

            Console.ReadKey();
        }
        */

        /*
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
         
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");

            Swap(ref x, ref y);

            Console.WriteLine($"x:{x}, y:{y}");

            Console.ReadKey();
        }
        */

        /*
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price: {normal_local_price}");

            Console.ReadKey();
        }
        */
    
        /*
        static void Divide(int a , int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            //int c;
            //int d;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a: {a}, b:{b}, a/b:{c}, a%b:{d}");

            Console.ReadKey();
        }
        */
    
        /*
        static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int, int)...");
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Callingf int Plus(int, int, int)...");
            return a + b + c;
        }

        static double Plus(double a , double b)
        {
            Console.WriteLine("Calling double Plus(double, double)...");
            return a + b;
        }

        static double Plus(int a, double b)
        {
            Console.WriteLine("Calling double Plus(int, double)");
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));

            Console.ReadKey();
        }
        */

        /*
        static int Sum(params int[] args)
        {
            Console.Write("Summing...");

            int sum = 0;

            for(int i=0; i<args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");

                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine($"Sum : {sum}");

            Console.ReadKey();
        }
        */
    
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            //로컬 함수 
            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) // A~Z ASCII 값 : 65~90
                    return arr[i];
                else // a ~ z ASCII 값 : 97 ~ 122
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
            Console.WriteLine(ToLowerString("This is C#"));

            Console.ReadKey();
        }
    }
}