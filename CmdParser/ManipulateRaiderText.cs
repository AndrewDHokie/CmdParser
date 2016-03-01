using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdParser
{
    class ManipulateRaiderText
    {
        internal string[] FilterRaiders(string[] raidList)
        {
            string[] raiders = new string[56];
            int raiderIndex = 2;
            raiders[0] = "These are the actual Toons that participated int the raid.";
            raiders[1] = "";
            foreach(string r in raidList)
            {
                raiders[raiderIndex] = r;
                raiderIndex++;                
            }
            raiders[raiderIndex] = "/n";
            return raiders;
        }

        internal string[] GetMainsList(string[] raiders)
        {
            string[] convertedToMains = new string[120];
            int MainsListIndex = 2;
            convertedToMains[0] = "These are the toons all converted to mains";
            convertedToMains[1] = "";
            foreach (string r in raiders)
            {
                convertedToMains[MainsListIndex] = r;
                MainsListIndex++;
            }
            return convertedToMains;
        }

        internal string[] ListOutDKPReport(string[] raiders, string[] mains)
        {
            string[] dkpRepoort = new string[300];
            dkpRepoort = raiders.Concat(mains).ToArray();
            return dkpRepoort;
        }
    }
}
