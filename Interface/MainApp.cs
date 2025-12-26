using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interface
{
    /*
    interface ILogger
    {
        void WriteLog(string message);
    }
    */

    /*
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                    "{0} {1}",
                    DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력하세요 : ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }
    */

    /*
    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string format, params Object[] args)
        {
            String message = String.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    */

    /*
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    // 클래스의 다중 상속 X , 인터페이스 다중 상속 가능
    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }

        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }
    */
    
    // 기본 구현 메소드 
    // 인터페이스에 새로운 메소드를 추가할 때 기본적인 구현체를 갖도록 해서 
    // 기존의 있는 파생 클래스에서의 컴파일 에러를 막을 수 있게

    /*
    interface ILogger
    {
        void WriteLog(string message);

        // 런타임이 기본 인터페이스 구현을 지원하지 않는다
        void WriteError(string error)
        {
            WriteLog($"Error : {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }
    */
    
    //추상 클래스
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            //ClimateMonitor monitor = new ClimateMonitor(
            //        new FileLogger("MyLog.txt"));

            //ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());

            //monitor.start();

            //IFormattableLogger logger = new ConsoleLogger2();
            //logger.WriteLog("The world is not flat.");
            //logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);

            //FlyingCar car = new FlyingCar();
            //car.Run();
            //car.Fly();

            //IRunnable runnable = car as IRunnable;
            //runnable.Run();

            //IFlyable flyable = car as IFlyable;
            //flyable.Fly();

            //ILogger logger = new ConsoleLogger();
            //logger.WriteLog("System Up!");
            //logger.WriteError("System Fail");

            //ConsoleLogger clogger = new ConsoleLogger();
            //clogger.WriteLog("System Up");
            //clogger.WriteError("System Fail"); // 컴파일 에러 

            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();

            Console.ReadKey();

        }
    }
}


// 추상 클래스 예시 
/*
abstract class AbstractBase
{
    public abstract void SomeMethod();
}

class Derived : AbstractBase
{
    public override void SomeMethod()
    {
        // Something
    }
}
*/

//추상 메소드는 추상 클래스를 사용하는 프로그래머가 그 기능을 정의하도록 강제하는 장치
// 보통의 클래스를 통해서도 할 수 있음 : 그냥 메소드를 선언 후 , 매뉴얼을 적음 (파생 클래스를 만들어 사용 , methodA, B는 오버라이딩 해야함) 
// 그러나 강제시킬 수 없음
// >> 추상 클래스 이용 시 이런한 설명을 할 필요가 없음