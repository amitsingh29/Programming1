using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class StopWatch
    {
        long startTimer = 0, stopTimer = 0;
        long elapsedTime;
        DateTime dt = DateTime.Now;
         
       public  void start()
        {
            startTimer = dt.Millisecond;
            Console.WriteLine("start time is "+dt.ToString());
            Console.WriteLine("start time in millis "+startTimer.ToString());
        }
        public void stop()
        {
            stopTimer = dt.Millisecond;
            Console.WriteLine("stop time is "+dt.ToString());
            Console.WriteLine("stop time in millis is "+stopTimer.ToString());
        }
        public long elapsedTimer()
        {
            elapsedTime = startTimer - stopTimer;
            Console.WriteLine("stopTimer is "+elapsedTime.ToString());
            return elapsedTime;
        }
        
    }
}
