<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WeiXin.WebUi.Admin.Login" %>

<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9" />
    <link href="/Public/Images/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <title>微信企业号登录页面</title>
    <script src="/Public/Scripts/jquery-1.7.2.js" type="text/javascript"></script>
    <style type="text/css">
        .Loginbody{background: #2e3e4e;}
        .logo{margin: auto; margin-top: 8%; width: 983px; height: 100px;}
        .content{margin: auto; width: 983px; height: 332px; background: url(/Public/Images/loginbj.png) top center no-repeat #fff; border-radius: 5px; box-shadow: 0 10px 20px rgba(0,0,0,.6);}
        .Loginform{margin-top: 71px; float: right; width: 367px; height: 200px;}
        .form-message{height:30px; width:60%; margin-left:auto; margin-right:auto;}
        .form-error-text{padding-left:35px;border:1px solid #ee86a4; color: #9d2a16; font-family: Microsoft Yahei; height: 26px; line-height: 26px; background:#f8cad7 url('/Public/Images/validatebox_warning.png') center left no-repeat; background-position: 10px 5.5px; border-radius: 4px;}
        .form-warning-text{padding-left:35px;border:1px solid #f8e144; color: #000; font-family: Microsoft Yahei; height: 26px; line-height: 26px; background:#fdf7ce url('/Public/Images/Icon16/bullet_error.png') center left no-repeat; background-position: 10px 5.5px; border-radius: 4px;}
        .form-succeed-text{padding-left:35px; border-radius:3px; color: #fff; font-family: Microsoft Yahei; border: 1px solid #5e8800; height: 26px; line-height: 26px; background:#62b600 url('/Public/Images/loading1.gif') center left no-repeat; background-position: 10px 5.5px;}
        .form-account{margin-top: 16px; margin-left: 16px; font-family: Microsoft Yahei; font-size: 12pt; color: #999999;}
        .form-password{margin-top: 38px; margin-left: 16px; font-family: Microsoft Yahei; font-size: 12pt; color: #999999;}
        #txtaccount{border: none; padding: 0px; height: 32px; line-height: 32px; width: 260px; font-family: Î¢ÈíÑÅºÚ,ËÎÌå,Arial,Helvetica,Verdana,sans-serif; font-size: 11pt; color: #999999; background-color: #F0EEF1; padding-left: 5px;}
        #txtpassword{border: none; padding: 0px; height: 32px; line-height: 32px; width: 260px; font-family: Î¢ÈíÑÅºÚ,ËÎÌå,Arial,Helvetica,Verdana,sans-serif; font-size: 11pt; color: #999999; background-color: #F0EEF1; padding-left: 5px;}
        .form-bottom{margin-top: 38px; margin-left: 16px; height:39px;line-height:39px;}
        .btlogin{height:40px; width:100px; float:right; margin-right:12px; cursor:pointer;}
        .copyright{text-align:  center; color: #fff;  width: 97%; font-family: Microsoft Yahei; margin-top: 30px;}
        .qqsign{margin-left: 20px; border: medium none; width: 63px; height: 24px; border-style: none; background: none; background-image: url("/Public/Images/Connect.png" ); cursor: pointer;}
        .form-succeed-text{
            padding-left: 35px;
            border-radius: 3px;
            color: #fff;
            font-family: Microsoft Yahei;
            border: 1px solid #5e8800;
            height: 26px;
            line-height: 26px;
            background: #62b600 url('/Public/Images/loading1.gif') center left no-repeat;
            background-position: 10px 5.5px;
            display:none;
        }
        .form-warning-text {
            padding-left: 35px;
            border: 1px solid #f8e144;
            color: #000;
            font-family: Microsoft Yahei;
            height: 26px;
            line-height: 26px;
            background: #fdf7ce url('/Public/Images/bullet_error.png') center left no-repeat;
            background-position: 10px 5.5px;
            border-radius: 4px;
            display:none;
        }
        .form-error-text {
            padding-left: 35px;
            border: 1px solid #ee86a4;
            color: #9d2a16;
            font-family: Microsoft Yahei;
            height: 26px;
            line-height: 26px;
            background: #f8cad7 url('/Public/Images/validatebox_warning.png') center left no-repeat;
            background-position: 10px 5.5px;
            border-radius: 4px;
            display:none;
        }
        .btlogin{
            border:0px;
            background:none;
            text-indent:-9999px;
            height: 40px;
            width: 100px;
            float: right;
            margin-right: 12px;
            cursor: pointer;
        }
    </style>
    <script type="text/javascript">
        $(function () {
            $("#txtaccount,#txtpassword").click(function (e) {
                $(".form-message").children().hide();
            });
        });
        //用户登录
        function loginin() {
            //显示正在登陆状态;
            //隐藏所有
            $(".form-message").children().hide();
            //显示正在登陆
            $(".form-succeed-text").show();
            //判断用户名
            var val = $("#txtaccount").val();
            if (val === "") {
                //隐藏所有
                $(".form-message").children().hide();
                //显示提示信息
                $(".form-warning-text").html("用户名不能为空").show();
                return false;
            }
            var val = $("#txtpassword").val()
            //判断密码
            if (val === "") {
                //隐藏所有
                $(".form-message").children().hide();
                //显示提示信息
                $(".form-warning-text").html("密码不能为空").show();
                return false;
            }
            //ajax登录
            $.post("<%=Request.RawUrl.ToString()%>?action=Login", $(".Loginform").serialize(), function (_data) {
                ///登陆成功
                if (_data.status === "0") {
                    window.location = "/Admin/index";
                }
                else {
                    //隐藏
                    $(".form-message").children().hide();
                    alert(_data.content);
                }
            });
            return false;
        }
    </script>
</head>
<body class="Loginbody">
    <div class="logo">
        <img alt="logo" src="/Public/Images/logo.png" />
    </div>
    <div class="content">
        <form action="<%=Request.RawUrl.ToString()%>" method="post" class="Loginform">
            <div class="form-message">
                <div class="form-succeed-text">正在登录...</div>
                <div class="form-warning-text">登录账户不能为空</div>
                <div class="form-error-text">登录账户不存在</div>
            </div>
            <div class="form-account">
                账户
                <input id="txtaccount" name="username" type="text" />
            </div>
            <div class="form-password">
                密码
                <input id="txtpassword" name="pwd" type="password" />
            </div>
            <div class="form-bottom">
                <input type="submit" onclick="return loginin()" class="btlogin" id="btlogin" />
            </div>
        </form>
    </div>
    <div class="copyright">
        <div>青海盐湖工业股份有限公司</div> 
        <div>官方网站：http://www.qhyhgy.com</div>
        <div style="text-align: center; margin: 20px; font-family: Microsoft Yahei; color: #fff; margin: auto; width: 983px;">
            <p>适用浏览器：IE8以上、360、FireFox、Chrome、Safari、Opera、傲游、搜狗、世界之窗. </p>
        </div>
    </div>
</body>
</html>
