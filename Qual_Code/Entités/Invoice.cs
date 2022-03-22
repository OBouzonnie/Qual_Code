using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_Code.Entités
{
    internal class Invoice
    {
        public int Id { get; set; }

        public double Amount { get; private set; }

        public string EmittedAt { get; private set; }

        public string? PayedAt { get; private set; }

        public int Status { get; private set; }

        public Offer Offer { get; private set; }

        public Invoice(double amount, string emittedAt, int status, Offer offer)
        {
            this.Amount = amount;
            this.EmittedAt = emittedAt;
            this.Status = status;
            this.Offer = offer;
            this.PayedAt = null;
        }
    }
}
