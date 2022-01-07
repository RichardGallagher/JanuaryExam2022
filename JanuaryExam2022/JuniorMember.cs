using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam2022
{
    public class JuniorMember : Member
    {
       
        public override decimal AnnualFee()
        {
            return Fee * 0.5m;
        }
    }
}
