using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class StopWatch
    {
        private DateTime _stopTime;
        private DateTime _startTime;
        private TimeSpan _displayTime;
        private string _command;

        public DateTime StopTime { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan DisplayTime { get; set; }
        public string Command { get; set; }

        public void Start()
        {
            _command = Console.ReadLine();

            while (_command != "start")
            {
                Console.WriteLine("Upss... Enter 'start' to start stopwatch: ");
                _command = Console.ReadLine();
            }

            _startTime = DateTime.Now;
            StartTime = _startTime;
        }

        public void Stop()
        {
            _command = Console.ReadLine();

            while (_command != "stop")
            {
                Console.WriteLine("Upss... Enter 'stop' to stop stopwatch: ");
                _command = Console.ReadLine();
            }

            _stopTime = DateTime.Now;
            StopTime = _stopTime;
        }

        public void DurationTime(DateTime startTime, DateTime stopTime)
        {
            _displayTime = stopTime - startTime;
            DisplayTime = _displayTime;
            Console.WriteLine("{0} ", DisplayTime);

            Console.WriteLine("Type 'run' if you want to run this program again: ");
            _command = Console.ReadLine();
            Command = _command;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            Console.WriteLine("Hello!");

            do
            {
                Console.WriteLine("Type 'start' to start this stopwatch: ");
                stopwatch.Start();

                Console.WriteLine("Type 'stop' to stop this stopwatch: ");
                stopwatch.Stop();

                stopwatch.DurationTime(stopwatch.StartTime, stopwatch.StopTime);

            } while (stopwatch.Command == "run");
        }
    }
}
