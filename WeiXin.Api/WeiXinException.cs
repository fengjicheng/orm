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
            msg.Add(40055, "不合法的按钮url域名");
            msg.Add(40056, "不合法的agentid");
            msg.Add(40057, "不合法的callbackurl");
            msg.Add(40058, "不合法的红包参数");
            msg.Add(40059, "不合法的上报地理位置标志位");
            msg.Add(40060, "设置上报地理位置标志位时没有设置callbackurl");
            msg.Add(40061, "设置应用头像失败");
            msg.Add(40062, "不合法的应用模式");
            msg.Add(40063, "红包参数为空");
            msg.Add(40064, "管理组名字已存在");
            msg.Add(40065, "不合法的管理组名字长度");
            msg.Add(40066, "不合法的部门列表");
            msg.Add(40067, "标题长度不合法");
            msg.Add(40068, "不合法的标签ID");
            msg.Add(40069, "不合法的标签ID列表");
            msg.Add(40070, "列表中所有标签（用户）ID都不合法");
            msg.Add(40071, "不合法的标签名字，标签名字已经存在");
            msg.Add(40072, "不合法的标签名字长度");
            msg.Add(40073, "不合法的openid");
            msg.Add(40074, "news消息不支持指定为高保密消息 ");
            msg.Add(40077, "不合法的预授权码 ");
            msg.Add(40078, "不合法的临时授权码 ");
            msg.Add(40079, "不合法的授权信息 ");
            msg.Add(40080, "不合法的suitesecret ");
            msg.Add(40082, "不合法的suitetoken ");
            msg.Add(40083, "不合法的suiteid ");
            msg.Add(40084, "不合法的永久授权码 ");
            msg.Add(40085, "不合法的suiteticket ");
            msg.Add(40086, "不合法的第三方应用appid ");
            msg.Add(40092, "导入文件存在不合法的内容 ");
            msg.Add(40093, "不合法的跳转target ");
            msg.Add(40094, "不合法的URL ");
            msg.Add(40095, "修改失败，并发冲突 ");
            msg.Add(40155, "请勿添加其他公众号的主页链接");
            msg.Add(41001, "缺少access_token参数 ");
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
            msg.Add(41021, "缺少suiteid");
            msg.Add(41022, "缺少suitetoken");
            msg.Add(41023, "缺少suiteticket");
            msg.Add(41024, "缺少suitesecret");
            msg.Add(41025, "缺少永久授权码");
            msg.Add(41034, "缺少login_ticket");
            msg.Add(41035, "缺少跳转target");
            msg.Add(42001, "access_token过期");
            msg.Add(42002, "refresh_token过期");
            msg.Add(42003, "oauth_code过期");
            msg.Add(42004, "插件tokeng过期");
            msg.Add(42007, "预授权码失效");
            msg.Add(42008, "临时授权码失效");
            msg.Add(42009, "suitetoken失效");
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
            msg.Add(43013, "应用对成员不可见");
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
            msg.Add(45022, "应用名字长度不合法，合法长度为2-16个字");
            msg.Add(45024, "账户数量超过上限");
            msg.Add(45025, "同一个成员每周只能邀请一次");
            msg.Add(45026, "触发删除用户数的保护");
            msg.Add(45027, "mpnews每天只能发送100次");
            msg.Add(45028, "素材数量超过上限");
            msg.Add(45029, "media_id对该应用不可见");
            msg.Add(45032, "作者名字长度超过限制");
            msg.Add(46001, "不存在媒体数据");
            msg.Add(46002, "不存在的菜单版本");
            msg.Add(46003, "不存在的菜单数据");
            msg.Add(46004, "不存在的成员");
            msg.Add(47001, "解析JSON/XML内容错误");
            msg.Add(48001, "Api未授权");
            msg.Add(48002, "Api禁用(一般是管理组类型与Api不匹配，例如普通管理组调用会话服务的Api)");
            msg.Add(48003, "suitetoken无效");
            msg.Add(48004, "授权关系无效");
            msg.Add(48005, "Api已废弃");
            msg.Add(50001, "redirect_uri未授权");
            msg.Add(50002, "员工不在权限范围");
            msg.Add(50003, "应用已停用");
            msg.Add(50004, "成员状态不正确，需要成员为企业验证中状态");
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
            msg.Add(60019, "不允许设置应用地理位置上报开关");
            msg.Add(60020, "访问ip不在白名单之中");
            msg.Add(60023, "已授权的应用不允许企业管理组调用接口修改菜单");
            msg.Add(60025, "主页型应用不支持的消息类型");
            msg.Add(60027, "不支持第三方修改主页型应用字段");
            msg.Add(60028, "应用已授权予第三方，不允许通过接口修改主页url");
            msg.Add(60029, "应用已授权予第三方，不允许通过接口修改可信域名");
            msg.Add(60031, "未设置管理组的登录授权域名");
            msg.Add(60102, "UserID已存在");
            msg.Add(60103, "手机号码不合法");
            msg.Add(60104, "手机号码不合法");
            msg.Add(60105, "邮箱不合法");
            msg.Add(60106, "邮箱已存在");
            msg.Add(60107, "微信号不合法");
            msg.Add(60108, "微信号已存在");
            msg.Add(60109, "QQ号已存在");
            msg.Add(60110, "部门个数超出限制");
            msg.Add(60111, "UserID不存在");
            msg.Add(60112, "成员姓名不合法");
            msg.Add(60113, "身份认证信息（微信号/手机/邮箱）不能同时为空");
            msg.Add(60114, "性别不合法");
            msg.Add(60115, "已关注成员微信不能修改");
            msg.Add(60116, "扩展属性已存在");
            msg.Add(60118, "成员无有效邀请字段，详情参考(邀请成员关注)的接口说明");
            msg.Add(60119, "成员已关注");
            msg.Add(60120, "成员已禁用");
            msg.Add(60121, "找不到该成员");
            msg.Add(60122, "邮箱已被外部管理员使用");
            msg.Add(60123, "无效的部门id");
            msg.Add(60124, "无效的父部门id");
            msg.Add(60125, "非法部门名字，长度超过限制、重名等，重名包括与csv文件中同级部门重名或者与旧组织架构包含成员的同级部门重名");
            msg.Add(60126, "创建部门失败");
            msg.Add(60127, "缺少部门id");
            msg.Add(60128, "字段不合法，可能存在主键冲突或者格式错误");
            msg.Add(60129, "用户设置了拒绝邀请");
            msg.Add(60131, "不合法的职位长度");
            msg.Add(80001, "可信域名不匹配，或者可信域名没有IPC备案（后续将不能在该域名下正常使用jssdk）");
            msg.Add(81003, "邀请额度已用完");
            msg.Add(81004, "部门数量超过上限");
            msg.Add(82001, "发送消息或者邀请的参数全部为空或者全部不合法");
            msg.Add(82002, "不合法的PartyID列表长度");
            msg.Add(82003, "不合法的TagID列表长度");
            msg.Add(82004, "微信版本号过低");
            msg.Add(85002, "包含不合法的词语");
            msg.Add(86001, "不合法的会话ID");
            msg.Add(86002, "不存在的会话ID");
            msg.Add(86003, "包含不合法的词语");
            msg.Add(86004, "不合法的会话名");
            msg.Add(86005, "不合法的会话管理员");
            msg.Add(86006, "不合法的成员列表大小");
            msg.Add(86007, "不存在的成员");
            msg.Add(86101, "需要会话管理员权限");
            msg.Add(86201, "缺少会话ID");
            msg.Add(86202, "缺少会话名");
            msg.Add(86203, "缺少会话管理员");
            msg.Add(86204, "缺少成员");
            msg.Add(86205, "非法的会话ID长度");
            msg.Add(86206, "非法的会话ID数值");
            msg.Add(86207, "会话管理员不在用户列表中");
            msg.Add(86208, "消息服务未开启");
            msg.Add(86209, "缺少操作者");
            msg.Add(86210, "缺少会话参数");
            msg.Add(86211, "缺少会话类型（单聊或者群聊）");
            msg.Add(86213, "缺少发件人");
            msg.Add(86214, "非法的会话类型");
            msg.Add(86215, "会话已存在");
            msg.Add(86216, "非法会话成员");
            msg.Add(86217, "会话操作者不在成员列表中");
            msg.Add(86218, "非法会话发件人");
            msg.Add(86219, "非法会话收件人");
            msg.Add(86220, "非法会话操作者");
            msg.Add(86221, "单聊模式下，发件人与收件人不能为同一人");
            msg.Add(86222, "不允许消息服务访问的API");
            msg.Add(86304, "不合法的消息类型");
            msg.Add(86305, "客服服务未启用");
            msg.Add(86306, "缺少发送人");
            msg.Add(86307, "缺少发送人类型");
            msg.Add(86308, "缺少发送人id");
            msg.Add(86309, "缺少接收人");
            msg.Add(86310, "缺少接收人类型");
            msg.Add(86311, "缺少接收人id");
            msg.Add(86312, "缺少消息类型");
            msg.Add(86313, "缺少客服，发送人或接收人类型，必须有一个为kf");
            msg.Add(86314, "客服不唯一，发送人或接收人类型，必须只有一个为k");
            msg.Add(86315, "不合法的发送人类型");
            msg.Add(86316, "不合法的发送人id。Userid不存在、openid不存在、kf不存在");
            msg.Add(86317, "不合法的接收人类型");
            msg.Add(86318, "不合法的接收人id。Userid不存在、openid不存在、kf不存在");
            msg.Add(86319, "不合法的客服，kf不在客服列表中");
            msg.Add(86320, "不合法的客服类型");
            msg.Add(88001, "缺少seq参数");
            msg.Add(88002, "缺少offset参数");
            msg.Add(88003, "非法seq");
            msg.Add(90001, "未认证摇一摇周边");
            msg.Add(90002, "缺少摇一摇周边ticket参数");
            msg.Add(90003, "摇一摇周边ticket参数不合法");
            msg.Add(90004, "摇一摇周边ticket过期");
            msg.Add(90005, "未开启摇一摇周边服务");
            msg.Add(91004, "卡券已被核销");
            msg.Add(91011, "无效的code");
            msg.Add(91014, "缺少卡券详情");
            msg.Add(91015, "代金券缺少least_cost或者reduce_cost参数");
            msg.Add(91016, "折扣券缺少discount参数");
            msg.Add(91017, "礼品券缺少gift参数");
            msg.Add(91019, "缺少卡券sku参数");
            msg.Add(91020, "缺少卡券有效期");
            msg.Add(91021, "缺少卡券有效期类型");
            msg.Add(91022, "缺少卡券logo_url");
            msg.Add(91023, "缺少卡券code类型");
            msg.Add(91025, "缺少卡券title");
            msg.Add(91026, "缺少卡券color");
            msg.Add(91027, "缺少offset参数");
            msg.Add(91028, "缺少count参数");
            msg.Add(91029, "缺少card_id");
            msg.Add(91030, "缺少卡券code");
            msg.Add(91031, "缺少卡券notice");
            msg.Add(91032, "缺少卡券description");
            msg.Add(91033, "缺少ticket类型");
            msg.Add(91036, "不合法的有效期");
            msg.Add(91038, "变更库存值不合法");
            msg.Add(91039, "不合法的卡券id");
            msg.Add(91040, "不合法的ticket type");
            msg.Add(91041, "没有创建，上传卡券logo，以及核销卡券的权限");
            msg.Add(91042, "没有该卡券投放权限");
            msg.Add(91043, "没有修改或者删除该卡券的权限");
            msg.Add(91044, "不合法的卡券参数");
            msg.Add(91045, "缺少团购券groupon结构");
            msg.Add(91046, "缺少现金券cash结构");
            msg.Add(91047, "缺少折扣券discount 结构");
            msg.Add(91048, "缺少礼品券gift结构");
            msg.Add(91049, "缺少优惠券coupon结构");
            msg.Add(91050, "缺少卡券必填字段");
            msg.Add(91051, "商户名称超过12个汉字");
            msg.Add(91052, "卡券标题超过9个汉字");
            msg.Add(91053, "卡券提醒超过16个汉字");
            msg.Add(91054, "卡券描述超过1024个汉字");
            msg.Add(91055, "卡券副标题长度超过18个汉字");
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

