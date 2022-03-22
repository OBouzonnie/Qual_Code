using NUnit.Framework;
using Qual_Code.Entités;
using System;

namespace TestProject
{
    public class CustomerTests
    {
        Address Address;
        Customer Customer;

        [SetUp]
        public void Setup()
        {
            Address = new Address(14, "rue Alphonse Terray", 38000, "Grenoble");
            Customer = new Customer("Client", Address);
        }

        [Test]
        public void TestAddContact()
        {
            Contact Contact = new Contact("Olivier1", "Bouzonnie1", "olivier.bouzonnie@gmail.com", "0684612034");
            Assert.AreEqual(Customer.Contacts.Count, 0);
            Customer.AddContact(Contact);
            Assert.AreEqual(Customer.Contacts.Count, 1);
        }

        [Test]
        public void TestContacted()
        {
            Assert.IsNull(Customer.ContactDate);
            Customer.Contacted();
            Assert.IsNotNull(Customer.ContactDate);
        }

        [Test]
        public void TestAddOffer()
        {
            Offer Offer = new Offer("offre", 999, new DateTime(2022, 3, 28));
            Assert.AreEqual(Customer.Offers.Count, 0);
            Customer.AddOffer(Offer);
            Assert.AreEqual(Customer.Offers.Count, 1);
        }

        [Test]
        public void TestNewOffer()
        {
            Offer Offer = new Offer("offre", 999, new DateTime(2022, 3, 28));
            Assert.AreEqual(Customer.Offers.Count, 0);
            Customer.NewOffer("offre", 999, new DateTime(2022, 3, 28));
            Assert.AreEqual(Customer.Offers.Count, 1);
        }
    }
}