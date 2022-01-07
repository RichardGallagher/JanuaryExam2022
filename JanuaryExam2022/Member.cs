using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam2022
{
    public enum PaymentSchedule
    {
        Annual,
        Biannual,
        Monthly
    }
    public class Member
    {
        //properties
        public string Name { get; set; }

        public DateTime JoinDate { get; set; }

        public decimal Fee { get; set; }

        //Constructors

        //Methods
        public override string ToString()
        {
            return $"{Name}";
        }


        private DateTime renewalDate;

        public DateTime RenewalDate
        {
            get
            {
                renewalDate = JoinDate.AddYears(1);
                return renewalDate;
            }
        }


        public virtual decimal AnnualFee()
        {
            return Fee;
        }


        
    }
}
