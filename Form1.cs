using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Flipper
{
    public partial class FormCoinFlip : Form
    {
        Random generator = new Random();
        int heads, tails, flip;

        private void imgCoin_Click(object sender, EventArgs e)
        {
            flip = generator.Next(2);
            if (flip == 0)
            {
                heads += 1;
                lblHeads.Text = "Heads " + heads;
                imgCoin.Image = Properties.Resources.heads;
            }
            else
            {
                tails += 1;
                lblTails.Text = "Tails: " + tails;
                imgCoin.Image = Properties.Resources.tails;
            }
        }

        private void FormCoinFlip_Load(object sender, EventArgs e)
        {
            heads = 0;
            tails = 0;
        }

        public FormCoinFlip()
        {
            InitializeComponent();
        }
    }
}
