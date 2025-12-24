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


            Console.ReadKey();

        }
    }
}
