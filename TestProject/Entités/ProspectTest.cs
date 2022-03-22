using NUnit.Framework;
using Qual_Code.Entités;
using System;

namespace TestProject.Entités
{
    internal class ProspectTest
    {
        Address Address;
        Prospect Prospect;
        Offer Offer;
        Invoice Invoice;

        [SetUp]
        public void Setup()
        {
            Address = new Address(14, "rue Alphonse Terray", 38000, "Grenoble");
            Prospect = new Prospect("Prospect", Address);
            Offer = new Offer("Offre", 999, new DateTime(2023, 03, 22));
            Invoice = new Invoice(999, DateTime.Now, 0, Offer);
        }

        [Test]
        public void TestAddInvoice()
        {
            Assert.AreEqual(Prospect.Invoices.Count, 0);
            Prospect.AddInvoice(Invoice);
            Assert.AreEqual(Prospect.Invoices.Count, 1);
        }

        public void TestHasBecomeRecurrent()
        {
            Assert.IsFalse(Prospect.IsRecurrent);
            Prospect.HasBecomeRecurrent();
            Assert.IsTrue(Prospect.IsRecurrent);
        }

        public void TestAreAllIncomePayed()
        {
            Assert.IsFalse(Prospect.AreAllInvoicedPayed());
            Prospect.Invoices.ForEach(i => i.PayedAt = DateTime.Now);
            Assert.IsTrue(Prospect.AreAllInvoicedPayed());
        }
    }
}
