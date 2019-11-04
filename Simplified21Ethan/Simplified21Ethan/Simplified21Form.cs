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
            this.lblYouWin.Visible = false;
            this.lblYouLose.Visible = false;
            this.lblYouTie.Visible = false;
            this.lblOneOrEleven.Visible = false;
            this.btnOne.Visible = false;
            this.btnEleven.Visible = false;
            this.lblPlayerTotal.Visible = false;
            this.lblDealerTotal.Visible = false;
        }

        private void LblTitleText_Click(object sender, EventArgs e)
        {

        }

        private void BtnStay_Click(object sender, EventArgs e)
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
            this.lblDealerCard3.Visible = true;
            this.lblPlayerTotal.Visible = true;
            this.lblDealerTotal.Visible = true;


            // declare local variables and constants
            int playerTotal = 0;
            int dealerTotal = 0;
            int card1;
            int card2;
            int card3;
            int dealerCard1;
            int dealerCard2;
            int dealerCard3;
           

            // make random number generator variables
            const int MIN_VALUE = 1;
            const int MAX_VALUE = 10;
            Random randomNumberGenerator = new Random();

            // get the random generated player card numbers
            card1 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            card2 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            card3 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // get the random generated dealer card numbers
            dealerCard1 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            dealerCard2 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            dealerCard3 = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // set the totals for player and dealer
            playerTotal = card1 + card2;
            dealerTotal = dealerCard1 + dealerCard2 + dealerCard3;

            this.lblPlayerCard1.Text = Convert.ToString(card1);
            this.lblPlayerCard2.Text = Convert.ToString(card2);
            this.lblPlayerCard3.Text = Convert.ToString(card3);

            this.lblDealerCard1.Text = Convert.ToString(dealerCard1);
            this.lblDealerCard2.Text = Convert.ToString(dealerCard2);
            this.lblDealerCard3.Text = Convert.ToString(dealerCard3);

            this.lblPlayerTotal.Text = Convert.ToString(playerTotal);
            this.lblDealerTotal.Text = Convert.ToString(dealerTotal);


            if (playerTotal == dealerTotal)
            {
                this.lblYouTie.Visible = true;
            }
            if (playerTotal <= 21)
                if (dealerTotal > 21)
                {
                    this.lblYouWin.Visible = true;
                }
             if (playerTotal > 21)
                if (dealerTotal <= 21)
                {
                    this.lblYouLose.Visible = true;
                }
             if (playerTotal == 21)
                if (dealerTotal < 21)
                {
                    this.lblYouWin.Visible = true;
                }
             if (playerTotal < 21)
                if (dealerTotal == 21)
                {
                    this.lblYouLose.Visible = true;
                }

            if (card1 == 1)
            {
                this.btnOne.Visible = true;
                this.btnEleven.Visible = true;
                this.lblOneOrEleven.Visible = true;

            }

            if (card2 == 1)
            {
                this.btnOne.Visible = true;
                this.btnEleven.Visible = true;
                this.lblOneOrEleven.Visible = true;

            }
        }
        private void BtnHit_Click(object sender, EventArgs e)
        {
            this.lblPlayerCard3.Visible = true;
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            // hide the menu for "1 or 11"
            this.lblOneOrEleven.Visible = false;
            this.btnOne.Visible = false;
            this.btnEleven.Visible = false;
        }

        private void BtnEleven_Click(object sender, EventArgs e)
        {
            // hide the menu for "1 or 11"
            this.lblOneOrEleven.Visible = false;
            this.btnOne.Visible = false;
            this.btnEleven.Visible = false;
        }
    }
}
