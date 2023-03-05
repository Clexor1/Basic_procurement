using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_procuremen.Models
{
    public class Request
    {
        public int Id { get; set; }
        public Employe Applicant { get; set; }
        public string Description { get; set; }

        public Offer SelectedOffer { get; set; }

        public FundingSource FundingSource { get; set; }

        public string Project { get; set; }
        public Employe ProjectLeader { get; set; }

        public bool ApplicantSignature { get; set; }
        public bool LeaderSignature { get; set; }
        public bool AccountingSignature { get; set; }
        public string AccountingRefusalReason { get; set; }

        public string LeaderRefusalReason { get; set; }

        public bool ViceDeanSignature { get; set; }

        public override string ToString()
        {
            return "Zahtjev broj: " + Id;
        }

    }
}
