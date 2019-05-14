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
    public partial class DeleteCreditProduct : Form
    {
        private int selectedRecord;

        public DeleteCreditProduct(int selectedRecord)
        {
            InitializeComponent();
            this.selectedRecord = selectedRecord;
        }

        private void DeleteCreditProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
