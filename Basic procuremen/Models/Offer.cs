using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_procuremen.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Bidder { get; set; }
        public float PriceWithoutTax { get; set; }
        public float PriceWithTax { get; set; }

        public override string ToString()
        {
            return "Ponuda broj:" + Id; 
        }

    }
}
