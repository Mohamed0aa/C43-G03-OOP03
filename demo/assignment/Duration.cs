using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Duration
    {
        public int Hour {  get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }


        public Duration(int sec)
        {
            if (sec >= 3600)
            {
                Hour = sec / 3600;
            }
            if (sec < 3600)
            {
                Hour = 0;
            }

            Minute = ((sec - (3600 * Hour)) / 60);

            Second = (sec -( (3600 * Hour)+(Minute*60)));
        }

        public Duration(int h,int m, int s)
        { 
            this.Hour = h;
            this.Minute = m;
            this.Second = s;
        }
        public Duration()
        {
            this.Hour = 0;
            this.Minute = 0;
            this.Second = 0;
        }
        public override string ToString()
        {
            return $"Hours: {Hour}, Minutes :{Minute}, Seconds :{Second},";
        }

        public static Duration operator +(Duration x, Duration y)
        {
            int total = x.Hour*3600 + y.Hour*3600 + x.Minute*60 + y.Minute*60 + x.Second + y.Second;
            return new Duration(total);
        }
        public static Duration operator +(Duration x, int y)
        {
            int total = x.Hour * 3600 + x.Minute * 60 + x.Second + y;
            return new Duration(total);
        }
        public static Duration operator +(int y, Duration x)
        {
            int total = x.Hour * 3600 + x.Minute * 60 + x.Second + y;
            return new Duration(total);
        }
        public static Duration operator -(Duration x, Duration y)
        {

            int total1=x.Hour*3600 +x.Minute*60 + x.Second;
            int total2=y.Hour*3600+y.Minute*60 + y.Second;
            return new Duration(total1-total2);
        }


        public static Duration operator ++(Duration x)
        {
            x.Minute++;
            if (x.Minute >= 60) { x.Hour++; x.Minute = 0; }
            return x;
        }
        public static Duration operator --(Duration x)
        {
            x.Minute--;
            if (x.Minute < 0)
            {
                x.Hour--;
                x.Minute = 59;
            }
            return x;
        }

        public static bool operator >=(Duration x, Duration y)
        {
            int total1 = x.Hour * 3600 + x.Minute * 60 + x.Second;
            int total2 = y.Hour * 3600 + y.Minute * 60 + y.Second;
            return total1 >= total2;
        }

        public static bool operator <=(Duration x, Duration y)
        {
            int total1 = x.Hour * 3600 + x.Minute * 60 + x.Second;
            int total2 = y.Hour * 3600 + y.Minute * 60 + y.Second;
            return (total1 <= total2);
        }
        //public static bool operator ==(Duration x, Duration y)
        //{
        //    int total1 = x.Hour * 3600 + x.Minute * 60 + x.Second;

        //    return (total1==0);
        //}
        //public static bool operator !=(Duration x, Duration y)
        //{
        //    int total1 = x.Hour * 3600 + x.Minute * 60 + x.Second;
        //    int total2 = y.Hour * 3600 + y.Minute * 60 + y.Second;
        //    return (total1 !=total2);
        //}

        public static explicit operator DateTime(Duration x)
        {
            return new DateTime().AddHours(x.Hour).AddMinutes(x.Minute).AddSeconds(x.Second);
        }
        






    }


}
