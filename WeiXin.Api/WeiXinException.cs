﻿using System;
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
            msg.Add(-1, "系统繁忙;说明:服务器暂不可用，建议稍候重试。建议重试次数不超过3次。");
            msg.Add(0, "请求成功;说明:接口调用成功");
            msg.Add(40001, "不合法的secret参数;说明:secret在应用详情/通讯录管理助手可查看");
            msg.Add(40003, "无效的UserID;说明:-");
            msg.Add(40004, "不合法的媒体文件类型;说明:不满足系统文件要求。参考：上传的媒体文件限制");
            msg.Add(40005, "不合法的type参数;说明:合法的type取值，参考：上传临时素材");
            msg.Add(40006, "不合法的文件大小;说明:系统文件要求，参考：上传的媒体文件限制");
            msg.Add(40007, "不合法的media_id参数;说明:-");
            msg.Add(40008, "不合法的msgtype参数;说明:合法的msgtype取值，参考：消息类型");
            msg.Add(40009, "上传图片大小不是有效值;说明:图片大小的系统限制，参考上传的媒体文件限制");
            msg.Add(40011, "上传视频大小不是有效值;说明:视频大小的系统限制，参考上传的媒体文件限制");
            msg.Add(40013, "不合法的CorpID;说明:需确认CorpID是否填写正确，在 web管理端-设置 可查看");
            msg.Add(40014, "不合法的access_token;说明:-");
            msg.Add(40016, "不合法的按钮个数;说明:菜单按钮1-3个");
            msg.Add(40017, "不合法的按钮类型;说明:支持的类型，参考：按钮类型");
            msg.Add(40018, "不合法的按钮名字长度;说明:长度应不超过16个字节");
            msg.Add(40019, "不合法的按钮KEY长度;说明:长度应不超过128字节");
            msg.Add(40020, "不合法的按钮URL长度;说明:长度应不超过1024字节");
            msg.Add(40022, "不合法的子菜单级数;说明:只能包含一级菜单和二级菜单");
            msg.Add(40023, "不合法的子菜单按钮个数;说明:子菜单按钮1-5个");
            msg.Add(40024, "不合法的子菜单按钮类型;说明:支持的类型，参考：按钮类型");
            msg.Add(40025, "不合法的子菜单按钮名字长度;说明:支持的类型，参考：按钮类型");
            msg.Add(40026, "不合法的子菜单按钮KEY长度;说明:长度应不超过60个字节");
            msg.Add(40027, "不合法的子菜单按钮URL长度;说明:长度应不超过1024字节");
            msg.Add(40029, "不合法的oauth_code;说明:-");
            msg.Add(40031, "不合法的UserID列表;说明:指定的UserID列表，至少存在一个UserID不在通讯录中");
            msg.Add(40032, "不合法的UserID列表长度;说明:-");
            msg.Add(40033, "不合法的请求字符;说明:不能包含\\uxxxx格式的字符");
            msg.Add(40035, "不合法的参数;说明:-");
            msg.Add(40050, "chatid不存在;说明:会话需要先创建后，才可修改会话详情或者发起聊天");
            msg.Add(40054, "不合法的子菜单url域名;说明:-");
            msg.Add(40055, "不合法的菜单url域名;说明:-");
            msg.Add(40056, "不合法的agentid;说明:-");
            msg.Add(40057, "不合法的callbackurl或者callbackurl验证失败;说明:可自助到开发调试工具重现");
            msg.Add(40058, "不合法的参数;说明:传递参数不符合系统要求，需要参照具体API接口说明");
            msg.Add(40059, "不合法的上报地理位置标志位;说明:开关标志位只能填 0 或者 1");
            msg.Add(40063, "参数为空;说明:-");
            msg.Add(40066, "不合法的部门列表;说明:部门列表为空，或者至少存在一个部门ID不存在于通讯录中");
            msg.Add(40068, "不合法的标签ID;说明:标签ID未指定，或者指定的标签ID不存在");
            msg.Add(40070, "指定的标签范围结点全部无效;说明:-");
            msg.Add(40071, "不合法的标签名字;说明:标签名字已经存在");
            msg.Add(40072, "不合法的标签名字长度;说明:不允许为空，最大长度限制为32个字（汉字或英文字母）");
            msg.Add(40073, "不合法的openid;说明:openid不存在，需确认获取来源");
            msg.Add(40074, "news消息不支持保密消息类型;说明:图文消息支持保密类型需改用mpnews");
            msg.Add(40077, "不合法的pre_auth_code参数;说明:预授权码不存在，参考：获取预授权码");
            msg.Add(40078, "不合法的auth_code参数;说明:需确认获取来源，并且只能消费一次");
            msg.Add(40080, "不合法的suite_secret;说明:套件secret可在第三方管理端套件详情查看");
            msg.Add(40082, "不合法的suite_token;说明:-");
            msg.Add(40083, "不合法的suite_id;说明:suite_id不存在");
            msg.Add(40084, "不合法的permanent_code参数;说明:-");
            msg.Add(40085, "不合法的的suite_ticket参数;说明:suite_ticket不存在或者已失效");
            msg.Add(40086, "不合法的第三方应用appid;说明:至少有一个不存在应用id");
            msg.Add(40088, "jobid不存在;说明:请检查 jobid 来源");
            msg.Add(40089, "批量任务的结果已清理;说明:系统仅保存最近5次批量任务的结果。可在通讯录查看实际导入情况");
            msg.Add(40091, "secret不合法;说明:可能用了别的企业的secret");
            msg.Add(40092, "导入文件存在不合法的内容;说明:-");
            msg.Add(40093, "不合法的jsapi_ticket参数;说明:ticket已失效，或者拼写错误");
            msg.Add(40094, "不合法的URL;说明:缺少主页URL参数，或者URL不合法（链接需要带上协议头，以 http:// 或者 https:// 开头）");
            msg.Add(40096, "不合法的外部联系人userid;说明:-");
            msg.Add(40097, "该成员尚未离职;说明:离职成员外部联系人转移接口要求转出用户必须已经离职");
            msg.Add(40098, "接替成员尚未实名认证;说明:离职成员外部联系人转移接口要求接替成员已实名认证");
            msg.Add(40099, "接替成员的外部联系人数量已达上限;说明:-");
            msg.Add(40100, "此用户的外部联系人已经在转移流程中;说明:-");
            msg.Add(41001, "缺少access_token参数;说明:-");
            msg.Add(41002, "缺少corpid参数;说明:-");
            msg.Add(41004, "缺少secret参数;说明:-");
            msg.Add(41006, "缺少media_id参数;说明:media_id为调用接口必填参数，请确认是否有传递");
            msg.Add(41008, "缺少auth code参数;说明:-");
            msg.Add(41009, "缺少userid参数;说明:-");
            msg.Add(41010, "缺少url参数;说明:-");
            msg.Add(41011, "缺少agentid参数;说明:-");
            msg.Add(41033, "缺少 description 参数;说明:发送文本卡片消息接口，description 是必填字段");
            msg.Add(41035, "缺少外部联系人userid参数;说明:-");
            msg.Add(41016, "缺少title参数;说明:发送图文消息，标题是必填参数。请确认参数是否有传递。");
            msg.Add(41019, "缺少 department 参数;说明:-");
            msg.Add(41017, "缺少tagid参数;说明:-");
            msg.Add(41021, "缺少suite_id参数;说明:-");
            msg.Add(41022, "缺少suite_access_token参数;说明:-");
            msg.Add(41023, "缺少suite_ticket参数;说明:-");
            msg.Add(41024, "缺少secret参数;说明:-");
            msg.Add(41025, "缺少permanent_code参数;说明:-");
            msg.Add(42001, "access_token已过期;说明:access_token有时效性，需要重新获取一次");
            msg.Add(42007, "pre_auth_code已过期;说明:pre_auth_code有时效性，需要重新获取一次");
            msg.Add(42009, "suite_access_token已过期;说明:suite_access_token有时效性，需要重新获取一次");
            msg.Add(43004, "指定的userid未绑定微信或未关注微工作台（原企业号）;说明:需要成员使用微信登录企业微信或者关注微工作台才能获取openid");
            msg.Add(44001, "多媒体文件为空;说明:上传格式参考：上传临时素材，确认header和body的内容正确。");
            msg.Add(44004, "文本消息content参数为空;说明:发文本消息content为必填参数，且不能为空");
            msg.Add(45001, "多媒体文件大小超过限制;说明:图片不可超过5M；音频不可超过5M；文件不可超过20M");
            msg.Add(45002, "消息内容大小超过限制;说明:-");
            msg.Add(45004, "应用description参数长度不符合系统限制;说明:设置应用若带有description参数，则长度必须为4至120个字符");
            msg.Add(45007, "语音播放时间超过限制;说明:语音播放时长不能超过60秒");
            msg.Add(45008, "图文消息的文章数量不符合系统限制;说明:图文消息的文章数量不能超过8条");
            msg.Add(45009, "接口调用超过限制;说明:-");
            msg.Add(45022, "应用name参数长度不符合系统限制;说明:设置应用若带有name参数，则不允许为空，且不超过32个字符");
            msg.Add(45024, "帐号数量超过上限;说明:-");
            msg.Add(45026, "触发删除用户数的保护;说明:限制参考：全量覆盖成员");
            msg.Add(45032, "图文消息author参数长度超过限制;说明:最长64个字节");
            msg.Add(45033, "接口并发调用超过限制;说明:-");
            msg.Add(46003, "菜单未设置;说明:菜单需发布后才能获取到数据");
            msg.Add(46004, "指定的用户不存在;说明:需要确认指定的用户存在于通讯录中");
            msg.Add(48002, "API接口无权限调用;说明:-");
            msg.Add(48003, "不合法的suite_id;说明:确认suite_access_token由指定的suite_id生成");
            msg.Add(48004, "授权关系无效;说明:可能是无授权或授权已被取消");
            msg.Add(48005, "API接口已废弃;说明:接口已不再支持，建议改用新接口或者新方案");
            msg.Add(50001, "redirect_url未登记可信域名;说明:-");
            msg.Add(50002, "成员不在权限范围;说明:请检查应用或管理组的权限范围");
            msg.Add(50003, "应用已禁用;说明:禁用的应用无法使用API接口。可在”管理端-企业应用”启用应用");
            msg.Add(60001, "部门长度不符合限制;说明:部门名称不能为空且长度不能超过32个字");
            msg.Add(60003, "部门ID不存在;说明:需要确认部门ID是否有带，并且存在通讯录中");
            msg.Add(60004, "父部门不存在;说明:需要确认父亲部门ID是否有带，并且存在通讯录中");
            msg.Add(60005, "部门下存在成员;说明:不允许删除有成员的部门");
            msg.Add(60006, "部门下存在子部门;说明:不允许删除有子部门的部门");
            msg.Add(60007, "不允许删除根部门;说明:-");
            msg.Add(60008, "部门已存在;说明:部门ID或者部门名称已存在");
            msg.Add(60009, "部门名称含有非法字符;说明:不能含有 \\:?*“<>| 等字符");
            msg.Add(60010, "部门存在循环关系;说明:-");
            msg.Add(60011, "指定的成员/部门/标签参数无权限;说明:-");
            msg.Add(60012, "不允许删除默认应用;说明:默认应用的id为0");
            msg.Add(60020, "访问ip不在白名单之中;说明:请确认访问ip是否在服务商白名单IP列表");
            msg.Add(60028, "不允许修改第三方应用的主页 URL;说明:第三方应用类型，不允许通过接口修改该应用的主页 URL");
            msg.Add(60102, "UserID已存在;说明:-");
            msg.Add(60103, "手机号码不合法;说明:长度不超过32位，字符仅支持数字，加号和减号");
            msg.Add(60104, "手机号码已存在;说明:同一个企业内，成员的手机号不能重复。建议更换手机号，或者更新已有的手机记录。");
            msg.Add(60105, "邮箱不合法;说明:长度不超过64位，且为有效的email格式");
            msg.Add(60106, "邮箱已存在;说明:同一个企业内，成员的邮箱不能重复。建议更换邮箱，或者更新已有的邮箱记录。");
            msg.Add(60107, "微信号不合法;说明:微信号格式由字母、数字、”-“、”_“组成，长度为 3-20 字节，首字符必须是字母或”-“或”_“");
            msg.Add(60110, "用户所属部门数量超过限制;说明:用户同时归属部门不超过20个");
            msg.Add(60111, "UserID不存在;说明:UserID参数为空，或者不存在通讯录中");
            msg.Add(60112, "成员name参数不合法;说明:不能为空，且不能超过64字符");
            msg.Add(60123, "无效的部门id;说明:部门不存在通讯录中");
            msg.Add(60124, "无效的父部门id;说明:父部门不存在通讯录中");
            msg.Add(60125, "非法部门名字;说明:不能为空，且不能超过64字节，且不能含有\\:*?”<>|等字符");
            msg.Add(60127, "缺少department参数;说明:-");
            msg.Add(60129, "成员手机和邮箱都为空;说明:成员手机和邮箱至少有个非空");
            msg.Add(72023, "发票已被其他公众号锁定;说明:-");
            msg.Add(72024, "发票状态错误;说明:reimburse_status状态错误，参考：更新发票状态");
            msg.Add(72037, "存在发票不属于该用户;说明:只能批量更新该openid的发票，参考：批量更新发票状态");
            msg.Add(80001, "可信域名不正确，或者无ICP备案;说明:-");
            msg.Add(81001, "部门下的结点数超过限制（3W）;说明:-");
            msg.Add(81002, "部门最多15层;说明:-");
            msg.Add(81011, "无权限操作标签;说明:-");
            msg.Add(81013, "UserID、部门ID、标签ID全部非法或无权限;说明:-");
            msg.Add(81014, "标签添加成员，单次添加user或party过多;说明:-");
            msg.Add(82001, "指定的成员/部门/标签全部无效;说明:-");
            msg.Add(82002, "不合法的PartyID列表长度;说明:发消息，单次不能超过100个部门");
            msg.Add(82003, "不合法的TagID列表长度;说明:发消息，单次不能超过100个标签");
            msg.Add(84014, "成员票据过期;说明:-");
            msg.Add(84015, "成员票据无效;说明:确认user_ticket参数来源是否正确。参考接口：根据code获取成员信息");
            msg.Add(84019, "缺少templateid参数;说明:-");
            msg.Add(84020, "templateid不存在;说明:确认参数是否有带，并且已创建");
            msg.Add(84021, "缺少register_code参数;说明:-");
            msg.Add(84022, "无效的register_code参数;说明:-");
            msg.Add(84023, "不允许调用设置通讯录同步完成接口;说明:-");
            msg.Add(84024, "无注册信息;说明:-");
            msg.Add(84025, "不符合的state参数;说明:必须是[a-zA-Z0-9]的参数值，长度不可超过128个字节");
            msg.Add(84052, "缺少caller参数;说明:-");
            msg.Add(84053, "缺少callee参数;说明:-");
            msg.Add(84054, "缺少auth_corpid参数;说明:-");
            msg.Add(84055, "超过拨打公费电话频率;说明:同一个客服5秒内只能调用api拨打一次公费电话");
            msg.Add(84056, "被拨打用户安装应用时未授权拨打公费电话权限;说明:-");
            msg.Add(84057, "公费电话余额不足;说明:-");
            msg.Add(84058, "caller 呼叫号码不支持;说明:-");
            msg.Add(84059, "号码非法;说明:-");
            msg.Add(84060, "callee 呼叫号码不支持;说明:-");
            msg.Add(84061, "不存在外部联系人的关系;说明:-");
            msg.Add(84062, "未开启公费电话应用;说明:-");
            msg.Add(84063, "caller不存在;说明:-");
            msg.Add(84064, "callee不存在;说明:-");
            msg.Add(84065, "caller跟callee电话号码一致;说明:不允许自己拨打给自己");
            msg.Add(84066, "服务商拨打次数超过限制;说明:单个企业管理员，在一天（以上午10:00为起始时间）内，对应单个服务商，只能被呼叫【4】次。");
            msg.Add(84067, "管理员收到的服务商公费电话个数超过限制;说明:单个企业管理员，在一天（以上午10:00为起始时间）内，一共只能被【3】个服务商成功呼叫。");
            msg.Add(84071, "不合法的外部联系人授权码;说明:非法或者已经消费过");
            msg.Add(84072, "应用未配置客服;说明:-");
            msg.Add(84073, "客服userid不在应用配置的客服列表中;说明:-");
            msg.Add(84074, "没有外部联系人权限;说明:-");
            msg.Add(85002, "包含不合法的词语;说明:-");
            msg.Add(85004, "每企业每个月设置的可信域名不可超过20个;说明:-");
            msg.Add(85005, "可信域名未通过所有权校验;说明:-");
            msg.Add(86001, "参数 chatid 不合法;说明:-");
            msg.Add(86003, "参数 chatid 不存在;说明:-");
            msg.Add(86004, "参数 群名不合法;说明:-");
            msg.Add(86005, "参数 群主不合法;说明:-");
            msg.Add(86006, "群成员数过多或过少;说明:-");
            msg.Add(86007, "不合法的群成员;说明:-");
            msg.Add(86008, "非法操作非自己创建的群;说明:-");
            msg.Add(86101, "仅群主才有操作权限;说明:-");
            msg.Add(86201, "参数 需要chatid;说明:-");
            msg.Add(86202, "参数 需要群名;说明:-");
            msg.Add(86203, "参数 需要群主;说明:-");
            msg.Add(86204, "参数 需要群成员;说明:-");
            msg.Add(86205, "参数 字符串chatid过长;说明:-");
            msg.Add(86206, "参数 数字chatid过大;说明:-");
            msg.Add(86207, "群主不在群成员列表;说明:-");
            msg.Add(86215, "会话ID已经存在;说明:-");
            msg.Add(86216, "存在非法会话成员ID;说明:-");
            msg.Add(86217, "会话发送者不在会话成员列表中;说明:会话的发送者，必须是会话的成员列表之一");
            msg.Add(86220, "指定的会话参数不合法;说明:-");
            msg.Add(90001, "未认证摇一摇周边;说明:-");
            msg.Add(90002, "缺少摇一摇周边ticket参数;说明:-");
            msg.Add(90003, "摇一摇周边ticket参数不合法;说明:-");
            msg.Add(90100, "非法的对外属性类型;说明:-");
            msg.Add(90101, "对外属性：文本类型长度不合法;说明:文本长度不可超过12个UTF8字符");
            msg.Add(90102, "对外属性：网页类型标题长度不合法;说明:标题长度不可超过12个UTF8字符");
            msg.Add(90103, "对外属性：网页url不合法;说明:-");
            msg.Add(90104, "对外属性：小程序类型标题长度不合法;说明:标题长度不可超过12个UTF8字符");
            msg.Add(90105, "对外属性：小程序类型pagepath不合法;说明:-");
            msg.Add(90106, "对外属性：请求参数不合法;说明:-");
            msg.Add(91040, "获取ticket的类型无效;说明:-");
            msg.Add(301002, "无权限操作指定的应用;说明:-");
            msg.Add(301005, "不允许删除创建者;说明:创建者不允许从通讯录中删除。如果需要删除该成员，需要先在WEB管理端转移创建者身份。");
            msg.Add(301012, "参数 position 不合法;说明:长度不允许超过128个字符");
            msg.Add(301013, "参数 telephone 不合法;说明:telephone必须由1-32位的纯数字或’-‘号组成。");
            msg.Add(301014, "参数 english_name 不合法;说明:参数如果有传递，不允许为空字符串，同时不能超过64字节，只能是由字母、数字、点(.)、减号(-)、空格或下划线(_)组成");
            msg.Add(301015, "参数 mediaid 不合法;说明:请检查 mediaid 来源，应该通过上传临时素材的图片类型获得mediaid");
            msg.Add(301016, "上传语音文件不符合系统要求;说明:语音文件的系统限制，参考上传的媒体文件限制");
            msg.Add(301017, "上传语音文件仅支持AMR格式;说明:语音文件的系统限制，参考上传的媒体文件限制");
            msg.Add(301021, "参数 userid 无效;说明:至少有一个userid不存在于通讯录中");
            msg.Add(301022, "获取打卡数据失败;说明:系统失败，可重试处理");
            msg.Add(301023, "useridlist非法或超过限额;说明:列表数量不能为0且不超过100");
            msg.Add(301024, "获取打卡记录时间间隔超限;说明:保证开始时间大于0 且结束时间大于 0 且结束时间大于开始时间，且间隔少于93天");
            msg.Add(301036, "不允许更新该用户的userid;说明:-");
            msg.Add(302003, "批量导入任务的文件中userid有重复;说明:-");
            msg.Add(302004, "组织架构不合法（1不是一棵树，2 多个一样的partyid，3 partyid空，4 partyid name 空，5 同一个父节点下有两个子节点 部门名字一样 可能是以上情况，请一一排查）;说明:-");
            msg.Add(302005, "批量导入系统失败，请重新尝试导入;说明:-");
            msg.Add(302006, "批量导入任务的文件中partyid有重复;说明:-");
            msg.Add(302007, "批量导入任务的文件中，同一个部门下有两个子部门名字一样;说明:-");
            msg.Add(2000002, "CorpId参数无效;说明:指定的CorpId不存在");

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

