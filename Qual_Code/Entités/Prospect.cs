using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_Code.Entités
{
    internal class Prospect:Customer
    {
        public List<Invoice> Invoices { get; set; }

        public Boolean IsRecurrent { get; set; }

        public Prospect(string companyName, Address address):base(companyName, address)
        {
            this.Invoices = new List<Invoice>();
            this.IsRecurrent = false;
        }

        public void AddInvoice(Invoice invoice)
        {
            this.Invoices.Add(invoice);
        }

        public void HasBecomeRecurrent()
        {
            this.IsRecurrent = true;
        }

        public Boolean AreAllInvoicedPayed()
        {
             List<Invoice> payedInvoices = this.Invoices.Where(i => i.PayedAt != null).ToList();

            return this.Invoices.Count == payedInvoices.Count ? true : false;
        }
    }
}
