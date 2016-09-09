using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Qhyhgf.WeiXin.Qy.Api.Domain
{
    /// <summary>
    /// 事件
    /// </summary>
    [Flags]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventType : int
    {
        /// <summary>
        /// 订阅
        /// </summary>
        [EnumMember(Value = "subscribe")]
        Subscribe = 1 << 0,
        /// <summary>
        /// 取消订阅
        /// </summary>
        [EnumMember(Value = "unsubscribe")]
        Unsubscribe = 1 << 1,
        /// <summary>
        /// 上报地理位置事件
        /// </summary>
       [EnumMember(Value = "location")]
        Location = 1 << 2,
        /// <summary>
        /// 点击菜单拉取消息的事件推送
        /// 用户点击click类型按钮后，微信服务器会通过消息接口推送消息类型为event	的结构给开发者（参考消息接口指南），并且带上按钮中开发者填写的key值，开发者可以通过自定义的key值与用户进行交互；
        /// </summary>
        [EnumMember(Value = "click")]
        Click = 1 << 3,
        /// <summary>
        /// 点击菜单跳转链接的事件推送
        /// 用户点击view类型按钮后，微信客户端将会打开开发者在按钮中填写的网页URL，可与网页授权获取用户基本信息接口结合，获得用户基本信息。
        /// </summary>
        [EnumMember(Value = "view")]
        View = 1 << 4,
        /// <summary>
        /// 扫码推事件的事件推送
        /// 用户点击按钮后，微信客户端将调起扫一扫工具，完成扫码操作后显示扫描结果（如果是URL，将进入URL），且会将扫码的结果传给开发者，开发者可以下发消息。
        /// </summary>
        [EnumMember(Value = "scancode_push")]
        Scancode_Push = 1 << 5,
        /// <summary>
        /// 扫码推事件且弹出“消息接收中”提示框的事件推送
        /// 用户点击按钮后，微信客户端将调起扫一扫工具，完成扫码操作后，将扫码的结果传给开发者，同时收起扫一扫工具，然后弹出“消息接收中”提示框，随后可能会收到开发者下发的消息。
        /// </summary>
        [EnumMember(Value = "scancode_waitmsg")]
        Scancode_Waitmsg = 1 << 6,
        /// <summary>
        /// 弹出系统拍照发图的事件推送
        /// 用户点击按钮后，微信客户端将调起系统相机，完成拍照操作后，会将拍摄的相片发送给开发者，并推送事件给开发者，同时收起系统相机，随后可能会收到开发者下发的消息。
        /// </summary>
        [EnumMember(Value = "pic_sysphoto")]
        Pic_Sysphoto = 1 << 7,
        /// <summary>
        /// 弹出拍照或者相册发图的事件推送
        /// 用户点击按钮后，微信客户端将弹出选择器供用户选择“拍照”或者“从手机相册选择”。用户选择后即走其他两种流程。
        /// </summary>
        [EnumMember(Value = "pic_photo_or_album")]
        Pic_Photo_Or_Album = 1 << 8,
        /// <summary>
        /// 弹出微信相册发图器的事件推送
        /// 用户点击按钮后，微信客户端将调起微信相册，完成选择操作后，将选择的相片发送给开发者的服务器，并推送事件给开发者，同时收起相册，随后可能会收到开发者下发的消息。
        /// </summary>
        [EnumMember(Value = "pic_weixin")]
        Pic_Weixin = 1 << 9,
        /// <summary>
        /// 弹出地理位置选择器的事件推送
        /// 用户点击按钮后，微信客户端将调起地理位置选择工具，完成选择操作后，将选择的地理位置发送给开发者的服务器，同时收起位置选择工具，随后可能会收到开发者下发的消息。
        /// </summary>
        [EnumMember(Value = "location_select")]
        Location_Select = 1 << 10,
    }
}
