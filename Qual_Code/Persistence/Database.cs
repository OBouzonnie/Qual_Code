using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qual_Code.Entités;

namespace Qual_Code.Persistence
{
    static internal class Database
    {
        static public List<Address> Addresses { get; } = new List<Address>();
        static public List<Contact> Contacts { get; } = new List<Contact>();
        static public List<Customer> Customers { get; } = new List<Customer>();
        static public List<Invoice> Invoices { get; } = new List<Invoice>();
        static public List<Offer> Offers { get; } = new List<Offer>();
        static public List<Prospect> Prospects { get; } = new List<Prospect>();

        static public void CreateResource(BaseEntity Entity)
        {
            if (Entity is Address) Addresses.Add((Address)Entity);
            if (Entity is Contact) Contacts.Add((Contact)Entity);
            if (Entity is Customer) Customers.Add((Customer)Entity);
            if (Entity is Invoice) Invoices.Add((Invoice)Entity);
            if (Entity is Offer) Offers.Add((Offer)Entity);
            if (Entity is Prospect) Prospects.Add((Prospect)Entity);
        }

        static public void UpdateResource(BaseEntity Entity)
        {
            if (Entity is Address) {
                int index = Addresses.IndexOf((Address)Entity);
                if (index != -1)
                {
                    Addresses.RemoveAt(index);
                    Addresses.Insert(index, (Address)Entity);
                }
            }
            if (Entity is Contact)
            {
                int index = Contacts.IndexOf((Contact)Entity);
                if (index != -1)
                {
                    Contacts.RemoveAt(index);
                    Contacts.Insert(index, (Contact)Entity);
                }
            }
            if (Entity is Customer)
            {
                int index = Customers.IndexOf((Customer)Entity);
                if (index != -1)
                {
                    Customers.RemoveAt(index);
                    Customers.Insert(index, (Customer)Entity);
                }
            }
            if (Entity is Invoice)
            {
                int index = Invoices.IndexOf((Invoice)Entity);
                if (index != -1)
                {
                    Invoices.RemoveAt(index);
                    Invoices.Insert(index, (Invoice)Entity);
                }
            }
            if (Entity is Offer)
            {
                int index = Offers.IndexOf((Offer)Entity);
                if (index != -1)
                {
                    Offers.RemoveAt(index);
                    Offers.Insert(index, (Offer)Entity);
                }
            }
            if (Entity is Prospect)
            {
                int index = Prospects.IndexOf((Prospect)Entity);
                if (index != -1)
                {
                    Prospects.RemoveAt(index);
                    Prospects.Insert(index, (Prospect)Entity);
                }
            }
        }

        static public void DeleteResource(BaseEntity Entity)
        {
            if (Entity is Address)
            {
                int index = Addresses.IndexOf((Address)Entity);
                if (index != -1)
                {
                    Addresses.RemoveAt(index);
                }
            }
            if (Entity is Contact)
            {
                int index = Contacts.IndexOf((Contact)Entity);
                if (index != -1)
                {
                    Contacts.RemoveAt(index);
                }
            }
            if (Entity is Customer)
            {
                int index = Customers.IndexOf((Customer)Entity);
                if (index != -1)
                {
                    Customers.RemoveAt(index);
                }
            }
            if (Entity is Invoice)
            {
                int index = Invoices.IndexOf((Invoice)Entity);
                if (index != -1)
                {
                    Invoices.RemoveAt(index);
                }
            }
            if (Entity is Offer)
            {
                int index = Offers.IndexOf((Offer)Entity);
                if (index != -1)
                {
                    Offers.RemoveAt(index);
                }
            }
            if (Entity is Prospect)
            {
                int index = Prospects.IndexOf((Prospect)Entity);
                if (index != -1)
                {
                    Prospects.RemoveAt(index);
                }
            }
        }

        static public Address? GetAddress(int id)
        {
            if(Addresses.Where(a => a.Id == id).Count() > 0)
            {
                return Addresses.Where(a => a.Id == id).First();
            }
            return null;
        }

        static public Contact? GetContact(int id)
        {
            if (Contacts.Where(a => a.Id == id).Count() > 0)
            {
                return Contacts.Where(a => a.Id == id).First();
            }
            return null;
        }

        static public Customer? GetCustomer(int id)
        {
            if (Customers.Where(a => a.Id == id).Count() > 0)
            {
                return Customers.Where(a => a.Id == id).First();
            }
            return null;
        }

        static public Invoice? GetInvoice(int id)
        {
            if (Invoices.Where(a => a.Id == id).Count() > 0)
            {
                return Invoices.Where(a => a.Id == id).First();
            }
            return null;
        }

        static public Offer? GetOffer(int id)
        {
            if (Offers.Where(a => a.Id == id).Count() > 0)
            {
                return Offers.Where(a => a.Id == id).First();
            }
            return null;
        }

        static public Prospect? GetProspect(int id)
        {
            if (Prospects.Where(a => a.Id == id).Count() > 0)
            {
                return Prospects.Where(a => a.Id == id).First();
            }
            return null;
        }
    }
}
