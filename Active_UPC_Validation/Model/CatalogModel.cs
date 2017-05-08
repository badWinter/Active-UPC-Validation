using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Active_UPC_Validation.Model
{
    class CatalogModel : SpreadsheetModel
    {
        public Dictionary<double, string> ProductList { get; private set; }

        public CatalogModel(string fileName, string path) : base(fileName, path)
        {
            ProductList = new Dictionary<double, string>();
        }

        public void UpdateCatalog()
        {
            populateProductList();
        }

        private void populateProductList()
        {
            ProductList = new Dictionary<double, string>();

            using (TextFieldParser parser = new TextFieldParser(Path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                string[] infoRow = parser.ReadFields(); // parse informational row into seperate field 

                // iterate through file rows, grabbing upc and respective item description to add to ProductList
                while (!parser.EndOfData)
                {
                    // process row
                    try
                    {
                        string[] fields = parser.ReadFields();

                        // add to dictionary (key=UPC (string parsed to double), value=item description)
                        if (!ProductList.ContainsKey(double.Parse(fields[0])))
                        {
                            ProductList.Add(double.Parse(fields[0]), fields[1]);
                        }

                    }
                    catch (Exception ex)
                    {
                        if (ex is MalformedLineException || ex is FormatException)
                        {
                            continue;
                        }
                    }                    
                }
            }
        }
    }
}
