using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_procuremen.Models
{
    public class FundingSource
    {
        public int Id { get; set; }
        public string FundingType { get; set; }
        public float FundingAmount { get; set; }

        public override string ToString()
        {
            return FundingType + " " + FundingAmount;
        }
    }
}
