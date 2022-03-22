using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qual_Code.Entités;

namespace Qual_Code.Service
{
    static internal class ContractService
    {
        public static Customer? ChangeProspectToCustomer(Prospect prospect)
        {
            List<Offer> offerList = prospect.Offers;
            Boolean HasOneApprovedOffer = false;
            offerList.ForEach(offer => { if (offer.HasBeenApproved) HasOneApprovedOffer = true; });
            if (HasOneApprovedOffer)
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
