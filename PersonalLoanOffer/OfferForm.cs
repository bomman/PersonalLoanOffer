using System;
using System.Linq;
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
            decimal interestRate = decimal.Parse(this.interestRateTextBox.Text.Remove(this.interestRateTextBox.Text.Length - 1));
            int periods = this.periodTrackBar.Value;
            decimal creditAmount = this.creditAmountTrackBar.Value;
            decimal payment = (creditAmount * (1 - (1 + interestRate) - periods) / interestRate) * -1;
            this.paymentTextBox.Text = string.Format("{0:0.00}", payment);
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

        private void OfferForm_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter1.Fill(this.personalLoanOfferDataSet.CLIENT);
            this.crediT_PRODUCTTableAdapter1.Fill(this.personalLoanOfferDataSet.CREDIT_PRODUCT);
            this.proD_PERIODSTableAdapter.Fill(this.personalLoanOfferDataSet.PROD_PERIODS);
            this.interestTableAdapter.Fill(this.personalLoanOfferDataSet.INTEREST);
            var periods = this.personalLoanOfferDataSet.PROD_PERIODS.Min(p => p.PROD_PERIOD);
            var filtered = this.personalLoanOfferDataSet.CREDIT_PRODUCT.Where(cp => cp.PROD_ACTIVE == "Y").ToList();
            this.creditProductComboBox.DataSource = filtered;
            int selectedProductCode = (int)this.creditProductComboBox.SelectedValue;
             
            int minPeriod = this.personalLoanOfferDataSet.INTEREST.Min(p => p.PROD_PERIOD);
            int maxPeriod = this.personalLoanOfferDataSet.INTEREST.Max(p => p.PROD_PERIOD);
            int currentPeriod = minPeriod;

            this.periodTrackBar.Minimum = minPeriod;
            this.periodTrackBar.Maximum = maxPeriod;
            this.periodLabel.Text = minPeriod.ToString();
            decimal minCreditAmount = this.personalLoanOfferDataSet.INTEREST
                .Where(i => i.PROD_CODE == selectedProductCode && i.PROD_PERIOD == currentPeriod)
                .Select(i => i.SUM_FROM).FirstOrDefault();
            decimal maxCreditAmount = this.personalLoanOfferDataSet.INTEREST
                .Where(i => i.PROD_CODE == selectedProductCode && i.PROD_PERIOD == currentPeriod)
                .Select(i => i.SUM_TO).FirstOrDefault();

            int creditStep = (int)(maxCreditAmount - minCreditAmount) / 10;
            this.creditAmountTrackBar.Minimum = (int)minCreditAmount;
            this.creditAmountTrackBar.Maximum = (int)maxCreditAmount;
            this.creditAmountTrackBar.SmallChange = creditStep;
            this.creditAmountValueLabel.Text = minCreditAmount.ToString();
            decimal interestRate = this.personalLoanOfferDataSet.INTEREST
                .Where(i => i.PROD_CODE == selectedProductCode && i.PROD_PERIOD == currentPeriod)
                .Select(i => i.INTEREST_RATE).FirstOrDefault();
            this.interestRateTextBox.Text = string.Format("{0:0.00}%", interestRate);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.creditAmountValueLabel.Text = this.creditAmountTrackBar.Value.ToString();
        }

        private void periodTrackBar_Scroll(object sender, EventArgs e)
        {
            this.periodValueLabel.Text = this.periodTrackBar.Value.ToString();
        }

        private void saveOfferButton_Click(object sender, EventArgs e)
        {
            Random getrandom = new Random();
            string creditNumber = getrandom.Next(1000, 9999).ToString();
            int period = this.periodTrackBar.Value;
            
            int clientID = this.personalLoanOfferDataSet.CLIENT.Select(cl => cl.CLIENT_ID).FirstOrDefault();
            int productCode = (int) this.creditProductComboBox.SelectedValue;
            decimal creditAmount = this.creditAmountTrackBar.Value;
            decimal maturitySum = decimal.Parse(this.paymentTextBox.Text);
            var creditID = this.creditTableAdapter.InsertQuery(creditNumber, DateTime.Now, period, DateTime.Now.AddYears(period), DateTime.Now, clientID, productCode, creditAmount, "", null);
            this.crediT_PLANTableAdapter1.Insert((int)creditID, DateTime.Now.AddYears(period), maturitySum, string.Empty, null);
        }
    }
}
