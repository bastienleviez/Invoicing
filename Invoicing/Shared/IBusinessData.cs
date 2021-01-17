using System.Collections.Generic;

namespace Invoicing.Shared
{
    public interface IBusinessData
    {
        List<Invoice> AllInvoices { get; }

        decimal SalesRevenue { get; }
        decimal Outstanding { get; }
    }
}
