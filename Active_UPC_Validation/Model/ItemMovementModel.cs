using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Active_UPC_Validation.Model
{
    class ItemMovementModel : SpreadsheetModel, IStoreDependent
    {
        public int StoreNumber { get; private set; }

        public Dictionary<double,int> ProductMovementList { get; private set; }

        public ItemMovementModel(string fileName, string path) : base(fileName, path)
        {
            ProductMovementList = new Dictionary<double, int>();
            StoreNumber = 0;
        }

        public void UpdateStore(int storeNumber)
        {
            this.StoreNumber = storeNumber;
            populateProductMovementList();
        }

        private void populateProductMovementList()
        {
            ProductMovementList = new Dictionary<double, int>();

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
                                // add to dictionary (key=UPC (string parsed to double), value=movement int)
                                ProductMovementList.Add(double.Parse(fields[1]), int.Parse(fields[2]));
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
