using System;
using System.Data;

namespace Firmglobal.Framework.CqsDataFoundation.Attrs
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class TransactionAttribute : Attribute
    {
        public TransactionAttribute(IsolationLevel lvl = IsolationLevel.ReadCommitted)
        {
            Level = lvl;
        }

        public IsolationLevel Level
        {
            get;
            private set;
        }
    }
}
