using AutoMapper;
using Confirmit.NortWind.Model.DTO;
using Confirmit.NortWind.Model.Queries;
using Firmglobal.Framework.CqsDataFoundation.Query;
using Ent = NorthWind.Data.Entities;

namespace Confirmit.NorthWind.Dal.LinqToSql.MsSql.Handlers.Query
{
    public sealed class AllCategoriesQueryHandler : QueryHandlerPaggedLinqBase<NorthWindContextMgr, AllCategoriesQuery, DataPage<Category>, Category>
    {
        public AllCategoriesQueryHandler(NorthWindContextMgr context, bool sharedContext = false)
            : base(context, sharedContext)
        {
        }

        #region ICommandHandler
        public override DataPage<Category> Handle(AllCategoriesQuery q)
        {
            return GetPage(q, DbContextUser.DbContext.Categories, Mapper.Map<Ent.Category, Category>);
        }
        #endregion ICommandHandler
    }    
}
