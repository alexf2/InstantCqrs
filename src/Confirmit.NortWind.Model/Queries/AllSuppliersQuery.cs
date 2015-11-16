using System.Runtime.Serialization;
using Confirmit.NortWind.Model.DTO;
using Firmglobal.Framework.CqsDataFoundation.Query;

namespace Confirmit.NortWind.Model.Queries
{
    [DataContract(Namespace = "http://www.confirmit.ru/NorthWind")]
    public class AllSuppliersQuery : QueryPaggedBase<Supplier, DataPage<Supplier>>
    {
        public AllSuppliersQuery(int pageNumber, int size = Constants.PageSizeDefault)
            : base(size, pageNumber)
        {            
        }
    }
}
