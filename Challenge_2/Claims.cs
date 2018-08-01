using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Claims
    {
        public Claims() { }

        public Claims(int claimID, string type, string description, decimal amount, DateTime accidentDate, DateTime claimDate)
        {
            ClaimID = claimID;
            TypeOfAccident = type;
            Description = description;
            AmountOfDamage = amount;
            DateOfAccident = accidentDate;
            ClaimDate = claimDate;
            IsValidClaim = ClaimDate - DateOfAccident < TimeSpan.FromDays(30);
        }

        public int ClaimID { get; set; }
        public string TypeOfAccident { get; set; }
        public string Description { get; set; }
        public decimal AmountOfDamage { get; set; }
        public DateTime DateOfAccident { get; set; }
        public DateTime ClaimDate { get; set; }
        public bool IsValidClaim { get; set; }
    }
}
