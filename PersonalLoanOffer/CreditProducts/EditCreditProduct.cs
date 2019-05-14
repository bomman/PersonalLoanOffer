using System;
using System.Windows.Forms;

namespace PersonalLoanOffer.CreditProducts
{
    public partial class EditCreditProduct : Form
    {
        private int selectedRecord;
        private PersonalLoanOfferDataSet _personalLoanOfferDataSet;

        public EditCreditProduct(int selectedRecord, PersonalLoanOfferDataSet personalLoanOfferDataSet)
        {
            InitializeComponent();
            this.selectedRecord = selectedRecord;
            _personalLoanOfferDataSet = personalLoanOfferDataSet;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var creditProduct = _personalLoanOfferDataSet.CREDIT_PRODUCT.FindByPROD_CODE(selectedRecord);
            creditProduct.PROD_NAME = this.nameTextBox.Text;
            creditProduct.PROD_ACTIVE = this.statusComboBox.Text == "Yes" ? "Y" : "N";
            creditProduct.PROD_SUM_FROM = this.sumFromUpDown.Value;
            creditProduct.PROD_SUM_TO = this.sumToUpDown.Value;
            creditProduct.MODIF_DATE = DateTime.Now;
            crediT_PRODUCTTableAdapter1.Update(creditProduct);

            Close();
        }

        private void EditCreditProduct_Load(object sender, EventArgs e)
        {
            var creditProduct = _personalLoanOfferDataSet.CREDIT_PRODUCT.FindByPROD_CODE(selectedRecord);

            //.FirstOrDefault(cr => cr.PROD_CODE == selectedRecord);
            this.nameTextBox.Text = creditProduct.PROD_NAME;
            var status = creditProduct.PROD_ACTIVE == "Y" ? "Yes" : "No";
            this.statusComboBox.SelectedIndex = statusComboBox.FindString(status);
            this.sumFromUpDown.Value = creditProduct.PROD_SUM_FROM;
            this.sumToUpDown.Value = creditProduct.PROD_SUM_TO;
        }
    }
}
