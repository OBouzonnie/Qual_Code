using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qual_Code.Entités;
using Qual_Code.Persistence;

namespace Qual_Code.Service
{
    static internal class RepositoryService
    {
        
        static public void Post(BaseEntity Entity)
        {
            Database.CreateResource(Entity);
        }

        static public void Put(BaseEntity Entity)
        {
            Database.UpdateResource(Entity);
        }

        static public void Delete(BaseEntity Entity)
        {
            Database.DeleteResource(Entity);
        }

        static public Address? GetAddress(int index)
        {
            return Database.GetAddress(index);
        }

        static public Contact? GetContact(int index)
        {
            return Database.GetContact(index);
        }

        static public Customer? GetCustomer(int index)
        {
            return Database.GetCustomer(index);
        }

        static public Invoice? GetInvoice(int index)
        {
            return Database.GetInvoice(index);
        }

        static public Offer? GetOffer(int index)
        {
            return Database.GetOffer(index);
        }

        static public Prospect? GetProspect(int index)
        {
            return Database.GetProspect(index);
        }

        static public List<Address> GetAllAddresses(BaseEntity Entity)
        {
            return Database.Addresses;
        }

        static public List<Contact> GetAllContacts(BaseEntity Entity)
        {
            return Database.Contacts;
        }

        static public List<Customer> GetAllCustomers(BaseEntity Entity)
        {
            return Database.Customers;
        }

        static public List<Invoice> GetAllInvoices(BaseEntity Entity)
        {
            return Database.Invoices;
        }

        static public List<Offer> GetAllOffers(BaseEntity Entity)
        {
            return Database.Offers;
        }

        static public List<Prospect> GetAllProspects(BaseEntity Entity)
        {
            return Database.Prospects;
        }
    }
}
