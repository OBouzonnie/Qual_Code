using Qual_Code.Entités;
using Qual_Code.Service;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Address Address = new Address(14, "rue Alphonse Terray", 38000, "Grenoble");

Customer Customer = new Customer("Ma Compagnie", Address);
Prospect Prospect = new Prospect("Mon autre compagnie", Address);

Console.WriteLine(Prospect.count);

Prospect.NewOffer("offre 1", 2500, new DateTime());

Prospect.Offers[0].Approve();

Customer? CastedProspect = ContractService.ChangeProspectToCustomer(Prospect);

Console.WriteLine(CastedProspect != null ? CastedProspect.CompanyName : "Prospect was not casted");

Console.WriteLine(DateTime.Now);

Console.ReadLine();