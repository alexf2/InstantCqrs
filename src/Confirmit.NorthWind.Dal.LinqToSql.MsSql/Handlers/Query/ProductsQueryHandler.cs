using AutoMapper;
using Confirmit.NortWind.Model.DTO;
using Confirmit.NortWind.Model.Queries;
using Firmglobal.Framework.CqsDataFoundation.Query;
using Ent = NorthWind.Data.Entities;

namespace Confirmit.NorthWind.Dal.LinqToSql.MsSql.Handlers.Query
{
    public sealed class ProductsQueryHandler : QueryHandlerPaggedLinqBase<NorthWindContextMgr, ProductsQuery, DataPage<Product>, Product>
    {
        public ProductsQueryHandler(NorthWindContextMgr context, bool sharedContext = false)
            : base(context, sharedContext)
        {
        }

        #region ICommandHandler
        public override DataPage<Product> Handle(ProductsQuery q)
        {
            return GetPage(q, DbContextUser.DbContext.Products, Mapper.Map<Ent.Product, Product>);
        }
        #endregion ICommandHandler
    }
}
