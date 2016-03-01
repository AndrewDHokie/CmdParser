using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CmdParser
{
    class PlayerInfo
    {
        internal string[] GetPlayers()
        {
            Console.WriteLine("Pick the Raid Dump file");
            Thread.Sleep(1000);
            string[] raidLineArray = new string[0];
            var theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            // C:\ProgramData\Sony Online Entertainment\Installed Games

            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = theDialog.FileName;
                var list = new List<string>();
                var fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read)
                ;
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                raidLineArray = list.ToArray();
            }
            return raidLineArray;
        }

        internal void SaveRaiderList(string[] output)
        {
            Directory.CreateDirectory(@"c:\CTRaidInfo\");

            DateTime today = DateTime.Now;
            string todaystring = today.ToString("yyyyMMdd_H_mm");
            string filename = string.Format(@"C:\\CTRaidInfo\\{0}_CTRaiderInfo.txt", todaystring);
            File.WriteAllLines(filename, output);
            Console.WriteLine("File written to {0}", filename);
        }
    }
}
