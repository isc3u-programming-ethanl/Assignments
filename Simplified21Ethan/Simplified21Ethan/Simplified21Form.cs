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
        public frmSimplified21()
        {
            InitializeComponent();
        }

        private void FrmSimplified21_Load(object sender, EventArgs e)
        {
            this.btnHit.Visible = false;
            this.btnStay.Visible = false;
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
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {

        }

        private void BtnStay_Click(object sender, EventArgs e)
        {

        }
    }
}
