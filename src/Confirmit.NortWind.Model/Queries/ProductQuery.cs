using System.Runtime.Serialization;
using Confirmit.NortWind.Model.DTO;
using Firmglobal.Framework.CqsDataFoundation.Query;

namespace Confirmit.NortWind.Model.Queries
{
    [DataContract(Namespace = "http://www.confirmit.ru/NorthWind")]
    public class ProductQuery : QueryBase<Product>
    {
        public ProductQuery(int id)
        {
            ProductId = id;
        }

        [DataMember(Order = 10)]
        public int ProductId { get; set; }
    }
}
