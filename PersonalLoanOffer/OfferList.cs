using PersonalLoanOffer.Offers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalLoanOffer
{
    public partial class OfferList : Form
    {
        public OfferList()
        {
            InitializeComponent();
        }

        private void OfferList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalLoanOfferDataSet.CREDIT' table. You can move, or remove it, as needed.
            this.cREDITTableAdapter.Fill(this.personalLoanOfferDataSet.CREDIT);
        }

        private void searchButton_OnClick(object sender, EventArgs e)
        {
            var offerNumber = this.offerNumberUpDown.Value;
            var description = this.descriptionTextBox.Text;
            var creditAmount = this.creditAmountUpDown.Value;
            var interestRate = this.interestRateUpDown.Value;
            var startDate = this.startDateTimePicker.Value;
            var endDate = this.endDateTimePicker.Value;

            var interests = this.personalLoanOfferDataSet.INTEREST
                .Where(i => i.SUM_FROM <= interestRate && i.SUM_TO >= interestRate)
                .Select(i => i.PROD_CODE);

            var offers = this.personalLoanOfferDataSet.CREDIT
                .Where(c => c.CREDIT_NO.Contains(offerNumber.ToString())
                && c.CREDIT_NOTE.Contains(description)
                && interests.Contains(c.PROD_CODE)
                && c.CREDIT_SUM == creditAmount
                && c.CREDIT_BEGIN_DATE == startDate
                && c.CREDIT_END_DATE == endDate);

            this.offerDataGridView.DataSource = offers;
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            var selectedRecord = int.Parse(this.offerDataGridView.CurrentRow.Cells[0].Value.ToString());

            OfferDetails offerDetails = new OfferDetails(selectedRecord, this.personalLoanOfferDataSet);
            offerDetails.MdiParent = this.ParentForm;
            offerDetails.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedRecord = int.Parse(this.offerDataGridView.CurrentRow.Cells[0].Value.ToString());

            EditOffer editOfferForm = new EditOffer(selectedRecord, this.personalLoanOfferDataSet);
            editOfferForm.MdiParent = this.ParentForm;
            editOfferForm.Show();
        }
    }
}
