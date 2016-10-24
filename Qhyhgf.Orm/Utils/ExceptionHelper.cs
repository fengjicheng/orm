using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm.Utils
{
    internal static class ExceptionHelper
    {
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Method may not be used in every assembly it is imported into")]
        internal static ArgumentException CreateArgumentNullOrEmptyException(string paramName)
        {
            return new ArgumentException("Argument_Cannot_Be_Null_Or_Empty", paramName);
        }
    }
}
