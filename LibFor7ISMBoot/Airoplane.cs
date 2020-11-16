using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibFor7ISMBoot
{
    public class Airoplane
    {
        public string StartCity { private set; get; }
        public string FinishCity { private set; get; }
        public Date StartDate { private set; get; }
        public Date FinishDate { private set; get; }

        public Airoplane()
        {
            StartCity = "CurrentLocation";
            FinishCity = "FinalLocation";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airoplane(string startCity, string finishCity, Date dateStart, Date dateFinish)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = dateStart;
            FinishDate = dateFinish;
        }
        public Airoplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airoplane(Airoplane copy)
        {
            StartCity = copy.StartCity;
            FinishCity = copy.FinishCity;
            FinishDate = copy.FinishDate;
            StartDate = copy.StartDate;
        }
        public void GetTotalTime()
        {
            Console.WriteLine($"Time for fly = {this.StartDate - this.FinishDate} minutes");
        }
        public bool IsArrivingToday()
        {
            if (this.StartDate.day == this.FinishDate.day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
