using System.Runtime.Serialization;
using Confirmit.NortWind.Model.DTO;
using Firmglobal.Framework.CqsDataFoundation.Query;

namespace Confirmit.NortWind.Model.Queries
{
    [DataContract(Namespace = "http://www.confirmit.ru/NorthWind")]
    public class ProductsQuery : QueryPaggedBase<Product, DataPage<Product>>
    {
        public ProductsQuery(int pageNumber, int size = Constants.PageSizeDefault)
            : base(size, pageNumber)
        {            
        }
    }
}
