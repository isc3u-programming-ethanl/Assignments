using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21Ethan
{
    public partial class frmSimplified21 : Form
    {
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 10;
        Random randomNumberGenerator;

        public frmSimplified21()
        {
            InitializeComponent();

            // create the random number generator object
            randomNumberGenerator = new Random();
        }

        private void FrmSimplified21_Load(object sender, EventArgs e)
        {
            this.btnHit.Visible = false;
            this.btnStay.Visible = false;
            this.lblPlayerCard1.Visible = false;
            this.lblPlayerCard2.Visible = false;
            this.lblPlayerCard3.Visible = false;
            this.lblDealerCard1.Visible = false;
            this.lblDealerCard2.Visible = false;
            this.lblDealerCard3.Visible = false;
        }

        private void LblTitleText_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.btnHit.Visible = true;
            this.btnStay.Visible = true;
            this.lblTitleText.Visible = false;
            this.btnStart.Visible = false;
            this.lblPlayerCard1.Visible = true;
            this.lblPlayerCard2.Visible = true;
            this.lblPlayerCard3.Visible = false;
            this.lblDealerCard1.Visible = true;
            this.lblDealerCard2.Visible = true;
            this.lblDealerCard3.Visible = false;

            // declare local variables and constants
            int playerTotal, dealerTotal;
            const int card1 = 1;
            const int card2 = 2;
            const int card3 = 3;
            const int card4 = 4;
            const int card5 = 5;
            const int card6 = 6;
            const int card7 = 7;
            const int card8 = 8;
            const int card9 = 9;
            const int card10 = 10;

       

        }

        private void BtnHit_Click(object sender, EventArgs e)
        {

        }

        private void BtnStay_Click(object sender, EventArgs e)
        {

        }
    }
}
