using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLoanOffer.CreditProducts
{
    public partial class EditCreditProduct : Form
    {
        private int selectedRecord;

        public EditCreditProduct(int selectedRecord)
        {
            InitializeComponent();
            this.selectedRecord = selectedRecord;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            
        }

        private void EditCreditProduct_Load(object sender, EventArgs e)
        {
            var creditProduct = this.personalLoanOfferDataSet1.CREDIT_PRODUCT.FirstOrDefault(cr => cr.PROD_CODE == selectedRecord);
            this.nameTextBox.Text = creditProduct.PROD_NAME;
            var status = creditProduct.PROD_ACTIVE == "Y" ? "Yes" : "No";
            this.statusComboBox.SelectedIndex = this.statusComboBox.FindString(status);
            this.sumFromUpDown.Value = creditProduct.PROD_SUM_FROM;
            this.sumToUpDown.Value = creditProduct.PROD_SUM_TO;
        }
    }
}
