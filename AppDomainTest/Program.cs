using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainTest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            AppDomain appDomain = AppDomain.CreateDomain("NewAppDomain");

            appDomain.AssemblyLoad +=(obj,e)=>
            {
                Console.WriteLine($"{e.LoadedAssembly.GetName().Name}.exe is Loading......");
            };
            //appDomain.ExecuteAssembly("HelloWorld.exe");
            appDomain.ExecuteAssembly("RadComboBoxDemo.exe");
            appDomain.DomainUnload += (obj, e)=>
            {
                Console.WriteLine($"AppDomain is UnLoad");
            };

            Console.ReadLine();
        }      
    }
}
