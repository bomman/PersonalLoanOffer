using System;
using System.Windows.Forms;

namespace PersonalLoanOffer.CreditProducts
{
    public partial class DeleteCreditProduct : Form
    {
        private int selectedRecord;
        private PersonalLoanOfferDataSet _personalLoanOfferDataSet;
        private DataGridView _parentDataGridView;

        public DeleteCreditProduct(int selectedRecord, PersonalLoanOfferDataSet personalLoanOfferDataSet, DataGridView clientProductsGridView)
        {
            InitializeComponent();
            this.selectedRecord = selectedRecord;
            _personalLoanOfferDataSet = personalLoanOfferDataSet;
            _parentDataGridView = clientProductsGridView;
        }

        private void DeleteCreditProduct_Load(object sender, EventArgs e)
        {
            var creditProduct = _personalLoanOfferDataSet.CREDIT_PRODUCT.FindByPROD_CODE(selectedRecord);

            //.FirstOrDefault(cr => cr.PROD_CODE == selectedRecord);
            nameTextBox.Text = creditProduct.PROD_NAME;
            var status = creditProduct.PROD_ACTIVE == "Y" ? "Yes" : "No";
            statusComboBox.SelectedIndex = statusComboBox.FindString(status);
            sumFromUpDown.Value = creditProduct.PROD_SUM_FROM;
            sumToUpDown.Value = creditProduct.PROD_SUM_TO;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var creditProduct = _personalLoanOfferDataSet.CREDIT_PRODUCT.FindByPROD_CODE(selectedRecord);
            crediT_PRODUCTTableAdapter1.Delete(creditProduct.PROD_CODE, creditProduct.PROD_NAME, creditProduct.PROD_ACTIVE, creditProduct.PROD_SUM_FROM, creditProduct.PROD_SUM_TO, creditProduct.MODIF_DATE);

            crediT_PRODUCTTableAdapter1.Fill(this.crediT_PRODUCTTableAdapter1.GetData());
            Close();
        }
    }
}
