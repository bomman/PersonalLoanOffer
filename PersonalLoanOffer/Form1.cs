using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLoanOffer
{
    public partial class CreditProductsForm : Form
    {
        public CreditProductsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalLoanOfferDataSet.CREDIT_PRODUCT' table. You can move, or remove it, as needed.
            this.cREDIT_PRODUCTTableAdapter.Fill(this.personalLoanOfferDataSet.CREDIT_PRODUCT);
            var creditProducts = this.personalLoanOfferDataSet.CREDIT_PRODUCT;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = this.searchTextBox.Text;
            var creditProducts = this.personalLoanOfferDataSet.CREDIT_PRODUCT
                .Where(p => p.PROD_CODE.ToString().Contains(searchText)
                            || p.PROD_NAME.Contains(searchText)
                            || p.PROD_SUM_FROM.ToString().Contains(searchText)
                );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sumToLabel_Click(object sender, EventArgs e)
        {

        }

        private void controlsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void pROD_CODETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pROD_CODELabel_Click(object sender, EventArgs e)
        {

        }
    }
}
