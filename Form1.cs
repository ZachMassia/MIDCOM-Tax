using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MIDCOM_Tax
{
    public partial class Form1 : Form
    {
        public MIDCOM.TaxFile taxFile = new();

        public Form1()
        {
            InitializeComponent();

            // Custom Inits
            InitTaxDataGrid();
            InitTaxCodeGrid();
        }

        private void InitTaxDataGrid()
        {
            var bindingList = new BindingList<MIDCOM.TaxEntry>(taxFile.Taxes);
            var source = new BindingSource(bindingList, null);
            taxEntryGrid.DataSource = source;

            taxEntryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            taxEntryGrid.Columns["Label"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Set the column header displays.
            taxEntryGrid.Columns["TaxRate"].HeaderText = "Generated Tax Rate";
            taxEntryGrid.Columns["TaxType"].HeaderText = "Tax Type ($/%)";
            taxEntryGrid.Columns["CompoundTax"].HeaderText = "Tax Subtotal? (Y\\N)";
            taxEntryGrid.Columns["TaxRateDecimal"].HeaderText = "Decimal Tax Rate (XX.XXXX)";

            // TODO: Make first entry read-only.
            // This doesn't seem to work.
            //taxEntryGrid.Rows[0].ReadOnly = true;
        }

        private void InitTaxCodeGrid()
        {
            var bindingList = new BindingList<MIDCOM.Product>(taxFile.Products);
            var source = new BindingSource(bindingList, null);
            taxCodeGrid.DataSource = source;

            taxCodeGrid.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            taxCodeGrid.Columns["TaxCode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // TODO: Make first entry read-only.
            // This doesn't seem to work.
            taxCodeGrid.Rows[0].ReadOnly = true;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = "C:\\";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the specified file.
                    filePath = fileDialog.FileName;

                    // Read the contents of the file into a stream.
                    var fileStream = fileDialog.OpenFile();

                    using (var reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
        }
    }
}