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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void offerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfferForm offerForm = new OfferForm();
            offerForm.MdiParent = this;
            offerForm.Show();
        }

        private void clientProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditProductsForm cpf = new CreditProductsForm();
            cpf.MdiParent = this;
            cpf.Show();
        }

        private void listOffersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var offerLst = new OfferList();
            offerLst.MdiParent = this;
            offerLst.Show();
        }
    }
}
