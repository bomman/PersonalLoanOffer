using PersonalLoanOffer.CreditProducts;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PersonalLoanOffer
{
    public partial class CreditProductsForm : Form
    {
        public CreditProductsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalLoanOfferDataSet.CREDIT_PRODUCT' table. You can move, or remove it, as needed.
            this.cREDIT_PRODUCTTableAdapter.Fill(this.personalLoanOfferDataSet.CREDIT_PRODUCT);
            var creditProducts = this.personalLoanOfferDataSet.CREDIT_PRODUCT;
        }

        private void searchButton_OnClick(object sender, EventArgs e)
        {
            var codeTextBox = this.codeTextBox.Text;
            var nameTextBox = this.nameTextBox.Text;
            var status = this.statusComboBox.Text == "Yes" ? "Y" : "N";
            var sumFrom = this.sumFromUpDown.Value;
            var sumTo = this.sumToUpDown.Value;
            
            var creditProducts = this.personalLoanOfferDataSet.CREDIT_PRODUCT
                .Where(p => p.PROD_CODE.ToString().Contains(codeTextBox)
                            && p.PROD_NAME.Contains(nameTextBox)
                            && p.PROD_ACTIVE == status
                            && p.PROD_SUM_FROM >= sumFrom
                            && p.PROD_SUM_TO <= sumTo
                ).ToList();

            this.clientProductsGridView.DataSource = creditProducts;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCreditProduct addCreditForm = new AddCreditProduct();
            addCreditForm.MdiParent = this.ParentForm;
            addCreditForm.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditCreditProduct editCreditForm = new EditCreditProduct();
            editCreditForm.MdiParent = this.ParentForm;
            editCreditForm.Show();
        }
    }
}
