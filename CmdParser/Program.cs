using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CmdParser;


namespace CmdParser
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string[] raidList = new string[0];
            PlayerInfo pi = new PlayerInfo();
            ManipulateRaiderText mt = new ManipulateRaiderText();

            raidList = pi.GetPlayers();

            var raiders = mt.FilterRaiders(raidList);
            var mains = mt.GetMainsList(raiders);
            var dkpOutput = mt.ListOutDKPReport(raiders, mains);

            pi.SaveRaiderList(dkpOutput);
            Console.WriteLine("Press any key to end program ...");
            Console.ReadLine();

        }
    }

}
