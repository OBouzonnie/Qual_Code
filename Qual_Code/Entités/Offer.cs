using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_Code.Entités
{
    internal class Offer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }

        public DateTime ValidUntil { get; set; }

        public Boolean HasBeenApproved { get; set; }

        public Offer(string name, double amount, DateTime validUntil)
        {
            this.Name = name;
            this.Amount = amount;
            this.ValidUntil = validUntil;
            this.HasBeenApproved = false;
        }

        public void Approve()
        {
            this.HasBeenApproved = true;
        }
    }
}
