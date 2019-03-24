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
    public partial class OfferForm : Form
    {
        public OfferForm()
        {
            InitializeComponent();
        }

        private void paymentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generateOfferButton_Click(object sender, EventArgs e)
        {
            this.offerTabsView.Visible = true;
        }

        private void calculatePaymentButton_Click(object sender, EventArgs e)
        {
            this.paymentTextBox.Text = "6 000 000";
        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click_1(object sender, EventArgs e)
        {

            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = this.repaymentPrintDocument;
            printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                this.repaymentPrintDocument.DocumentName = "Test Page Print";
                this.repaymentPrintDocument.Print();
            }
            
        }
    }
}
