/**
 * @author 冯际成
 * @time 2013年2月6日 13:38:42
 */
(function (window) {
    //不允许关闭的标签
    var _onlyOpenTitle = "主页";
    var easyui = {
        // 脚本库的版本号
        version: "1.0",
        //设置不允许关闭的标签名称
        setOnlyOpenTitle: function (openTitle) {
            _onlyOpenTitle = openTitle;
        }, 
        //异步加载脚本并执行
        loadJs: function (url, callback) {
            var done = false;
            var script = document.createElement('script');
	    script.type = 'text/javascript';
	    script.language = 'javascript';
	    script.src = this.rootPath() + '/' + url + '?version=' + this.version;
	    script.onload = script.onreadystatechange = function(){
		if (!done && (!script.readyState || script.readyState == 'loaded' || script.readyState == 'complete')){
			done = true;
			script.onload = script.onreadystatechange = null;
			if (callback){
				callback();
			}
		}
	    }
	    document.getElementsByTagName("head")[0].appendChild(script);
        },
        //获得url跟路径
        rootPath: function () {
            var strFullPath = window.document.location.href;
            var strPath = window.document.location.pathname;
            var pos = strFullPath.indexOf(strPath);
            var prePath = strFullPath.substring(0, pos);
            var postPath = strPath.substring(0, strPath.substr(1).indexOf('/') + 1);
            //return (prePath + postPath);如果发布IIS，有虚假目录用用这句
            return (prePath+postPath);
        },
        //继承方法；
        extend: function (subClass, superClass) {
            var F = {};
            F.prototype = superClass.prototype;
            //实现继承
            subClass.prototype = new F();
            //重置构造函数为本身；
            subClass.prototype.constructor = subClass;
            //通过subClass属性访问父类；
            subClass.superClass = superClass.prototype;
            //通过baseconstructor访问父类构造函数；
            SubClass.baseconstructor = superClass;
        },
        //加载css样式
        loadCss: function (url, callback) {
           var link = document.createElement('link');
	   link.rel = 'stylesheet';
	   link.type = 'text/css';
	   link.media = 'screen';
           link.src = this.rootPath() + '/' + url + '?version=' + this.version;
	   document.getElementsByTagName('head')[0].appendChild(link);
	   if (callback){
		callback();
	   }
        },
        //创建tab标签窗口
        createTabs: function (title, url, icon) {
            $('#tabs_menu').tabs('add', {
                title: title,
                content: createFrame(url),
                iconCls: icon,
                closable: true
            });

        },
        //左侧tabs标签
        leftTabsEvents: function (item) {
            //alert(item);
        },
        //选项卡右侧关闭
        tabToolsCloceHandler:function(){
             var selectTabs = $('#tabs_menu').tabs('getSelected');
             var itemTitle = selectTabs.panel('options').title;
             if (itemTitle != _onlyOpenTitle) {
                 //关闭标签
                 $('#tabs_menu').tabs('close', itemTitle);
             }
        },
        //tab右击菜单
        tabToolsOnContextMenu:function(e, title,index){
            //阻止事件冒泡
            e.preventDefault();
            //选中此标签
            $("#tabs_menu").tabs("select", index);
            //显示右击菜单
            $('#tabs_menu_tool').menu('show', {
                left: e.pageX + 5,
                top: e.pageY
            });
            var itemClose = $('#close')[0];
            var itemCloseLeft = $('#close_left')[0];
            //判断是否为登录默认欢迎页面
            if(title === _onlyOpenTitle)
            {
                 //禁用关闭
                $('#tabs_menu_tool').menu('disableItem', itemClose);
                //禁用关闭左侧
                $('#tabs_menu_tool').menu('disableItem', itemCloseLeft);
            }
            else
            {
                 //启用关闭
                $('#tabs_menu_tool').menu('enableItem', itemClose);
                //启用关闭左侧
                $('tabs_menu_tool').menu('enableItem', itemCloseLeft);   
            }
        },
        //tab右击工具栏实现；
        tabsMenuHandler: function (item) {
            var selectTabs = $('#tabs_menu').tabs('getSelected');  // 获得选中项；
            ///获得选中的索引
            var indexTabs = $('#tabs_menu').tabs('getTabIndex', selectTabs);
            //获得多有pane
            var countTabs = $('#tabs_menu').tabs('tabs');
            var allTabsKey = [];
            $.each(countTabs, function (i, n) {
                var tem = $(n).panel('options');
                allTabsKey.push(tem.title);
            });
            switch (item.name) {
                ///关闭； 
                case 'close': $('#tabs_menu').tabs('close', selectTabs.panel('options').title); break;
                //关闭左侧 
                case 'close-left':
                    if (indexTabs > 1) {
                        $.each(allTabsKey, function (i, n) {
                            if (indexTabs > 1 && i < indexTabs) {
                                if (n != _onlyOpenTitle) {
                                    $('#tabs_menu').tabs('close', n);
                                }
                            }
                        });
                    } else {
                        alert("左侧为空");
                    }
                    break;
                //关闭右侧 
                case 'colse-right':
                    if (indexTabs < allTabsKey.length) {
                        $.each(allTabsKey, function (i, n) {
                            if (i > indexTabs) {
                                $('#tabs_menu').tabs('close', n);
                            }
                        });
                    } else {
                        alert("右侧为空");
                    }
                    break;
                //关闭全部 
                case 'close-all':
                    $.each(allTabsKey, function (i, n) {
                        if (n != _onlyOpenTitle) {
                            $('#tabs_menu').tabs('close', n);
                        }
                    });
                    break;
                //刷新 
                case 'refresh':
                    var iframe = $(selectTabs.context.innerHTML);
                    $('#tabs_menu').tabs('update', {
                        tab: selectTabs,
                        options: {
                            content: selectTabs.context.innerHTML
                        }
                    })
                    break;
                default: return;
            };
        },
         //iframe高度自适应
        adjustIframe: function (id)
        {
            //获得此对象
            var iframe = this.$(id);
            var idoc = iframe.contentWindow && iframe.contentWindow.document || iframe.contentDocument;
            var callback = function () {
                //得到iframe高度
                var iheight = Math.max(idoc.body.scrollHeight, idoc.documentElement.scrollHeight);
                //设置iframe高度;
                iframe.style.height = iheight + "px";
            };
            //添加事件 兼容浏览器;
            if (iframe.attarchEvent)
            {
                iframe.attachEvent("onload", callback);
            }
            else
            {
                iframe.onload = callback;
            }
        },
        ///更改主题
        themeHandler: function (item) {
            //更换当前样式
            $("#themes").attr("href", "Public/Scripts/themes/" + item.text + "/easyui.css");
            //把样式信息写入cookie里面
            $.cookie('defaultTheme', item.text)
        },
        randomNum:function(ldf_min,laf_max){
            var Range = laf_max - ldf_min;   
            var Rand = Math.random();   
            return(laf_max + Math.round(Rand * Range));   
        },
        //退出系统提示
        onExit:function(_this){
            var url = $(_this).attr("href");
            $.messager.confirm('确认','你确认要退出系统吗?',function(r){
		if (r){
		  top.window.location = url;
		}
	   });
           return false;
        },
        //加载默认主题
        onloadTheme:function(){
            if ($.cookie('defaultTheme')) {
                $("#themes").attr("href","/Public/Scripts/themes/" + $.cookie('defaultTheme') + "/easyui.css");
            }
            else {
                $("#themes").attr("href","/Public/Scripts/themes/default/easyui.css");
            }
        },
        onload: function () {
            ///设置默认主题必需事先引用jquery.cookie.js插件;
            //如果客户端存在用户已经选择样式
            this.onloadTheme();
            //双击关闭tabs；
            $("#tabs-menu .tabs-inner:gt(0)").live('dblclick', function (e) {
                e.preventDefault();
                var closeItem = $(this).children(".tabs-closable").text();
                $('#tabs-menu').tabs('close', closeItem);
            });
        }
    };
    ///创建iframe标签；
    function createFrame(url) {
        return '<iframe scrolling="auto" frameborder="0"  src="' + url + '" style="width:100%;height:100%;"></iframe>';
    };
    ///绑定到作用域链中
    window.easyui = easyui;
    /****************************
     *                          *
     *       对已知类型扩展                *
     *                          *
     ****************************/
    //对String类型扩展；
    //清除字符串后面空格；
    String.prototype.trim = function () {
        return this.replace(/^\s*/, "").replace(/\s*$/, "");
    };
    //去除字符串中的所有空格，包括之间的空格
    String.prototype.trimAll = function () {
        return this.replace(/^\s*/, "").replace(/\s/g, "");
    };
    //对html进行编码；
    String.prototype.escapeHTML = function ()
    {
        function replaceChars(ch) {
            switch (ch) {
                case "<":
                    return "&lt;";
                case ">":
                    return "&gt;";
                case "&":
                    return "&amp;";
                case "'":
                    return "&#39;";
                case '"':
                    return "&quot;";
            }
            return "?";
        }
        ;
        return this.replace(/[<>&"']/g, replaceChars);
    };
    //判断是否为中文
    String.prototype.isCN = function () {
        var lst = /[u00-uFF]/;
        return !lst.test(this);
    };
    //判断是否为中文
    String.prototype.ToLog = function () {
        var lst = /[u00-uFF]/;
        return !lst.test(this);
    };
    //判断是否为数字
    String.prototype.isNumber = function () {
        var re = new RegExp("^([+-]?)\\d*\\.?\\d+$");
        return re.test(this);
    };
    //判断是否为整数
    String.prototype.isInteger = function () {
        var re = new RegExp("^([+-]?)\\d+$");
        return re.test(this);
    };
    //判断是否为浮点小数
    String.prototype.isFloat = function () {
        var re = new RegExp("^([+-]?)\\d*\\.\\d+$");
        return re.test(this);
    };
    //判断是否为邮箱
    String.prototype.isEmail = function () {
        var re = new RegExp("^\\w+((-\\w+)|(\\.\\w+))*\\@[A-Za-z0-9]+((\\.|-)[A-Za-z0-9]+)*\\.[A-Za-z0-9]+$");
        return re.test(this);
    };
    String.prototype.toXml = function () {
        var objxml = null;
        if (window.ActiveXObject) {
            objxml = new ActiveXObject("Microsoft.XMLDOM");
            objxml.async = false;
            objxml.loadXML(this);
        }
        else {
            objxml = (new DOMParser()).parseFromString(this, "text/xml");
        }
        return objxml;
    };
    //判断是否为color
    String.prototype.isColor = function () {
        var re = new RegExp("^[a-fA-F0-9]{6}$");
        return re.test(this);
    };
    //判断是否为url
    String.prototype.isUrl = function () {
        var re = new RegExp("^http[s]?:\\/\\/([\\w-]+\\.)+[\\w-]+([\\w-./?%&=]*)?$");
        return re.test(this);
    };
    //判断仅为中文
    String.prototype.isOnloyCN = function () {
        var re = new RegExp("^[\\u4E00-\\u9FA5\\uF900-\\uFA2D]+$");
        return re.test(this);
    };
    //判断是否为邮编
    String.prototype.isZipCode = function () {
        var re = new RegExp("^\\d{6}$");
        return re.test(this);
    };
    //判断是否为手机
    String.prototype.isPhone = function () {
        var re = new RegExp("^(13|15)[0-9]{9}$");
        return re.test(this);
    };
    //判断是否为ip4
    String.prototype.isIp4 = function () {
        var re = new RegExp("^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");
        return re.test(this);
    };
    //判断是否为图片
    String.prototype.isPicture = function () {
        var re = new RegExp("(.*)\\.(jpg|bmp|gif|ico|pcx|jpeg|tif|png|raw|tga)$");
        return re.test(this);
    };
    //判断是否为rar
    String.prototype.isWinRar = function () {
        var re = new RegExp("(.*)\\.(rar|zip|7zip|7z|tgz)$");
        return re.test(this);
    };
    //判断是否为日期格式
    String.prototype.isDate = function () {
        var re = new RegExp("^\\d{4}(\\-|\\/|\.)\\d{1,2}\\1\\d{1,2}$");
        return re.test(this);
    };
    //判断是否为qq
    String.prototype.isQQ = function () {
        var re = new RegExp("^[1-9]*[1-9][0-9]*$");
        return re.test(this);
    };
    //判断是否为国内电话
    String.prototype.isTel = function () {
        var re = new RegExp("(^[0-9]{3,4}\-[0-9]{3,8}$)|(^[0-9]{3,8}$)|(^\([0-9]{3,4}\)[0-9]{3,8}$)|(^0{0,1}13[0-9]{9}$)");
        return re.test(this);
    };
    //判断是否仅为字母
    String.prototype.isChar = function () {
        var re = new RegExp("^[A-Za-z]+$");
        return re.test(this);
    };
    //判断是否为身份证
    String.prototype.isIdentity = function () {
        var re = new RegExp("^[1-9]([0-9]{14}|[0-9]{17})$");
        return re.test(this);
    };
})(window);