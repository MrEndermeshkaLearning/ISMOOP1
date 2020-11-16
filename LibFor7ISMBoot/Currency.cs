using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFor7ISMBoot
{
    public class Currency
    {
        public string Name { private set; get; }
        public double ExRate { private set; get; }    
        public Currency()
        {
            Name = "Dollars";
            ExRate = 26.30;
        }
        public Currency(string NameOfVal, double ExChangeValue)
        {
            Name = NameOfVal;
            ExRate = ExChangeValue;
        }
        public Currency( double ExChangeValue)
        {
            Name = "Dollars";
            ExRate = ExChangeValue;
        }
        public Currency(Currency copy)
        {
            Name = copy.Name;
            ExRate = copy.ExRate;
        }
    }
}
