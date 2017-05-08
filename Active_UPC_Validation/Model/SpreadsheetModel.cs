using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Active_UPC_Validation.Model
{
    abstract class SpreadsheetModel
    {
        public string FileName { get; private set; }
        public string Path { get; private set; }

        public SpreadsheetModel(string fileName, string path)
        {
            UpdateFields(fileName, path);
        }

        public void UpdateFields(string fileName, string path)
        {
            this.FileName = fileName;
            this.Path = path;
        }
    }
}
