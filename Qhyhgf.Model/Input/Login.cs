using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qhyhgf.Orm;
using Qhyhgf.Orm.Attribute;

namespace Qhyhgf.Model.Input
{
    [Table(TableName= "Login")]
    public class Login: BaseEntity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set;}
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
    }
}
