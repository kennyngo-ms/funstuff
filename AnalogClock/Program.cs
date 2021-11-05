using System;

namespace AnalogClock
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = "09:15";

            int hours = 0; int minutes = 0;
            float hourHandAngle = 0; float minuteHandAngle;

            //Console.WriteLine(time.Substring(0, 2) + " " + time.Substring(3, 2));
            hours =Int32.Parse(time.Substring(0,2))%12;
            minutes = Int32.Parse(time.Substring(3,2));
            Console.WriteLine(hours + " " + minutes);

            minuteHandAngle = (float)minutes / 60 * 360;
            hourHandAngle = (float)hours / 12 * 360 + (minuteHandAngle/360 * 30);

            if(Math.Abs(hourHandAngle - minuteHandAngle) >= 180)
            {
                Console.WriteLine("hours angle: " + hourHandAngle + "\nminutes angle: " + minuteHandAngle + "\ninterior angle: " + (360- Math.Abs(hourHandAngle - minuteHandAngle)));
            }
            else Console.WriteLine("hours angle: " + hourHandAngle + "\nminutes angle: " + minuteHandAngle + "\ninterior angle: " + Math.Abs(hourHandAngle-minuteHandAngle));
        }
    }
}
