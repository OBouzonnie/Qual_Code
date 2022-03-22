using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_Code.Entités
{
    internal class Customer:BaseEntity
    {
        public static int count { get; set; }

        public string CompanyName { get; set; } //raison sociale

        public Address Address { get; set; }

        public List<Contact> Contacts { get; set; }

        public DateTime? ContactDate { get; set; }

        public List<Offer> Offers { get; set; }

        public Customer(string companyName, Address address)
        {
            this.CompanyName = companyName;
            this.Contacts = new List<Contact>();
            this.Address = address;
            this.Offers = new List<Offer>();
            Customer.count++;
        }

        public void AddContact(Contact contact)
        {
            this.Contacts.Add(contact);
        }

        public void Contacted()
        {
            this.ContactDate = DateTime.Now;
        }

        public void AddOffer(Offer offer)
        {
            this.Offers.Add(offer);
        }

        public void NewOffer(string name, double amount, DateTime validUntil)
        {
            this.Offers.Add(new Offer(name, amount, validUntil));
        }
    }
}
