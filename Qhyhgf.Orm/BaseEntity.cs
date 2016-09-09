using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qhyhgf.Orm
{
    /// <summary>
    /// model基类
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid Uid { get; set; }
    }
}
