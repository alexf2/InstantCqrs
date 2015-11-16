using Firmglobal.Framework.Cqs.LinqToSqlDbContext.MsSql;
using Firmglobal.Framework.CqsDataFoundation;
using NorthWind.Data;

namespace Confirmit.NorthWind.Dal.LinqToSql.MsSql
{
    public sealed class NorthWindContextMgr : LinqToSqlDbContextMgr<NorthWindDataContext>
    {
        public NorthWindContextMgr(IDbContextConfig cfg)
            : base(cfg)
        {
        }

        #region DbContextBase overrides
        protected override NorthWindDataContext CreateDbContext(IDbContextConfig cfg)
        {
            return new NorthWindDataContext(cfg.DefaultConnectionString);
        }
        #endregion DbContextBase overrides
    }
}
