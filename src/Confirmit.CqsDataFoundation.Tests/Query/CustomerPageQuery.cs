using System.Runtime.Serialization;
using Firmglobal.Framework.CqsDataFoundation.Query;

namespace Confirmit.CqsDataFoundation.Tests.Query
{
    [DataContract(Namespace = "http://www.confirmit.com/")]
    public sealed class CustomerPageQuery : QueryPaggedBase<Customer, DataPage<Customer>>
    {
    }

    [DataContract(Namespace = "http://www.confirmit.com/")]
    public sealed class CustomerRefPageQuery : QueryPaggedBase<CustomerRef, DataPage<CustomerRef>>
    {
    }
}
