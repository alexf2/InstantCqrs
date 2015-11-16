using System;

namespace Firmglobal.Framework.CqsDataFoundation.Query
{
    public interface IQueryHandler<in TQuery, out TResult> : IDisposable where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery q);

        IDataContext DbContext
        {
            get;
        }
    }
}
