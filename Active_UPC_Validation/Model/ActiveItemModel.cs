using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Active_UPC_Validation.Model
{
    class ActiveItemModel : SpreadsheetModel
    {
        public int StoreNumber { get; private set; }

        public List<double> UpcList { get; private set; }


        public ActiveItemModel(string fileName, string path) : base(fileName, path)
        {
            UpdateFields();
        }

        public void UpdateFields()
        {
            StoreNumber = parseStore(FileName);
            UpcList = new List<double>();

            using (TextFieldParser parser = new TextFieldParser(Path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                string[] infoRow = parser.ReadFields(); // parse informational row into seperate field

                if (StoreNumber != 0)
                {
                    while (!parser.EndOfData)
                    {
                        // process row
                        string[] fields = parser.ReadFields();

                        // add to list (value=UPC)
                        UpcList.Add(double.Parse(fields[1]));
                    }
                }
            }
        }

        private int parseStore(string fileName)
        {
            int result = 0;

            result = fileName.Contains("whitefish_bay") ? 1 : result;
            result = fileName.Contains("wauwatosa") ? 2 : result;
            result = fileName.Contains("mequon") ? 3 : result;
            result = fileName.Contains("grafton") ? 4 : result;
            result = fileName.Contains("elm_grove") ? 5 : result;
            result = fileName.Contains("franklin") ? 6 : result;
            result = fileName.Contains("greenfield") ? 7 : result;
            result = fileName.Contains("germantown") ? 8 : result;
            result = fileName.Contains("new_berlin") ? 9 : result;
            result = fileName.Contains("west_bend") ? 10 : result;
            result = fileName.Contains("hartland") ? 12 : result;
            result = fileName.Contains("west_milwaukee") ? 14 : result;
            result = fileName.Contains("brookfield") ? 16 : result;

            return result;

        }
    }
}
