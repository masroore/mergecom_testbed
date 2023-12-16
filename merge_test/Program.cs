using System.IO;
using Mergecom;

namespace merge_test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var iniPath = "./config/merge.ini";
            var localAE = "SUPR_PACS";

            var finfo = new FileInfo(iniPath);
            MC.mcInitialization(finfo);
            var app = MCapplication.getApplication(localAE);
        }
    }
}