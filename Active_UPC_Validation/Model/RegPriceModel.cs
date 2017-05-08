using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;


namespace Active_UPC_Validation.Model
{
    class RegPriceModel : SpreadsheetModel, IStoreDependent
    {
        public int StoreNumber { get; private set; }

        public Dictionary<double,string> ProductPriceList { get; private set; }

        public RegPriceModel(string fileName, string field) : base(fileName, field)
        {
            ProductPriceList = new Dictionary<double, string>();
            StoreNumber = 0;
        }

        // Update method gets called when an input file is selected
        public void UpdateStore(int storeNumber)
        {
            this.StoreNumber = storeNumber;
            populateProductPriceList();
        }

        private void populateProductPriceList()
        {
            ProductPriceList = new Dictionary<double, string>();

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

                        try
                        {
                            if (int.Parse(fields[0]) == StoreNumber) // only add UPCs from the current store to the ProductPriceList
                            {
                                // add to dictionary (key=UPC (string parsed to double), value=price as string)
                                ProductPriceList.Add(double.Parse(fields[1]), fields[2]);
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
}
