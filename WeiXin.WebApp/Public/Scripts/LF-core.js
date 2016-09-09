/* global Function */

/**
 * @author 冯际成
 * @time 2015年3月31日15:50:24
 * @Emile caoxiancc@live.
 * @QQ 604756218
 */
(function (window, undefined) {
    //缩短作用域链查询距离
    var document = window.document,
            navigator = window.navigator,
            location = window.location;
    /****************************
     *                          *
     *         LF库定义                         *
     *                          *
     ****************************/
    var LF = {
        // 脚本库的版本号
        version: "1.0",
        //浏览器版本
        Browser: (function () {
            var ua = navigator.userAgent;
            var isOpera = Object.prototype.toString.call(window.opera) === '[object Opera]';
            return {
                IE: !!window.attachEvent && !isOpera,
                Opera: isOpera,
                WebKit: ua.indexOf('AppleWebKit/') > -1,
                Gecko: ua.indexOf('Gecko') > -1 && ua.indexOf('KHTML') === -1,
                MobileSafari: /Apple.*Mobile/.test(ua)
            };
        })(),
        //xml解析
        parseXML: function (data) {
            var xml, tmp;
            try {
                // 标准浏览器
                if (window.DOMParser) {
                    tmp = new DOMParser();
                    xml = tmp.parseFromString(data, 'text/xml');
                }
                // IE6/7/8
                else {
                    xml = new ActiveXObject('Microsoft.XMLDOM');
                    xml.async = 'false';
                    xml.loadXML(data);
                }
            } catch (e) {
                xml = undefined;
            }
            return xml;
        },
        //json解析
        parseJSON: function (data) {
            if (!data || typeof data !== "string") {
                return null;
            }
            var data = data.trim();
            // 标准浏览器可以直接使用原生的方法
            if (window.JSON && window.JSON.parse) {
                try {
                    return window.JSON.parse(data);
                } catch (_) {
                }
            }
            var rValidtokens = /"[^"\\\n\r]*"|true|false|null|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?/g,
                    rValidescape = /\\(?:["\\\/bfnrt]|u[0-9a-fA-F]{4})/g,
                    rValidbraces = /(?:^|:|,)(?:\s*\[)+/g,
                    rValidchars = /^[\],:{}\s]*$/;
            if (rValidchars.test(data.replace(rValidescape, "@")
                    .replace(rValidtokens, "]")
                    .replace(rValidbraces, ""))) {
                try {
                    return (new Function("return " + data))();
                } catch (_) {
                }

            }
            return null;
        },
        //Md5加密
        MD5: function (str)
        {

        },
        //命名空间；
        namespace: function (str) {
            var arr = str.split("."), o = LF;
            for (var i = (arr[0] === "LF") ? 1 : 0; i < arr.length; i++) {
                o[arr[i]] = o[arr[i]] || {};
                o = o[arr[i]];
            }
            ;
        },
        //异步加载脚本并执行
        loadJs: function (url, callback) {
            var done = false;
            var script = document.createElement('script');
	    script.type = 'text/javascript';
	    script.language = 'javascript';
	    script.src = url;
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
            subClass.baseconstructor = superClass;
        },
        //获得网站跟目录
        rootPath:function(){
            var strFullPath = window.document.location.href;
            var strPath = window.document.location.pathname;
            var pos = strFullPath.indexOf(strPath);
            var prePath = strFullPath.substring(0, pos);
            var postPath = strPath.substring(0, strPath.substr(1).indexOf('/') + 1);
            //return (prePath + postPath);如果发布IIS，有虚假目录用用这句
            return (prePath);
        },
        //加载css样式
        loadCss: function (url,callback) {
            var link = document.createElement('link');
            link.rel = 'stylesheet';
            link.type = 'text/css';
            link.media = 'screen';
            link.href = url;
            document.getElementsByTagName('head')[0].appendChild(link);
        },
        //$选择器,扩展了支持多个元素；
        getElementsById: function () {
            var elements = [];
            for (var i = 0, len = arguments.length; i < len; i++) {
                var element = arguments[i];
                if (typeof element == 'string') {
                    element = document.getElementById(element);
                }
                if (arguments.length == 1) {
                    return element;
                }
                elements.push(element);
            }
            return elements;
        },
        //获取class类元素
        getElementsByClassName: function (searchClass, node, tag) {
            if (document.getElementsByClassName) {
                var nodes = (node || document).getElementsByClassName(searchClass), result = [];
                for (var i = 0; node = nodes[i++]; ) {
                    if (tag !== "*" && node.tagName === tag.toUpperCase()) {
                        result.push(node);
                    }
                }
                return result;
            } else {
                node = node || document;
                tag = tag || "*";
                var classes = searchClass.split(" "),
                        elements = (tag === "*" && node.all) ? node.all : node.getElementsByTagName(tag),
                        patterns = [],
                        current,
                        match;
                var i = classes.length;
                while (--i >= 0) {
                    patterns.push(new RegExp("(^|\\s)" + classes[i] + "(\\s|$)"));
                }
                var j = elements.length;
                while (--j >= 0) {
                    current = elements[j];
                    match = false;
                    for (var k = 0, kl = patterns.length; k < kl; k++) {
                        match = patterns[k].test(current.className);
                        if (!match)
                            break;
                    }
                    if (match)
                        result.push(current);
                }
                return result;
            }
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
        //解决冲突
        noConflict: function (name) {
            if (name && typeof name === 'string') {
                if (name && window['LF']) {
                    window[name] = window['LF'];
                    delete window['LF'];
                    return window[name];
                }
            } else {
                return window['LF'];
                delete window['LF'];
            }
        },
        //产生随机数
        random:(function(){
          var today = new Date(); 
          var seed = today.getTime();
          function rnd(){
            seed = ( seed * 9301 + 49297 ) % 233280;
            return seed / ( 233280.0 );
          };
          return function rand(number){
            return Math.ceil(rnd(seed) * number);
          };
        })(),
        //对LF进行扩展
        //forEach遍历
        forEach: function (enumerable, iterator, context) {
            var i, n, t;

            if (typeof iterator == "function" && enumerable) {

                // Array or ArrayLike or NodeList or String or ArrayBuffer
                n = typeof enumerable.length == "number" ? enumerable.length : enumerable.byteLength;
                if (typeof n == "number") {

                    // 20121030 function.length
                    //safari5.1.7 can not use typeof to check nodeList - linlingyu
                    if (Object.prototype.toString.call(enumerable) === "[object Function]") {
                        return enumerable;
                    }


                    for (i = 0; i < n; i++) {

                        t = enumerable[ i ];
                        t === undefined && (t = enumerable.charAt && enumerable.charAt(i));

                        // 被循环执行的函数，默认会传入三个参数(array[i], i, array)
                        iterator.call(context || null, t, i, enumerable);
                    }

                    // enumerable is number
                } else if (typeof enumerable == "number") {

                    for (i = 0; i < enumerable; i++) {
                        iterator.call(context || null, i, i, i);
                    }

                    // enumerable is json
                } else if (typeof enumerable == "object") {

                    for (i in enumerable) {
                        if (enumerable.hasOwnProperty(i)) {
                            iterator.call(context || null, enumerable[ i ], i, enumerable);
                        }
                    }
                }
            }

            return enumerable;
        }
    };
    //对cookie的封装，采取getter、setter方式
    function Cookie() {
    }
    ;
    Cookie.prototype = {
        //获取cookie对象，以对象表示
        getCookiesObj: function () {
            var cookies = {};
            if (document.cookie) {
                var objs = document.cookie.split('; ');
                for (var i in objs) {
                    var index = objs[i].indexOf('='),
                            name = objs[i].substr(0, index),
                            value = decodeURIComponent(objs[i].substr(index + 1, objs[i].length));  //解密
                    cookies[name] = value;
                }
            }
            return cookies;
        },
        //设置cookie
        set: function (name, value, opts) {
            //opts maxAge, path, domain, secure
            if (name && value) {
                var cookie = encodeURIComponent(name) + '=' + encodeURIComponent(value);
                //可选参数
                if (opts) {
                    if (opts.maxAge) {
                        cookie += '; max-age=' + opts.maxAge;
                    }
                    if (opts.path) {
                        cookie += '; path=' + opts.path;
                    }
                    if (opts.domain) {
                        cookie += '; domain=' + opts.domain;
                    }
                    if (opts.secure) {
                        cookie += '; secure';
                    }
                }
                document.cookie = cookie;
                return cookie;
            } else {
                return '';
            }
        },
        //获取cookie
        get: function (name) {
            return decodeURIComponent(getCookiesObj()[name]) || null;
        },
        //清除某个cookie
        remove: function (name) {
            if (getCookiesObj()[name]) {
                document.cookie = name + '=; max-age=0';
            }
        },
        //清除所有cookie
        clearAll: function () {
            var cookies = getCookiesObj();
            for (var key in cookies) {
                remove(key);
            }
        },
        //获取所有cookies
        getCookies: function (name) {
            return getCookiesObj();
        }
    };
    //把Cookie挂载上去;
    if (!LF.Cookie)
    {
        LF.Cookie = Cookie;
    }
    //对ajax扩展
    function Ajax(url, data) {
        this.url = url;
        this.data = data;
    }
    ;

    Ajax.prototype = {
        get: function (callback) {
            var xmlhttp = window.XMLHttpRequest ? new XMLHttpRequest() : new ActiveXObject('Microsoft.XMLHTTP');
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                    //需设为true,否则异步执行
                    //执行回调函数
                    callback(xmlhttp.responseText);
                }
            };
            if (this.data) {
                 xmlhttp.open('GET', this.url + '?' + this.data, true);//true无法抓取数据，why?
            }
            else
            {
               xmlhttp.open('GET', this.url, true);//true无法抓取数据，why?  
            }
            xmlhttp.send(null);
        },
        post: function (callback) {
            var xmlhttp = window.XMLHttpRequest ? new XMLHttpRequest() : new ActiveXObject('Microsoft.XMLHTTP');
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                    //当然你可以把200~300之间或304的都理解成响应成功
                    //执行回调函数
                    callback(xmlhttp.responseText);
                }
            };
            xmlhttp.open('POST', this.url, true);//需设为true,否则异步执行
            xmlhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");//POST中，这句必须
            xmlhttp.send(this.data);
        }
    };
    //把ajax挂载上去;
    if (!LF.Ajax)
    {
        LF.Ajax = Ajax;
    }

    if (!window.LF)
    {
        window.LF = LF;
    }
    ;
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
    //兼容扩展Funciton
    if (Function.prototype.bind) {
        Function.prototype.bind = function (o /*,args*/)
        {
            var self = this, boundArgs = arguments;
            //bind方法返回值是一个函数
            return function()
            {
                var args = [], i;
                for (i = 1; i < boundArgs.length; i++) {
                    args.push(boundArgs[i]);
                }
                ;
                for (i = 0; i < arguments.length; i++) {
                    args.push(arguments[i]);
                }
                ;
                return self.apply(o, args);
            };
        };
    }
    ;
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
    //对object扩展
    Object.prototype.isRepeat = function (itme) {
        if (itme == this && typeof itme == typeof this) {
            return true;
        } else {
            return false;
        }
    };
    //判断此类是否为父类
    Object.prototype.instanceof = function (tmp) {
        return	this instanceof tmp;
    };
    //对array扩展
    Array.prototype.each = function (iterator)
    {
        for (var i = 0, len = this.length; i < len; i++) {
            iterator(this[i]);
        }
    };
    //把html结合转化为数组(取自高效，把html结合转化为数组访问属性更快)；
    Array.prototype.toArray = function () {
        for (var i = 0, a = [], len = this.length; i < len; i++) {
            a[i] = this[i];
        }
        return a;
    };

})(window);