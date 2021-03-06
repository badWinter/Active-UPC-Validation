﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Active_UPC_Validation.Model;
using System.Windows.Forms;

namespace Active_UPC_Validation.ViewModel
{
    class SpreadsheetViewModel
    {
        private CatalogModel catalog;
        public string Catalog { get { return catalog.FileName; } }
        private RegPriceModel regPrice;
        public string RegPrice { get { return regPrice.FileName; } }
        private ItemMovementModel itemMovement;
        public string ItemMovement { get { return itemMovement.FileName; } }
        private ActiveItemModel activeItem;
        private OutputModel output;

        public int CurrentStore { get; set; }

        public SpreadsheetViewModel()
        {
            catalog = new CatalogModel("CATALOG", "AssetSheets\\CATALOG.csv");
            regPrice = new RegPriceModel("REGULAR_PRICE", "AssetSheets\\REGULAR_PRICE.csv");
            itemMovement = new ItemMovementModel("ITEM_MOVEMENT", "AssetSheets\\ITEM_MOVEMENT.csv");
            CurrentStore = 0;
        }

        public void UpdatePricingSheets()
        {
            catalog.UpdateCatalog();
            regPrice.UpdateStore(CurrentStore);
            itemMovement.UpdateStore(CurrentStore);
        }

        public void ImportSheet(string fileName, string path)
        {
            activeItem = new ActiveItemModel(fileName, path);
            CurrentStore = activeItem.StoreNumber;
            UpdatePricingSheets();
        }


        public void GenerateValidationList(string fileName, string path)
        {
            // TODO:
            // create a query to check items in ActiveItemModel dict against items in Catalog, RegPrice, and ItemMovement
            // stick results into output object and write out to a new file
            output = new OutputModel(fileName, path);

            if (activeItem != null)
            {
                foreach (double upc in activeItem.UpcList)
                {
                    if (!(catalog.ProductList.ContainsKey(upc) || regPrice.ProductPriceList.ContainsKey(upc) || itemMovement.ProductMovementList.ContainsKey(upc)))
                    {
                        output.AppendCsvOutput(upc.ToString());
                    }
                }
            }

            if (output.CsvOutput == "")
                MessageBox.Show("No invalid upcs found; no output file will be written");
            else 
                output.WriteOutput();

        }

    }
}
