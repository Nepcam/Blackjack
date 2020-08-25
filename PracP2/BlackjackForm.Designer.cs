namespace PracP2
{
    partial class BlackjackForm
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
            this.buttonQuit_ = new System.Windows.Forms.Button();
            this.labelDealerTotal_ = new System.Windows.Forms.Label();
            this.labelPLayerTotal_ = new System.Windows.Forms.Label();
            this.textBoxDealerTotal_ = new System.Windows.Forms.TextBox();
            this.textBoxPlayerTotal_ = new System.Windows.Forms.TextBox();
            this.buttonDealSecondCard_ = new System.Windows.Forms.Button();
            this.labelMoneyLeft_ = new System.Windows.Forms.Label();
            this.textBoxMoneyLeft_ = new System.Windows.Forms.TextBox();
            this.labelMoneyToBet_ = new System.Windows.Forms.Label();
            this.labelDealerCard2_ = new System.Windows.Forms.Label();
            this.labelDealerCard1_ = new System.Windows.Forms.Label();
            this.labelPlayerCard2_ = new System.Windows.Forms.Label();
            this.labelPlayerCard1_ = new System.Windows.Forms.Label();
            this.textBoxBet_ = new System.Windows.Forms.TextBox();
            this.buttonDealFirstCard_ = new System.Windows.Forms.Button();
            this.listBoxPlayerCards = new System.Windows.Forms.ListBox();
            this.listBoxDealerCards = new System.Windows.Forms.ListBox();
            this.buttonThirdCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalculateWin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQuit_
            // 
            this.buttonQuit_.Location = new System.Drawing.Point(430, 308);
            this.buttonQuit_.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuit_.Name = "buttonQuit_";
            this.buttonQuit_.Size = new System.Drawing.Size(154, 28);
            this.buttonQuit_.TabIndex = 37;
            this.buttonQuit_.Text = "Quit";
            this.buttonQuit_.UseVisualStyleBackColor = true;
            this.buttonQuit_.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // labelDealerTotal_
            // 
            this.labelDealerTotal_.AutoSize = true;
            this.labelDealerTotal_.Location = new System.Drawing.Point(279, 179);
            this.labelDealerTotal_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDealerTotal_.Name = "labelDealerTotal_";
            this.labelDealerTotal_.Size = new System.Drawing.Size(68, 13);
            this.labelDealerTotal_.TabIndex = 36;
            this.labelDealerTotal_.Text = "Dealer\'s total";
            // 
            // labelPLayerTotal_
            // 
            this.labelPLayerTotal_.AutoSize = true;
            this.labelPLayerTotal_.Location = new System.Drawing.Point(17, 179);
            this.labelPLayerTotal_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPLayerTotal_.Name = "labelPLayerTotal_";
            this.labelPLayerTotal_.Size = new System.Drawing.Size(66, 13);
            this.labelPLayerTotal_.TabIndex = 35;
            this.labelPLayerTotal_.Text = "Player\'s total";
            // 
            // textBoxDealerTotal_
            // 
            this.textBoxDealerTotal_.Location = new System.Drawing.Point(391, 179);
            this.textBoxDealerTotal_.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDealerTotal_.Name = "textBoxDealerTotal_";
            this.textBoxDealerTotal_.ReadOnly = true;
            this.textBoxDealerTotal_.Size = new System.Drawing.Size(137, 20);
            this.textBoxDealerTotal_.TabIndex = 34;
            // 
            // textBoxPlayerTotal_
            // 
            this.textBoxPlayerTotal_.Location = new System.Drawing.Point(127, 179);
            this.textBoxPlayerTotal_.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlayerTotal_.Name = "textBoxPlayerTotal_";
            this.textBoxPlayerTotal_.ReadOnly = true;
            this.textBoxPlayerTotal_.Size = new System.Drawing.Size(137, 20);
            this.textBoxPlayerTotal_.TabIndex = 33;
            // 
            // buttonDealSecondCard_
            // 
            this.buttonDealSecondCard_.Location = new System.Drawing.Point(272, 270);
            this.buttonDealSecondCard_.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDealSecondCard_.Name = "buttonDealSecondCard_";
            this.buttonDealSecondCard_.Size = new System.Drawing.Size(154, 28);
            this.buttonDealSecondCard_.TabIndex = 32;
            this.buttonDealSecondCard_.Text = "Deal Second Card";
            this.buttonDealSecondCard_.UseVisualStyleBackColor = true;
            this.buttonDealSecondCard_.Click += new System.EventHandler(this.buttonDealSecondCard_Click);
            // 
            // labelMoneyLeft_
            // 
            this.labelMoneyLeft_.AutoSize = true;
            this.labelMoneyLeft_.Location = new System.Drawing.Point(40, 245);
            this.labelMoneyLeft_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoneyLeft_.Name = "labelMoneyLeft_";
            this.labelMoneyLeft_.Size = new System.Drawing.Size(56, 13);
            this.labelMoneyLeft_.TabIndex = 31;
            this.labelMoneyLeft_.Text = "Money left";
            // 
            // textBoxMoneyLeft_
            // 
            this.textBoxMoneyLeft_.Location = new System.Drawing.Point(111, 243);
            this.textBoxMoneyLeft_.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMoneyLeft_.Name = "textBoxMoneyLeft_";
            this.textBoxMoneyLeft_.ReadOnly = true;
            this.textBoxMoneyLeft_.Size = new System.Drawing.Size(114, 20);
            this.textBoxMoneyLeft_.TabIndex = 30;
            this.textBoxMoneyLeft_.Text = "$100";
            // 
            // labelMoneyToBet_
            // 
            this.labelMoneyToBet_.AutoSize = true;
            this.labelMoneyToBet_.Location = new System.Drawing.Point(20, 278);
            this.labelMoneyToBet_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoneyToBet_.Name = "labelMoneyToBet_";
            this.labelMoneyToBet_.Size = new System.Drawing.Size(76, 13);
            this.labelMoneyToBet_.TabIndex = 29;
            this.labelMoneyToBet_.Text = "Place a bet ($)";
            // 
            // labelDealerCard2_
            // 
            this.labelDealerCard2_.AutoSize = true;
            this.labelDealerCard2_.Location = new System.Drawing.Point(279, 35);
            this.labelDealerCard2_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDealerCard2_.Name = "labelDealerCard2_";
            this.labelDealerCard2_.Size = new System.Drawing.Size(107, 13);
            this.labelDealerCard2_.TabIndex = 28;
            this.labelDealerCard2_.Text = "Dealer\'s second card";
            // 
            // labelDealerCard1_
            // 
            this.labelDealerCard1_.AutoSize = true;
            this.labelDealerCard1_.Location = new System.Drawing.Point(279, 23);
            this.labelDealerCard1_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDealerCard1_.Name = "labelDealerCard1_";
            this.labelDealerCard1_.Size = new System.Drawing.Size(88, 13);
            this.labelDealerCard1_.TabIndex = 27;
            this.labelDealerCard1_.Text = "Dealer\'s first card";
            // 
            // labelPlayerCard2_
            // 
            this.labelPlayerCard2_.AutoSize = true;
            this.labelPlayerCard2_.Location = new System.Drawing.Point(17, 35);
            this.labelPlayerCard2_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerCard2_.Name = "labelPlayerCard2_";
            this.labelPlayerCard2_.Size = new System.Drawing.Size(105, 13);
            this.labelPlayerCard2_.TabIndex = 26;
            this.labelPlayerCard2_.Text = "Player\'s second card";
            // 
            // labelPlayerCard1_
            // 
            this.labelPlayerCard1_.AutoSize = true;
            this.labelPlayerCard1_.Location = new System.Drawing.Point(17, 22);
            this.labelPlayerCard1_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerCard1_.Name = "labelPlayerCard1_";
            this.labelPlayerCard1_.Size = new System.Drawing.Size(86, 13);
            this.labelPlayerCard1_.TabIndex = 25;
            this.labelPlayerCard1_.Text = "Player\'s first card";
            // 
            // textBoxBet_
            // 
            this.textBoxBet_.Location = new System.Drawing.Point(111, 275);
            this.textBoxBet_.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBet_.Name = "textBoxBet_";
            this.textBoxBet_.Size = new System.Drawing.Size(114, 20);
            this.textBoxBet_.TabIndex = 24;
            // 
            // buttonDealFirstCard_
            // 
            this.buttonDealFirstCard_.Location = new System.Drawing.Point(272, 232);
            this.buttonDealFirstCard_.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDealFirstCard_.Name = "buttonDealFirstCard_";
            this.buttonDealFirstCard_.Size = new System.Drawing.Size(154, 28);
            this.buttonDealFirstCard_.TabIndex = 19;
            this.buttonDealFirstCard_.Text = "Deal First Card";
            this.buttonDealFirstCard_.UseVisualStyleBackColor = true;
            this.buttonDealFirstCard_.Click += new System.EventHandler(this.buttonDealFirstCard_Click);
            // 
            // listBoxPlayerCards
            // 
            this.listBoxPlayerCards.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayerCards.FormattingEnabled = true;
            this.listBoxPlayerCards.ItemHeight = 14;
            this.listBoxPlayerCards.Location = new System.Drawing.Point(127, 16);
            this.listBoxPlayerCards.Name = "listBoxPlayerCards";
            this.listBoxPlayerCards.Size = new System.Drawing.Size(137, 158);
            this.listBoxPlayerCards.TabIndex = 38;
            // 
            // listBoxDealerCards
            // 
            this.listBoxDealerCards.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDealerCards.FormattingEnabled = true;
            this.listBoxDealerCards.ItemHeight = 14;
            this.listBoxDealerCards.Location = new System.Drawing.Point(391, 16);
            this.listBoxDealerCards.Name = "listBoxDealerCards";
            this.listBoxDealerCards.Size = new System.Drawing.Size(137, 158);
            this.listBoxDealerCards.TabIndex = 39;
            // 
            // buttonThirdCard
            // 
            this.buttonThirdCard.Location = new System.Drawing.Point(272, 308);
            this.buttonThirdCard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThirdCard.Name = "buttonThirdCard";
            this.buttonThirdCard.Size = new System.Drawing.Size(154, 28);
            this.buttonThirdCard.TabIndex = 40;
            this.buttonThirdCard.Text = "Deal Third Card";
            this.buttonThirdCard.UseVisualStyleBackColor = true;
            this.buttonThirdCard.Click += new System.EventHandler(this.buttonThirdCard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Player\'s third card";
            // 
            // buttonCalculateWin
            // 
            this.buttonCalculateWin.Location = new System.Drawing.Point(430, 270);
            this.buttonCalculateWin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalculateWin.Name = "buttonCalculateWin";
            this.buttonCalculateWin.Size = new System.Drawing.Size(154, 28);
            this.buttonCalculateWin.TabIndex = 42;
            this.buttonCalculateWin.Text = "Win Lose Draw";
            this.buttonCalculateWin.UseVisualStyleBackColor = true;
            this.buttonCalculateWin.Click += new System.EventHandler(this.buttonCalculateWin_Click);
            // 
            // BlackjackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 353);
            this.Controls.Add(this.buttonCalculateWin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonThirdCard);
            this.Controls.Add(this.listBoxDealerCards);
            this.Controls.Add(this.listBoxPlayerCards);
            this.Controls.Add(this.buttonQuit_);
            this.Controls.Add(this.labelDealerTotal_);
            this.Controls.Add(this.labelPLayerTotal_);
            this.Controls.Add(this.textBoxDealerTotal_);
            this.Controls.Add(this.textBoxPlayerTotal_);
            this.Controls.Add(this.buttonDealSecondCard_);
            this.Controls.Add(this.labelMoneyLeft_);
            this.Controls.Add(this.textBoxMoneyLeft_);
            this.Controls.Add(this.labelMoneyToBet_);
            this.Controls.Add(this.labelDealerCard2_);
            this.Controls.Add(this.labelDealerCard1_);
            this.Controls.Add(this.labelPlayerCard2_);
            this.Controls.Add(this.labelPlayerCard1_);
            this.Controls.Add(this.textBoxBet_);
            this.Controls.Add(this.buttonDealFirstCard_);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BlackjackForm";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuit_;
        private System.Windows.Forms.Label labelDealerTotal_;
        private System.Windows.Forms.Label labelPLayerTotal_;
        private System.Windows.Forms.TextBox textBoxDealerTotal_;
        private System.Windows.Forms.TextBox textBoxPlayerTotal_;
        private System.Windows.Forms.Button buttonDealSecondCard_;
        private System.Windows.Forms.Label labelMoneyLeft_;
        private System.Windows.Forms.TextBox textBoxMoneyLeft_;
        private System.Windows.Forms.Label labelMoneyToBet_;
        private System.Windows.Forms.Label labelDealerCard2_;
        private System.Windows.Forms.Label labelDealerCard1_;
        private System.Windows.Forms.Label labelPlayerCard2_;
        private System.Windows.Forms.Label labelPlayerCard1_;
        private System.Windows.Forms.TextBox textBoxBet_;
        private System.Windows.Forms.Button buttonDealFirstCard_;
        private System.Windows.Forms.ListBox listBoxPlayerCards;
        private System.Windows.Forms.ListBox listBoxDealerCards;
        private System.Windows.Forms.Button buttonThirdCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalculateWin;
    }
}

