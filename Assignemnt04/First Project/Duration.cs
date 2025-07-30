using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt04.First_Project
{
    internal class Duration
    {
        private int _hours;
        private int _minutes;
        private int _seconds;


        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public int Minutes 
        {
            get { return _minutes; }
            set
            { 
                _minutes = value % 60;
                Hours += value / 60;

                 if(_minutes < 0)
                {
                    Hours--;
                    Minutes += 60;
                }
            }
        }
        public int Seconds 
        {
            get { return _seconds; }
            set 
            {
                _seconds = value%60;
                Minutes = value/60;

                if (_seconds < 0)
                {
                    Minutes--;
                    Seconds += 60;
                }
            }
        }
           

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int seconds)
        {
            Seconds = seconds % 60;
            seconds -= Seconds;

            Minutes = (seconds/60) % 60;
            seconds-=Minutes*60;

            Hours = seconds / 3600;
        }

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

        public static Duration operator + (Duration D1, Duration D2)
        {
            return new Duration(D1.Hours + D2.Hours, D1.Minutes + D2.Minutes, D1.Seconds + D2.Seconds);
        }

        public static Duration operator - (Duration D1, Duration D2)
        {
            return new Duration(D1.Hours - D2.Hours, D1.Minutes - D2.Minutes, D1.Seconds - D2.Seconds);
        }


        public static Duration operator + (Duration D1, int seconds)
        {
            return new Duration(D1.Hours, D1.Minutes, D1.Seconds + seconds);
        }

        public static Duration operator + (int seconds, Duration D1)
        {
            return new Duration(D1.Hours, D1.Minutes , D1.Seconds + seconds);
        }

        public static Duration operator - (int seconds, Duration D1)
        {
            return new Duration(D1.Hours, D1.Minutes, D1.Seconds - seconds);
        }

        public static Duration operator ++ (Duration D)
        {
            D.Minutes++;
            return D;
        }

        public static Duration operator -- (Duration D)
        {
            D.Minutes--;
            return D;
        }

        public static bool operator > (Duration D1, Duration D2)
        {
           if(D1.Hours == D2.Hours)
           {
                if (D1.Minutes == D2.Minutes)
                {
                    return D1.Seconds > D2.Seconds;
                }

                else
                {
                    return D1.Minutes > D2.Minutes;
                }
           }
            
            else
            {
                return D1.Hours > D2.Hours;
            }
        }

        public static bool operator < (Duration D1, Duration D2)
        {
            if (D1.Hours == D2.Hours)
            {
                if (D1.Minutes == D2.Minutes)
                {
                    return D1.Seconds < D2.Seconds;
                }

                else
                {
                    return D1.Minutes < D2.Minutes;
                }
            }

            else
            {
                return D1.Hours < D2.Hours;
            }
        }
    }
}
