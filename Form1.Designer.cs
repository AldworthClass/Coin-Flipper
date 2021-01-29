namespace Coin_Flipper
{
    partial class FormCoinFlip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgCoin = new System.Windows.Forms.PictureBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblHeads = new System.Windows.Forms.Label();
            this.lblTails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCoin
            // 
            this.imgCoin.BackColor = System.Drawing.Color.Transparent;
            this.imgCoin.Image = global::Coin_Flipper.Properties.Resources.heads;
            this.imgCoin.Location = new System.Drawing.Point(22, 46);
            this.imgCoin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.imgCoin.Name = "imgCoin";
            this.imgCoin.Size = new System.Drawing.Size(220, 220);
            this.imgCoin.TabIndex = 0;
            this.imgCoin.TabStop = false;
            this.imgCoin.Click += new System.EventHandler(this.imgCoin_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(40, 9);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(188, 24);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Click the coin to flip it.";
            // 
            // lblHeads
            // 
            this.lblHeads.AutoSize = true;
            this.lblHeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeads.Location = new System.Drawing.Point(24, 290);
            this.lblHeads.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeads.Name = "lblHeads";
            this.lblHeads.Size = new System.Drawing.Size(85, 24);
            this.lblHeads.TabIndex = 2;
            this.lblHeads.Text = "Heads: 0";
            // 
            // lblTails
            // 
            this.lblTails.AutoSize = true;
            this.lblTails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTails.Location = new System.Drawing.Point(141, 290);
            this.lblTails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTails.Name = "lblTails";
            this.lblTails.Size = new System.Drawing.Size(69, 24);
            this.lblTails.TabIndex = 3;
            this.lblTails.Text = "Tails: 0";
            // 
            // FormCoinFlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(272, 331);
            this.Controls.Add(this.lblTails);
            this.Controls.Add(this.lblHeads);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.imgCoin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormCoinFlip";
            this.Text = "Flip the Coin";
            this.Load += new System.EventHandler(this.FormCoinFlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCoin;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblHeads;
        private System.Windows.Forms.Label lblTails;
    }
}

