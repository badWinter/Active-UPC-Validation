using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Active_UPC_Validation.Model;
using Active_UPC_Validation.ViewModel;

namespace Active_UPC_Validation
{
    public partial class Form1 : Form
    {
        SpreadsheetViewModel sheetViewModel;

        public Form1()
        {
            InitializeComponent();

            sheetViewModel = new SpreadsheetViewModel();

            startButton.Enabled = false;
            outputFolderButton.Enabled = false;
            updateButton.Enabled = false; // when implemented, button will start out enabled

            UpdatePricing();

        }

        private void UpdatePricing()
        {
            sheetViewModel.UpdatePricingSheets();
            catalogBox.Text = sheetViewModel.Catalog;
            regPriceBox.Text = sheetViewModel.RegPrice;
            itemMovementBox.Text = sheetViewModel.ItemMovement;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                importBox.Text = openFileDialog1.FileName;
                sheetViewModel.ImportSheet(openFileDialog1.FileName, openFileDialog1.FileName);
                importStoreBox.Text = sheetViewModel.CurrentStore.ToString();
                startButton.Enabled = true;
            }
        }

        private void outputFolderButton_Click(object sender, EventArgs e)
        {
            // TODO:
            // call folderBrowserDialog to chose a new directory to save output to
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // TODO:
            // call spreadsheetViewModel's GenerateValidationList method
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // TODO:
            // implement ability to update pricing sheets
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
