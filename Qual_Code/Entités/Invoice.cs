using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_Code.Entités
{
    internal class Invoice:BaseEntity
    {
        public double Amount { get; set; }

        public DateTime EmittedAt { get; set; }

        public DateTime? PayedAt { get; set; }

        public int Status { get; set; }

        public Offer Offer { get; set; }

        public Invoice(double amount, DateTime emittedAt, int status, Offer offer)
        {
            this.Amount = amount;
            this.EmittedAt = emittedAt;
            this.Status = status;
            this.Offer = offer;
            this.PayedAt = null;
        }
    }
}
