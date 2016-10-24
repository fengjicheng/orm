using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp;

namespace Qhyhgf.Orm
{
    public static class DynamicCompiler
    {
        /// <summary>
        /// 从文件编译
        /// </summary>
        /// <param name="files">要编译的代码文件集合</param>
        /// <param name="referenceAssemblyNames">引用程序集名称集合</param>
        /// <param name="outputAssembly">输出dll名称</param>
        /// <returns>返回异常信息</returns>
        public static string CompileFromFile(string[] files, string[] referenceAssemblyNames, string outputAssembly)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            CompilerParameters compilerParameters = new CompilerParameters(referenceAssemblyNames, outputAssembly);
            CompilerResults complierResult = codeProvider.CompileAssemblyFromFile(compilerParameters, files);
            if (complierResult.Errors.HasErrors)
            {
                StringBuilder message = new StringBuilder();
                foreach (CompilerError err in complierResult.Errors)
                {
                    message.AppendFormat("(FileName:{0},ErrLine:{1}): error {2}: {3}", err.FileName, err.Line, err.ErrorNumber, err.ErrorText);
                }
                return message.ToString();
            }
            return string.Empty;
        }
    }
}
