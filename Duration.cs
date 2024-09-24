using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPorject
{
    class Duration
    {

        public uint Hours { get; set; }

        private uint minutes;

        public uint Minutes
        {
            get { return minutes; }
            set
            {
                if (value > 60)
                {   
                    minutes = value % 60;
                    Hours++;
                }
                else
                    minutes = value;
            }

        }



        public Duration()
        {

        }
        public uint Seconds { get; set; }
        public Duration(uint _Hours, uint _Minutes, uint _Seconds)
        {
            if (_Minutes > 60)
            {
                _Minutes %= 60;
                minutes = _Minutes;
                Hours++;
            }
            else
                minutes = _Minutes;
            Hours = _Hours;
            Seconds = _Seconds;
        }
        public Duration(uint _Seconds)
        {

            while (_Seconds >= 60)
            {
                if (_Seconds >= 3600)
                {
                    Hours++;
                    _Seconds -= 3600;
                }
                else if (_Seconds < 3600 && _Seconds >= 60)
                {
                    minutes++;
                    _Seconds -= 60;
                }
            }
            Seconds = _Seconds;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            if (Hours == 0)
                return $"Minutes: {minutes}, Seconds: {Seconds}";
            else if (minutes == 0)
                return $"Hours: {Hours},Seconds: {Seconds}";
            else if (Seconds == 0)
                return $"Hours: {Hours}, Minutes: {minutes}";
            else
                return $"Hours: {Hours}, Minutes: {minutes}, Seconds: {Seconds}";


        }



        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.minutes + d2.minutes, d1.Seconds + d2.Seconds);

        }
        public static Duration operator +(Duration d1, uint seconds)
        {

            while (seconds >= 60)
            {
                if (seconds >= 3600)
                {
                    d1.Hours++;
                    seconds -= 3600;
                }
                else if (seconds < 3600 && seconds >= 60)
                {
                    d1.minutes++;
                    seconds -= 60;
                }
            }
            d1.Seconds = seconds;
            return new Duration(d1.Hours, d1.minutes, d1.Seconds);
        }
        public static Duration operator ++(Duration d)
        {
            if (d.minutes == 59)
            {
                d.Hours++;
                d.minutes = 0;
            }
            else
                d.minutes++;


            return new Duration(d.minutes);



        }
        public static Duration operator --(Duration d)
        {
            if (d.minutes == 0)
            {
                d.Hours--;
                d.minutes = 59;
            }
            else
                d.minutes--;
            return new Duration(d.minutes);
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            if (d1.Hours != d2.Hours)
                return d1.Hours > d2.Hours;
            else
            {

                if (d1.minutes != d2.minutes)
                    return d1.minutes > d2.minutes;
                else if (d1.Seconds != d2.Seconds)
                    return d1.Seconds > d2.Seconds;
                else
                    return false;

            }


        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.Hours < d2.Hours && d1.minutes < d2.minutes && d1.Seconds < d2.Seconds;
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            uint TotalMinutes1 = d1.Hours * 60 - d1.minutes;
            uint TotalMinutes2 = d2.Hours * 60 - d2.minutes;
            uint RealTotalMinutes = TotalMinutes1 - TotalMinutes2;
            uint Seconds = d1.Seconds - d2.Seconds;
            return new Duration(RealTotalMinutes / 60, RealTotalMinutes % 60, Seconds);


        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            if (d1.Hours == d2.Hours && d1.minutes == d2.minutes)
                return d1.Seconds <= d2.Seconds;
            else if (d1.Hours == d2.Hours)
                return d1.minutes <= d2.minutes;
            else
                return d1.Hours <= d2.Hours;
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            if (d1.Hours == d2.Hours && d1.minutes == d2.minutes)
                return d1.Seconds >= d2.Seconds;
            else if (d1.Hours == d2.Hours)
                return d1.minutes >= d2.minutes;
            else
                return d1.Hours >= d2.Hours;
        }
        public static bool operator true(Duration d)
        {
            bool flag = !(d.Hours == 0 && d.minutes == 0 && d.Seconds == 0);
            return flag;
        }
        public static bool operator false(Duration d)
        {
            bool flag = d.Hours == 0 && d.minutes == 0 && d.Seconds == 0;
            return flag;
        }

        public static explicit operator DateTime(Duration d)
        {
            DateTime Today = new DateTime();
            return new DateTime(Today.Year, Today.Month, Today.Day, (int)d.Hours, (int)d.minutes, (int)d.Seconds);
        }

        //الحمد لله الذي هدانا لهذا وما كنا لنهتدي لولا أن هدانا الله


    }
}






