using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api
{
    #region 错误代码转换类;
    internal  class ErrcodeConvert
    {
        private readonly static IDictionary<long, string> msg = new Dictionary<long, string>();
        public  ErrcodeConvert()
        {
            #region 错误编码
            msg.Clear();
            msg.Add(-1, "系统繁忙");
            msg.Add(0, "请求成功");
            msg.Add(40001, "获取access_token时AppSecret错误，或者access_token无效");
            msg.Add(40002, "不合法的凭证类型");
            msg.Add(40003, "不合法的OpenID");
            msg.Add(40004, "不合法的媒体文件类型");
            msg.Add(40005, "不合法的文件类型");
            msg.Add(40006, "不合法的文件大小");
            msg.Add(40007, "不合法的媒体文件id");
            msg.Add(40008, "不合法的消息类型");
            msg.Add(40009, "不合法的图片文件大小");
            msg.Add(40013, "不合法的corpid");
            msg.Add(40014, "不合法的access_token");
            msg.Add(40015, "不合法的菜单类型");
            msg.Add(40016, "不合法的按钮个数");
            msg.Add(40017, "不合法的按钮类型");
            msg.Add(40018, "不合法的按钮名字长度");
            msg.Add(40019, "不合法的按钮KEY长度");
            msg.Add(40020, "不合法的按钮URL长度");
            msg.Add(40021, "不合法的菜单版本号");
            msg.Add(40022, "不合法的子菜单级数");
            msg.Add(40023, "不不合法的子菜单按钮个数");
            msg.Add(40024, "不合法的子菜单按钮类型");
            msg.Add(40025, "不合法的子菜单按钮名字长度");
            msg.Add(40026, "不合法的子菜单按钮KEY长度");
            msg.Add(40027, "不合法的子菜单按钮URL长度");
            msg.Add(40028, "不合法的自定义菜单使用员工");
            msg.Add(40029, "不合法的oauth_code");
            msg.Add(40031, "不合法的UserID列表");
            msg.Add(40032, "不合法的UserID列表长度");
            msg.Add(40033, "不合法的请求字符，不能包含\\uxxxx格式的字符");
            msg.Add(40035, "不合法的参数");
            msg.Add(40038, "不合法的请求格式");
            msg.Add(40039, "不合法的URL长度");
            msg.Add(40040, "不合法的插件token");
            msg.Add(40041, "不合法的插件id");
            msg.Add(40042, "不合法的插件会话");
            msg.Add(40048, "url中包含不合法domain");
            msg.Add(40054, "不合法的子菜单url域名");
            msg.Add(41055, "不合法的按钮url域名");
            msg.Add(41056, "不合法的agentid");
            msg.Add(41057, "不合法的callbackurl");
            msg.Add(41058, "不合法的红包参数");
            msg.Add(41059, "不合法的上报地理位置标志位");
            msg.Add(41060, "设置上报地理位置标志位时没有设置callbackurl");
            msg.Add(41061, "设置应用头像失败");
            msg.Add(41062, "不合法的应用模式");
            msg.Add(41063, "红包参数为空");
            msg.Add(41064, "管理组名字已存在");
            msg.Add(41065, "不合法的管理组名字长度");
            msg.Add(41066, "不合法的部门列表");
            msg.Add(41067, "标题长度不合法");
            msg.Add(41068, "不合法的标签ID");
            msg.Add(41069, "不合法的标签ID列表");
            msg.Add(41070, "列表中所有标签（用户）ID都不合法");
            msg.Add(41071, "不合法的标签名字，标签名字已经存在");
            msg.Add(41072, "不合法的标签名字长度");
            msg.Add(41073, "不合法的openid");
            msg.Add(41074, "news消息不支持指定为高保密消息 ");
            msg.Add(41001, "缺少refresh_token参数 ");
            msg.Add(41002, "缺少corpid参数");
            msg.Add(41003, "缺少refresh_token参数");
            msg.Add(41004, "缺少secret参数");
            msg.Add(41005, "缺少多媒体文件数据");
            msg.Add(41006, "缺少media_id参数");
            msg.Add(41007, "缺少子菜单数据");
            msg.Add(41008, "缺少oauth code");
            msg.Add(41009, "缺少Userid");
            msg.Add(41010, "缺少url");
            msg.Add(41011, "缺少agentid");
            msg.Add(41012, "缺少应用头像mediaid");
            msg.Add(41013, "缺少应用名字");
            msg.Add(41014, "缺少应用描述");
            msg.Add(41015, "缺少Content");
            msg.Add(41016, "缺少标题");
            msg.Add(41017, "缺少标签ID");
            msg.Add(41018, "缺少标签名字");
            msg.Add(42001, "access_token超时");
            msg.Add(42002, "refresh_token超时");
            msg.Add(42003, "oauth_code超时");
            msg.Add(42004, "插件token超时");
            msg.Add(43001, "需要GET请求");
            msg.Add(43002, "需要POST请求");
            msg.Add(43003, "需要HTTPS请求");
            msg.Add(43004, "需要接收者关注");
            msg.Add(43005, "需要好友关系");
            msg.Add(43006, "需要订阅");
            msg.Add(43007, "需要授权");
            msg.Add(43008, "需要支付授权");
            msg.Add(43009, "需要员工已关注");
            msg.Add(43010, "需要员工已关注");
            msg.Add(43011, "需要企业授权");
            msg.Add(44001, "多媒体文件为空");
            msg.Add(44002, "POST的数据包为空");
            msg.Add(44003, "图文消息内容为空");
            msg.Add(44004, "文本消息内容为空");
            msg.Add(45001, "多媒体文件大小超过限制");
            msg.Add(45002, "消息内容超过限制");
            msg.Add(45003, "标题字段超过限制");
            msg.Add(45004, "描述字段超过限制");
            msg.Add(45005, "链接字段超过限制");
            msg.Add(45006, "图片链接字段超过限制");
            msg.Add(45007, "语音播放时间超过限制");
            msg.Add(45008, "图文消息超过限制");
            msg.Add(45009, "接口调用超过限制");
            msg.Add(45010, "创建菜单个数超过限制");
            msg.Add(45015, "回复时间超过限制");
            msg.Add(45016, "系统分组，不允许修改");
            msg.Add(45017, "分组名字过长");
            msg.Add(45018, "分组数量超过上限");
            msg.Add(45024, "账户数量超过上限");
            msg.Add(46001, "不存在媒体数据");
            msg.Add(46002, "不存在的菜单版本");
            msg.Add(46003, "不存在的菜单数据");
            msg.Add(46004, "不存在的用户");
            msg.Add(47001, "解析JSON/XML内容错误");
            msg.Add(48002, "api功能未授权");
            msg.Add(50001, "redirect_uri未授权");
            msg.Add(50002, "员工不在权限范围");
            msg.Add(50003, "应用已停用");
            msg.Add(50004, "员工状态不正确（未关注状态）");
            msg.Add(50005, "企业已禁用");
            msg.Add(60001, "部门长度不符合限制");
            msg.Add(60002, "部门层级深度超过限制");
            msg.Add(60003, "部门不存在");
            msg.Add(60004, "父亲部门不存在");
            msg.Add(60005, "不允许删除有成员的部门");
            msg.Add(60006, "不允许删除有子部门的部门 ");
            msg.Add(60007, "不允许删除根部门");
            msg.Add(60008, "部门名称已存在");
            msg.Add(60009, "部门名称含有非法字符");
            msg.Add(60010, "部门存在循环关系");
            msg.Add(60011, "管理员权限不足，（user/department/agent）无权限  ");
            msg.Add(60012, "不允许删除默认应用");
            msg.Add(60013, "不允许关闭应用");
            msg.Add(60014, "不允许开启应用");
            msg.Add(60015, "不允许修改默认应用可见范围");
            msg.Add(60016, "不允许删除存在成员的标签");
            msg.Add(60017, "不允许设置企业");
            msg.Add(60102, "UserID已存在");
            msg.Add(60103, "手机号码不合法");
            msg.Add(60104, "手机号码不合法");
            msg.Add(60105, "不邮箱不合法");
            msg.Add(60106, "邮箱已存在");
            msg.Add(60107, "微信号不合法");
            msg.Add(60108, "微信号已存在");
            msg.Add(60109, "QQ号已存在");
            msg.Add(60110, "部门个数超出限制");
            msg.Add(60111, "UserID不存在");
            msg.Add(60112, "成员姓名不合法");
            msg.Add(60113, "身份认证信息（微信号/手机/邮箱）不能同时为空");
            msg.Add(60114, "性别不合法");
            #endregion
        }
        /// <summary>
        /// 索引
        /// </summary>
        /// <param name="code"></param>
        /// <returns>错误信息</returns>
        public string this[long code]
        {
            get
            {
                if (msg.ContainsKey(code))
                {
                    return msg[code];
                }
                else
                {
                    return "暂无错误此信息！";
                }
            }
        }
    }
    #endregion
    /// <summary>
    /// 微信异常类
    /// </summary>
    public class WeiXinException: Exception
    {
        private long errorCode;
        private string errorMsg;
        private ErrcodeConvert errcodeConvert = new ErrcodeConvert();

        public WeiXinException() : base()
        {
        }

        public WeiXinException(string message)
            : base(message)
        {
        }

        protected WeiXinException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public WeiXinException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public WeiXinException(long errorCode) 
        {
            this.errorCode = errorCode;
            this.errorMsg = errcodeConvert[errorCode];
            base.Source = string.Format("微信请求发生错误！错误代码：{0}，说明：{1}", errorCode, errorMsg);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
        /// <summary>
        /// 序列化
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.Source;
        }
        public long ErrorCode
        {
            get { return this.errorCode; }
        }

        public string ErrorMsg
        {
            get { return this.errorMsg; }
        }
    }
    }

