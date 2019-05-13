using System;
using System.Windows.Forms;

namespace PersonalLoanOffer.CreditProducts
{
    public partial class AddCreditProduct : Form
    {
        public AddCreditProduct()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var status = statusComboBox.Text == "Yes" ? "Y" : "N";
            var sumFrom = sumFromUpDown.Value;
            var sumTo = sumToUpDown.Value;
            personalLoanOfferDataSet1.CREDIT_PRODUCT
                .AddCREDIT_PRODUCTRow(name, status, sumFrom, sumTo, DateTime.Now);
            personalLoanOfferDataSet1.CREDIT_PRODUCT.AcceptChanges();
            this.Close();
        }
    }
}
