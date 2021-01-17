using System;
using System.Collections.Generic;
using System.Linq;

namespace Invoicing.Shared
{
    public class BusinessTestData : IBusinessData
    {
        private List<Invoice> testInvoices = new List<Invoice>();
   
        public BusinessTestData()
        {
            testInvoices.Add(new Invoice("B2345", "Théo Castet", 2154.6m, DateTime.Now));
            testInvoices.Add(new Invoice("B1345", "Florian pointet", 12154.6m, DateTime.Now));
            testInvoices.Add(new Invoice("R2145", "Benjamin Ameztoy", 254.6m, DateTime.Now));
            testInvoices.Add(new Invoice("T2145", "Bastien Leviez", 32154.52m, DateTime.Now));
            testInvoices.ElementAt(1).RegisterPayment(DateTime.Now, 12154.6m);
            testInvoices.ElementAt(3).RegisterPayment(DateTime.Now, 16077.26m);
            testInvoices.ElementAt(3).Expected = DateTime.Now;
        }
        
        public List<Invoice> AllInvoices => testInvoices;

        public decimal SalesRevenue => testInvoices.Sum(invoice => invoice.Amount);

        public decimal Outstanding => testInvoices.Sum(invoice => invoice.Amount - invoice.Paid);
    }
}
