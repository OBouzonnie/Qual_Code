using NUnit.Framework;
using Qual_Code.Entités;
using System;

namespace TestProject.Entités
{
    internal class OfferTests
    {
        Offer Offer;

        [SetUp]
        public void Setup()
        {
            Offer = new Offer("offre", 999, new DateTime(2022, 3, 28));
        }

        [Test]
        public void TestAddContact()
        {
            Assert.IsFalse(Offer.HasBeenApproved);
            Offer.Approve();
            Assert.IsTrue(Offer.HasBeenApproved);
        }
    }
}
