using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace jamesxd
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            Console.Title = "Hwid Extractor - by Jamesxd";
            string hwid;
            hwid = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            Console.WriteLine("Searching Your Hwid\n");
            Task.Delay(1000).Wait();
            Console.WriteLine("Fetching Your Hwid...\n");
            Task.Delay(1000).Wait();
            Console.WriteLine("Hwid Found!\n");
            Console.WriteLine("Hwid: "+hwid);
            Task.Delay(20000000).Wait();
            Task.Delay(20000000).Wait();
            Task.Delay(20000000).Wait();
            Task.Delay(20000000).Wait();
            Task.Delay(20000000).Wait();
            Clipboard.SetText(hwid);
        }
    }
}
