using Firmglobal.Framework.CqsDataFoundation;

namespace Confirmit.CqsDataFoundation.Tests.Query
{
    public sealed class CustomersDataContext : ObjectDbContextMgr<Customer[]>
    {
        public CustomersDataContext(Customer[] dataSource)
            : base(dataSource, false)
        {
        }
    }
}
