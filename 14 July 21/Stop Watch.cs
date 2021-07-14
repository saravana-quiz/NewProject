using System;
using System.Diagnostics;
using System.Threading;

namespace Stop_Watch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isTriggered;
        private Random _value;

        public Stopwatch()
        {
            _startTime = new DateTime();
            _stopTime = new DateTime();
            _isTriggered = false;
            _value = new Random();

        }
        public void Start()
        {
            if (_isTriggered)
            {
                throw new InvalidOperationException();

            }
            _startTime = DateTime.Now;
            _isTriggered = true;
            Console.WriteLine("Start Time : "+_startTime.Hour+":"+_startTime.Minute+":"+_startTime.Second+":"+_startTime.Millisecond);
        }
        public void Stop()
        {
            Thread.Sleep(8000);
            _stopTime = DateTime.Now;
            _isTriggered = false;
            Console.WriteLine("Stop Time : " + _stopTime.Hour + ":" + _stopTime.Minute + ":" + _stopTime.Second + ":" + _stopTime.Millisecond);
            TimeSpan interval =  _stopTime - _startTime;
            Interval(interval);
        }
        public void Interval(TimeSpan interval)
        {
            Console.WriteLine("Interval Period : "+interval.Seconds +"sec"+interval.Milliseconds+"millisec");
            

        }
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
           
            
        }
    }
}
