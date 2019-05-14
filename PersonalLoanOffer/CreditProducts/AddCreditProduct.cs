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
            this.crediT_PRODUCTTableAdapter1.Insert(name, status, sumFrom, sumTo, DateTime.Now);

            //this.bindingSource1.DataSource = personalLoanOfferDataSet1.CREDIT_PRODUCT.;
            //this.bindingSource1.Add(personalLoanOfferDataSet1.CREDIT_PRODUCT
            //    .AddCREDIT_PRODUCTRow(name, status, sumFrom, sumTo, DateTime.Now));

            //personalLoanOfferDataSet1.CREDIT_PRODUCT.AcceptChanges();
            this.ParentForm.Refresh();

            this.Close();
        }
    }
}
