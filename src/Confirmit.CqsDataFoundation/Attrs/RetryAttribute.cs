using System;

namespace Firmglobal.Framework.CqsDataFoundation.Attrs
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class RetryAttribute : Attribute
    {
    }
}
