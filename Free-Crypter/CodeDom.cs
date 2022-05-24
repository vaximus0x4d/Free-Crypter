using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Free_Crypter
{
    class CodeDom
    {
        // I have added this class 'CodeDom' and the method 'Compile' to compile our stub file that contains the crypted payload !!
        public static void Compile(string FilePath, string Source)
        {
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("CompilerVersion", "v4.0");
            CSharpCodeProvider CsharpCompiler = new CSharpCodeProvider(Dic);
            CompilerParameters Parameters = new CompilerParameters();
            Parameters.ReferencedAssemblies.AddRange(new string[] { "System.dll", "mscorlib.dll", "System.Windows.Forms.dll" });
            Parameters.IncludeDebugInformation = false;
            Parameters.GenerateExecutable = true;
            Parameters.GenerateInMemory = false;
            Parameters.OutputAssembly = FilePath;
            Parameters.CompilerOptions += "/platform:X86 /target:winexe";
            CompilerResults Results = CsharpCompiler.CompileAssemblyFromSource(Parameters, Source);
            if (Results.Errors != null)
            {
                foreach (var error in Results.Errors)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }
    }
}
