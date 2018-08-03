using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class Outing
    {
        public enum OutingType
        {
            Bowling = 1, WaterPark, MiniGolf, Concert,
        }

        public Outing() { }

        public Outing(string type, int attended, DateTime date, decimal costPer)
        {
            EventType = type;
            Attended = attended;
            DateOfEvent = date;
            CostPerPerson = costPer;
            TotalCost = CostPerPerson * Attended;
        }

        public string EventType { get; set; }
        public int Attended { get; set; }
        public DateTime DateOfEvent { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalCost { get; set; }
        public OutingType Event { get; internal set; }
    }
}
