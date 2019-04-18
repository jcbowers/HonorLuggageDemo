using System;
using System.Collections.Generic;

namespace HonorLuggage.Domain.Core
{
    public class BusinessException : Exception
    {
        internal BusinessException() => Reasons = new string[] { };

        internal BusinessException(IEnumerable<string> reasons) => Reasons = reasons;

        internal BusinessException(string reason) => Reasons = new[] { reason };

        public IEnumerable<string> Reasons { get; internal set; }
    }
}
