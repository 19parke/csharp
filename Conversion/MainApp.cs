using System;
using static System.Console;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class MainApp
    {
        //enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
        // 값을 선언한 변수 기준으로 1씩 증가
        //enum DialogResult { YES = 10, NO, CANCEL, CONFIRM = 50, OK}

        static void Main(string[] args)
        {
            //sbyte a = 127;
            //Console.WriteLine(a);

            //int b = (int)a;
            //Console.WriteLine(b);

            //float c = 89.6845f;
            //Console.WriteLine("a : {0}", c);

            //double d = (double)c;
            //Console.WriteLine("b: {0}", d);
            //Console.WriteLine("89.6845 == d : {0}", 89.6666 == d);

            //float e = 0.9f;
            //int f = (int)e;
            //Console.WriteLine(f);

            //float g = 1.1f;
            //int h = (int)g;
            //Console.WriteLine(h);

            //int i = 123;
            //string j = i.ToString();
            //Console.WriteLine(j);

            //float k = 3.14f;
            //string l = k.ToString();
            //Console.WriteLine(l);

            //string m = "123456";
            //int n = Convert.ToInt32(m);
            //Console.WriteLine(n);

            //string o = "1.2345";
            //float p = float.Parse(o);
            //Console.WriteLine(p);

            ////상수 
            //const int MAX_INT = 21474;
            //const int MIN_INT = -21474;

            //Console.WriteLine(MAX_INT);
            //Console.WriteLine(MIN_INT);

            //Console.WriteLine((int)DialogResult.YES);
            //Console.WriteLine((int)DialogResult.NO);
            //Console.WriteLine(DialogResult.CANCEL);
            //Console.WriteLine(DialogResult.CONFIRM);
            //Console.WriteLine((int)DialogResult.OK);

            //int? a = null;

            //Console.WriteLine(a.HasValue);
            //Console.WriteLine(a != null);

            //a = 3;

            //Console.WriteLine(a.HasValue);
            //Console.WriteLine(a != null);
            //Console.WriteLine(a.Value);

            //var a = 20;
            //Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

            //var d = new int[] { 10, 20, 30 };
            //Console.Write("Type: {0}, Value: ", d.GetType());
            //foreach (var e in d)
            //    Console.Write("{0} ", e);

            //System.Int32 a = 123;
            //int b = 456;

            //Console.WriteLine("a type: {0}, value: {1}", a.GetType().ToString(), a);
            //Console.WriteLine("b type: {0}, value: {1}", b.GetType().ToString(), b);

            //string greeting = "Good Morning";

            //WriteLine(greeting);
            //WriteLine();

            //IndexOf()
            //WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            //WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

            //LastIndexOf()
            //WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));

            //StartsWith()
            //WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));

            //EndsWith()
            //WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));

            //Contains()
            //WriteLine("Contains 'Evening': {0}", greeting.Contains("Evening"));

            //Replace
            //WriteLine("Replaced 'Morning' with 'Evening': {0}", greeting.Replace("Morning", "Evening"));

            //DateTime dt = new DateTime(2018, 11, 3, 23, 18, 22);

            //WriteLine("12시간 형식: {0:yyyy-mm-dd tt hh:mm:ss (ddd)}", dt);

            //CultureInfo ciKo = new CultureInfo("ko-KR");
            //WriteLine(dt.ToString(ciKo));

            //string name = "김튼튼";
            //int age = 23;
            //WriteLine($"{name,-10}, {age:D3}");

            //name = "이비실";
            //age = 17;
            //WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");

            int? a = null;
            Console.WriteLine($"{a ?? 0}");

            a = 99;
            Console.WriteLine($"{a ?? 0}");


            Console.ReadKey();
        }
    }
}
