using System.Linq;
using AutoMapper;
using Confirmit.NortWind.Model.DTO;
using Confirmit.NortWind.Model.Queries;
using Firmglobal.Framework.CqsDataFoundation.Query;
using Ent = NorthWind.Data.Entities;

namespace Confirmit.NorthWind.Dal.LinqToSql.MsSql.Handlers.Query
{
    public sealed class ProductQueryHandler : QueryHandlerBase<NorthWindContextMgr, ProductQuery, Product>
    {
        public ProductQueryHandler(NorthWindContextMgr context, bool sharedContext = false)
            : base(context, sharedContext)
        {
        }

        #region ICommandHandler
        public override Product Handle(ProductQuery q)
        {
            return (from p in DbContextUser.DbContext.Products
                   where p.ProductID == q.ProductId
                    select Mapper.Map<Ent.Product, Product>(p)).FirstOrDefault(); 

        }
        #endregion ICommandHandler
    }
}
