using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalLoanOffer.Offers
{
    public partial class OfferDetails : Form
    {
        private int selectedRecord;
        private PersonalLoanOfferDataSet personalLoanOfferDataSet;

        public OfferDetails(int selectedRecord, PersonalLoanOfferDataSet personalLoanOfferDataSet)
        {
            InitializeComponent();
            this.selectedRecord = selectedRecord;
            this.personalLoanOfferDataSet = personalLoanOfferDataSet;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OfferDetails_Load(object sender, EventArgs e)
        {
            var offer = personalLoanOfferDataSet.CREDIT.FirstOrDefault(c => c.CREDIT_ID == selectedRecord);
            if (offer != null)
            {
                offerNumbeTextBox.Text = offer.CREDIT_NO;
                dateTimePicker.Value = offer.CREDIT_DATE;
                periodTextBox.Text = offer.CREDIT_PERIOD.ToString();
                startDateTimePicker.Value = offer.CREDIT_BEGIN_DATE;
                endDateTimePicker.Value = offer.CREDIT_END_DATE;
                var client = personalLoanOfferDataSet.CLIENT
                    ?.FirstOrDefault(c => c.CLIENT_ID == offer.CLIENT_ID);
                this.clientTextBox.Text = client?.CLIENT_FULLNAME;
                var product = personalLoanOfferDataSet.CREDIT_PRODUCT
                    ?.FirstOrDefault(p => p.PROD_CODE == offer.PROD_CODE);
                productTextBox.Text = product?.PROD_NAME;
                amountTextBox.Text = offer.CREDIT_SUM.ToString();
                notesRichTextBox.Text = offer.CREDIT_NOTE;
            }
        }
    }
}
