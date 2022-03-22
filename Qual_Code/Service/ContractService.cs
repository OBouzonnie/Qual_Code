using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qual_Code.Entités;

namespace Qual_Code.Service
{
    internal class ContractService
    {
        public static Customer? ChangeProspectToCustomer(Prospect prospect)
        {
            List<Offer> offerList = prospect.Offers;
            Boolean HasOneApprovedOffer = false;
            offerList.ForEach(offer => { if (offer.HasBeenApproved == true) HasOneApprovedOffer = true; });
            if (HasOneApprovedOffer == true)
            {
                Customer? CastedCustomer = (Customer)prospect;
                return CastedCustomer;
            }
            else
            {
                return null;
            }
        }
    }
}
