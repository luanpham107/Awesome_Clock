using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Awesome_Clock.Extensions;
namespace Awesome_Clock.Models
{
    public class Time : BindableBase
    {
        private int hour;
        private int second;
        private int minute;

        public static implicit operator Time(DateTime date)
        {
            return new Time() { Hour = date.Hour, Minute = date.Minute, Second = date.Second };
        }

        public static Time operator++(Time t)
        {
            if(t.Second++ == 59)
            {
                t.Second = 0;
                if (t.Minute++ == 59)
                {
                    t.Minute = 0;
                    t.Hour++;
                }
            }
            return t;
        }


        public int Hour
        {
            get => hour.ToHourInt();
            set => SetProperty(ref hour, value);
        }

        public int Second
        {
            get => second;
            set => SetProperty(ref second, value);
        }

        public int Minute
        {
            get => minute;
            set => SetProperty(ref minute, value);
        }

        public override string ToString()
        {
            return "Current Time: " + Hour + ":" + Minute + ":" + Second;
        }


    }
}
