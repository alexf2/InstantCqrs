using Firmglobal.Framework.CqsDataFoundation.Query.Filtering;
using Firmglobal.Framework.CqsDataFoundation.Query.Sorting;

namespace Firmglobal.Framework.CqsDataFoundation.Query
{
    internal interface IQueryVisitor
    {
        void Visit(FilteringCollection filtering);
        void Visit(SortingCollection sorting);
        void Visit(FilteringDescriptor fd);
        void Visit(SortingDescriptor fd);
    }
}
