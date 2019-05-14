using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonalLoanOffer.Offers
{
    public partial class EditOffer : Form
    {
        private int selectedRecord;
        private PersonalLoanOfferDataSet personalLoanOfferDataSet;

        public EditOffer(int selectedRecord, PersonalLoanOfferDataSet personalLoanOfferDataSet)
        {
            InitializeComponent();
            this.selectedRecord = selectedRecord;
            this.personalLoanOfferDataSet = personalLoanOfferDataSet;
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            var offer = personalLoanOfferDataSet.CREDIT.FirstOrDefault(c => c.CREDIT_ID == selectedRecord);
            if (offer != null)
            {
                offer.CREDIT_NO = offerNumbeTextBox.Text;
                offer.CREDIT_DATE = dateTimePicker.Value;
                offer.CREDIT_PERIOD = int.Parse(periodUpDown.Text);
                offer.CREDIT_BEGIN_DATE = startDateTimePicker.Value;
                offer.CREDIT_END_DATE = endDateTimePicker.Value;
                offer.CREDIT_SUM = amountUpDown.Value;
                offer.CREDIT_NOTE = notesRichTextBox.Text;
                offer.MODIF_DATE = DateTime.Now;
            }

            this.creditTableAdapter1.Update(offer);

            Close();
        }

        private void EditOffer_Load(object sender, EventArgs e)
        {
            var offer = personalLoanOfferDataSet.CREDIT.FirstOrDefault(c => c.CREDIT_ID == selectedRecord);
            if (offer != null)
            {
                offerNumbeTextBox.Text = offer.CREDIT_NO;
                dateTimePicker.Value = offer.CREDIT_DATE;
                periodUpDown.Text = offer.CREDIT_PERIOD.ToString();
                startDateTimePicker.Value = offer.CREDIT_BEGIN_DATE;
                endDateTimePicker.Value = offer.CREDIT_END_DATE;
                amountUpDown.Text = offer.CREDIT_SUM.ToString();
                notesRichTextBox.Text = offer.CREDIT_NOTE;
            }
        }
    }
}
