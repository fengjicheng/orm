﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO.Compression;

namespace Qhyhgf.WeiXin.Qy.Api
{
    /// <summary>
    /// gzip双向压缩
    /// </summary>
    public class DuplexGzipModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(app_BeginRequest);
        }
        void app_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;

            // 注意：这里不能使用"Accept-Encoding"这个头，二者的意义完全不同。
            if (app.Request.Headers["Content-Encoding"] == "gzip")
            {
                app.Request.Filter = new GZipStream(app.Request.Filter, CompressionMode.Decompress);

                app.Response.Filter = new GZipStream(app.Response.Filter, CompressionMode.Compress);
                app.Response.AppendHeader("Content-Encoding", "gzip");
            }
        }
    }
}
