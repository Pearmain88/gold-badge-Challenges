using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Outing
    {
        public Outing() { }

        public Outing(string type, int attended, DateTime date, decimal costPer, decimal costTotal)
        {
            EventType = type;
            Attended = attended;
            DateOfEvent = date;
            CostPerPerson = costPer;
            TotalCost = costTotal;
        }

        public string EventType { get; set; }
        public int Attended { get; set; }
        public DateTime DateOfEvent { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalCost { get; set; }
    }
}
