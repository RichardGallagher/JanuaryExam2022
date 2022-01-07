using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam2022
{
    public class SeniorMember:Member
    {
        public override decimal AnnualFee()
        {
            return Fee * 0.75m;
        }
    }
}
