using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdParser
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";

            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = theDialog.FileName;
                var list = new List<string>();
                var fileStream = new FileStream(filename, FileMode.Open,FileAccess.Read)
                ;
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                var lines = list.ToArray();
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("Press any key to end.");
            Console.ReadLine();
        }
    }
}
