using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Active_UPC_Validation.Model
{
    class OutputModel : SpreadsheetModel
    {
        public string CsvOutput { get; private set; }

        public OutputModel(string fileName, string path) : base(fileName, path)
        {
            CsvOutput = "";
        }

        public void UpdateCsvOutput(string output)
        {
            this.CsvOutput = output;
        }

        public void UpdateFileName(string fileName)
        {
            UpdateFields(fileName, this.Path);
        }

        public void UpdatePath(string path)
        {
            UpdateFields(this.FileName, path);
        }
    }
}
