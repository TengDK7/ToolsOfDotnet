using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolOfLog4net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogHelper.WriteLog(string.Format("当前时间为{0}.", DateTime.Now.ToString()));
            LogHelper.WriteLog("Cautch Exception:", new Exception("My exception!"));
            System.Threading.Thread.Sleep(5000);
            LogHelper.WriteLog(string.Format("当前时间为{0}.", DateTime.Now.ToString()));
            Console.ReadKey();
        }
    }
}
