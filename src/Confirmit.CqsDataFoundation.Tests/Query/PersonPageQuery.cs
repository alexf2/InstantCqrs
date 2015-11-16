using System.Runtime.Serialization;
using Firmglobal.Framework.CqsDataFoundation.Query;

namespace Confirmit.CqsDataFoundation.Tests.Query
{
    [DataContract(Namespace = "http://www.confirmit.com/")]
    public sealed class PersonPageQuery : QueryPaggedBase<Person, DataPage<Person>>
    {
    }
}
