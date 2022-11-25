using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Bus
    {
        public int Place { get; set; }
        public int Price { get; set; }
        public int PriceKof { get; set; }
        public int FreePlase { get; set; }

        List<string> Route = new List<string> { "Гомель", "Речица", "Светлогорск", "Жлобин", "Бобруйск" };
        List<string> Station = new List<string>();


        public Bus(int price, int plase)
        {
            Place = plase;
            FreePlase = plase;
            Price = price;
        }

        public bool StartTrip(string start, string end)
        {
            if (AddPssenger())
            {
                FreePlase--;
                int Start = Route.IndexOf(start);
                int End = Route.IndexOf(end);

                Price = Price + End - Start;

                Station.Add(end);

                return true;
            }

            return false;
        }
        public bool AddPssenger()
        {
            if (FreePlase >= 1)
            {
                return true;
            }
            return false;
        }

        public void NewStation(string station)
        {
            for(int i = 0; i < Station.Count; i++)
            {
                if(station == Station[i])
                {
                    Station.RemoveAt(i);
                    DelPssenger();
                    i--;
                }
            }
        }

        public void DelPssenger()
        {
            if (FreePlase < Place)
            {
                FreePlase++;
            }
        }

        public string ShowInfo()
        {
            return $"Всего мест: {Place}\nСвободных мест: {FreePlase}\n{Station.Count}";
        }
    }
}
