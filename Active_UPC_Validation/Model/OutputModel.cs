using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Active_UPC_Validation.Model
{
    class OutputModel : SpreadsheetModel
    {
        public string CsvOutput { get; private set; }

        public OutputModel(string fileName, string path) : base(fileName, path)
        {
            CsvOutput = "";
        }

        public void AppendCsvOutput(string output)
        {
            this.CsvOutput += output + Environment.NewLine;
        }

        public void UpdateFileName(string fileName)
        {
            UpdateFields(fileName, this.Path);
        }

        public void UpdatePath(string path)
        {
            UpdateFields(this.FileName, path);
        }

        public void WriteOutput()
        {
            // TODO:
            // create open/write stream using fileName and path, then take csv from output and write to file
            using (StreamWriter writer = new StreamWriter(Path))
            {
                writer.WriteLine(CsvOutput);
            }

            MessageBox.Show("Wrote file: " + FileName);
        }
    }
}
