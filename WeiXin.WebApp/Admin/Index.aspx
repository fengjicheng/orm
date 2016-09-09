<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WeiXin.WebUi.Admin.Index" %>

<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9" />
    <link href="/Public/Images/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <title>盐湖工业股份有限公司微信平台</title>
    <link href="/Public/Images/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <!-- 
  作者： 冯际成
  手机:  15209793953
  博客： http://www.cnblogs.com/sharpmap/
   -->
  <!-- 必要的css文件-->
  <link id="themes" href="/Public/Scripts/themes/default/easyui.css" rel="stylesheet" type="text/css" />
  <link href="/Public/Scripts/themes/icon.css" rel="stylesheet" type="text/css" />
  <link href="/Public/Css/demo.css" rel="stylesheet" type="text/css" />
  <script src="/Public/Scripts/jquery-1.7.2.js" type="text/javascript"></script>
  <script src="/Public/Scripts/jquery.cookie.js" type="text/javascript"></script>
  <script src="/Public/Scripts/jquery.easyui.min.js" type="text/javascript"></script>
  <script src="/Public/Scripts/locale/easyui-lang-zh_CN.js" type="text/javascript"></script>
  <script src="/Public/Scripts/easyui-demo.js" type="text/javascript"></script>
  <script type="text/javascript">
      $(function () {
          easyui.onload();
      });
  </script>
</head>
<body>
<!--载进度条
<div class="loading_background">
    <img alt="正在加载" src="/Public/Images/ajax-loader.gif"/>
</div>
start-->
<!--页面内容-->
<div  class="easyui-layout" data-options="fit:true">
    <!--head-->
    <div data-options="region:'north',border:false" class="head">
        <a class="logo" href="{:C('SITEURL')}" title="{:C('DEFAULNAME')}">标志</a>
        <div class="navMenu">
            <ul class="topnavlist">
                <li class="topnavitem">
                    <a href="{:F('Admin/index')}">
                        <span class="c1"></span>
                        系统首页
                    </a>
                </li>
                <li class="topnavitem">
                    <a>
                       <span class="c3"></span>快捷导航
                    </a>
                </li>
                <li class="topnavitem">
                    <a>
                        <span class="c3"></span>帮助中心
                    </a>
                </li>
                <li  class="topnavitem">
                    <a>
                        <span class="c2"></span>切换皮肤
                    </a>
                </li>
                <li class="topnavitem">
                    <a>
                        <span class="c5"></span>个人中心
                    </a>
                </li>
                <li class="topnavitem">
                    <a onclick="return window.easyui.onExit(this)" href="Login.aspx?action=exit">
                        <span class="c4"></span>
                        安全退出
                    </a>
                </li>
            </ul>
        </div>
    </div>
    <!-- 左侧菜单-->
    <div data-options="region:'west',iconCls:'icon-datebox-arrow'" class="menuleft">
        <div class="easyui-accordion tabs-header" data-options="fit:true">
            <div title="内容管理" data-options="selected:true,border:false" class="tabs-header">
                <ul class="easyui-tree">
                    <li>
                        <span>我的文档</span>
                        <ul>
                            <li data-options="state:'closed'">
                                <span>图片</span>
                                <ul>
                                    <li>
                                        <span>Friend</span>
                                    </li>
                                    <li>
                                        <span>Wife</span>
                                    </li>
                                    <li>
                                        <span>Company</span>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <span>项目</span>
                                <ul>
                                    <li>Intel</li>
                                    <li>Java</li>
                                    <li>Microsoft Office</li>
                                    <li>Games</li>
                                </ul>
                            </li>
                            <li>index.html</li>
                            <li>about.html</li>
                            <li>welcome.html</li>
                        </ul>
                    </li>
                </ul>

            </div>
            <div title="会员管理" class="tabs-header">
                  <ul class="easyui-tree">
                    <li>
                        <span>微信分组</span>
                        <ul>
                            <li>
                                <span>查看分组</span>
                            </li>
                            <li>
                                <span>添加分组</span>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <span>微信用户</span>
                        <ul>
                            <li>
                                <span>查看用户</span>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <span>系统管理员</span>
                        <ul>
                            <li>
                                <span>查看用户</span>
                            </li>
                            <li>
                                <span><a onclick='window.easyui.createTabs("修改密码", "User/UpdatePassword.aspx")'>修改密码</a> </span>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div title="菜单管理" class="tabs-header">
                content3
            </div>
        </div>
    </div>
    <!-- 主页面tabs-->
    <div class="databody" data-options="region:'center',border:false,split:true">
        <div class="easyui-tabs" id="tabs_menu" data-options="fit:true,tools:'#tab-tools',onContextMenu:easyui.tabToolsOnContextMenu">
            <div title="主页"  data-options="iconCls:'icon-index',fit:true" style="background: url(/Public/Images/main_bg.png) 50% 50% no-repeat">
            </div>
        </div>
    </div>
    <!--页脚-->
    <div data-options="region:'south'" class="footer tabs-header">
      <a href="javascript:void()" onclick="javascript:$('#footer-window').window('open')" class="easyui-linkbutton"  plain="true"> Copyright &copy; 2013  青ICP备05001603号</a>
      <!--弹出窗体弹出的内容-->
      <div id="footer-window" class="easyui-window" title="关于" data-options="closed:true,collapsible:false,maximizable:false,resizable:false,minimizable:false">
            青海盐湖工业股份有限公司微信公众平台
            <br />
            制作人：冯际成
            <br />
            手 机：15209793953
            <br />
            地  址：青海省格尔木市盐湖集团信息中心
   	  </div>
      <!--主页面tabs右击菜单-->
      <div id="tabs_menu_tool" data-options="onClick:window.easyui.tabsMenuHandler"  class="easyui-menu">
          <div id="close" data-options="name:'close'">关闭</div>
          <div id="close_left" data-options="name:'close-left'">关闭左侧</div>
          <div id="colse_right" data-options="name:'colse-right'">关闭右侧</div>
          <div id="close_all" data-options="name:'close-all'">关闭全部</div>
          <div class="menu-sep"></div>
          <div id="refresh" data-options="name:'refresh'">刷新</div>
       </div>
      <div id="tab-tools">
          <a href="#" class="easyui-linkbutton" onclick="" plain="true" iconCls="icon-reload"></a>
          <a href="#" class="easyui-linkbutton" onclick="" plain="true" iconCls="icon-cancel"></a>
      </div>
    </div>
</div>
</body>
</html>
