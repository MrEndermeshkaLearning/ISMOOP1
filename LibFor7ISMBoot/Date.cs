using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFor7ISMBoot
{
    public class Date
    {
        public string year { protected set; get; }
        public string month { protected set; get; }
        public string day { protected set; get; }
        public string hours { protected set; get; }
        public string minutess { protected set; get; }
        public Date()
        {
            DateTime dt = new DateTime();
            year = dt.Year.ToString();
            month = dt.Month.ToString();
            day = dt.Day.ToString();
            hours = dt.Hour.ToString();
        }
        public Date(string YR, string MT, string DY, string HS)
        {
            year = YR;
            month = MT;
            day = DY;
            hours = HS;
        }
        public Date(DateTime dt)
        {
            year = dt.Year.ToString();
            month = dt.Month.ToString();
            day = dt.Day.ToString();
            hours = dt.Hour.ToString();
        }
        public Date(Date dt)
        {
            year = dt.year;
            month = dt.month;
            day = dt.day;
            hours = dt.hours;
        }
        public static double operator -(Date x, Date y)
        {
            double result;
            try
            {
                DateTime dtX = new DateTime(Convert.ToInt32(x.year), Convert.ToInt32(x.month), Convert.ToInt32( x.day), Convert.ToInt32(x.hours), Convert.ToInt32(x.minutess),0);
                DateTime dtY = new DateTime(Convert.ToInt32(y.year), Convert.ToInt32(y.month), Convert.ToInt32( y.day), Convert.ToInt32(y.hours), Convert.ToInt32(y.minutess),0);
                TimeSpan res = dtX - dtY;
                result = res.TotalMinutes;
                return result;

            }
            catch
            {
                throw new ArgumentException("IncorectDate");
            }
        }
    }
}
