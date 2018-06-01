namespace FightingClub
{
    partial class GameView
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
            this.textPlayerName_1 = new System.Windows.Forms.TextBox();
            this.textPlayerName_2 = new System.Windows.Forms.TextBox();
            this.textRoundNumber = new System.Windows.Forms.TextBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.radioButtonHitHead = new System.Windows.Forms.RadioButton();
            this.radioButtonHitChest = new System.Windows.Forms.RadioButton();
            this.radioButtonHitLegs = new System.Windows.Forms.RadioButton();
            this.radioButtonBlockLegs = new System.Windows.Forms.RadioButton();
            this.radioButtonBlockChest = new System.Windows.Forms.RadioButton();
            this.radioButtonBlockHead = new System.Windows.Forms.RadioButton();
            this.groupBoxHit = new System.Windows.Forms.GroupBox();
            this.groupBoxBlock = new System.Windows.Forms.GroupBox();
            this.textPlayerHealth_1 = new System.Windows.Forms.TextBox();
            this.textPlayerHealth_2 = new System.Windows.Forms.TextBox();
            this.progressBarPlayerHealth_1 = new System.Windows.Forms.ProgressBar();
            this.progressBarPlayerHealth_2 = new System.Windows.Forms.ProgressBar();
            this.buttonStartRound = new System.Windows.Forms.Button();
            this.groupBoxHit.SuspendLayout();
            this.groupBoxBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPlayerName_1
            // 
            this.textPlayerName_1.Location = new System.Drawing.Point(13, 40);
            this.textPlayerName_1.Name = "textPlayerName_1";
            this.textPlayerName_1.Size = new System.Drawing.Size(100, 20);
            this.textPlayerName_1.TabIndex = 0;
            // 
            // textPlayerName_2
            // 
            this.textPlayerName_2.Location = new System.Drawing.Point(672, 39);
            this.textPlayerName_2.Name = "textPlayerName_2";
            this.textPlayerName_2.Size = new System.Drawing.Size(100, 20);
            this.textPlayerName_2.TabIndex = 1;
            // 
            // textRoundNumber
            // 
            this.textRoundNumber.Location = new System.Drawing.Point(345, 12);
            this.textRoundNumber.Name = "textRoundNumber";
            this.textRoundNumber.Size = new System.Drawing.Size(95, 20);
            this.textRoundNumber.TabIndex = 2;
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(13, 442);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(759, 108);
            this.textLog.TabIndex = 3;
            // 
            // radioButtonHitHead
            // 
            this.radioButtonHitHead.AutoSize = true;
            this.radioButtonHitHead.Location = new System.Drawing.Point(6, 21);
            this.radioButtonHitHead.Name = "radioButtonHitHead";
            this.radioButtonHitHead.Size = new System.Drawing.Size(94, 17);
            this.radioButtonHitHead.TabIndex = 4;
            this.radioButtonHitHead.TabStop = true;
            this.radioButtonHitHead.Text = "удар в голову";
            this.radioButtonHitHead.UseVisualStyleBackColor = true;
            // 
            // radioButtonHitChest
            // 
            this.radioButtonHitChest.AutoSize = true;
            this.radioButtonHitChest.Location = new System.Drawing.Point(6, 44);
            this.radioButtonHitChest.Name = "radioButtonHitChest";
            this.radioButtonHitChest.Size = new System.Drawing.Size(88, 17);
            this.radioButtonHitChest.TabIndex = 5;
            this.radioButtonHitChest.TabStop = true;
            this.radioButtonHitChest.Text = "удар в грудь";
            this.radioButtonHitChest.UseVisualStyleBackColor = true;
            // 
            // radioButtonHitLegs
            // 
            this.radioButtonHitLegs.AutoSize = true;
            this.radioButtonHitLegs.Location = new System.Drawing.Point(6, 67);
            this.radioButtonHitLegs.Name = "radioButtonHitLegs";
            this.radioButtonHitLegs.Size = new System.Drawing.Size(97, 17);
            this.radioButtonHitLegs.TabIndex = 6;
            this.radioButtonHitLegs.TabStop = true;
            this.radioButtonHitLegs.Text = "удар по ногам";
            this.radioButtonHitLegs.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlockLegs
            // 
            this.radioButtonBlockLegs.AutoSize = true;
            this.radioButtonBlockLegs.Location = new System.Drawing.Point(6, 67);
            this.radioButtonBlockLegs.Name = "radioButtonBlockLegs";
            this.radioButtonBlockLegs.Size = new System.Drawing.Size(69, 17);
            this.radioButtonBlockLegs.TabIndex = 9;
            this.radioButtonBlockLegs.TabStop = true;
            this.radioButtonBlockLegs.Text = "блок ног";
            this.radioButtonBlockLegs.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlockChest
            // 
            this.radioButtonBlockChest.AutoSize = true;
            this.radioButtonBlockChest.Location = new System.Drawing.Point(6, 44);
            this.radioButtonBlockChest.Name = "radioButtonBlockChest";
            this.radioButtonBlockChest.Size = new System.Drawing.Size(80, 17);
            this.radioButtonBlockChest.TabIndex = 8;
            this.radioButtonBlockChest.TabStop = true;
            this.radioButtonBlockChest.Text = "блок груди";
            this.radioButtonBlockChest.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlockHead
            // 
            this.radioButtonBlockHead.AutoSize = true;
            this.radioButtonBlockHead.Location = new System.Drawing.Point(6, 21);
            this.radioButtonBlockHead.Name = "radioButtonBlockHead";
            this.radioButtonBlockHead.Size = new System.Drawing.Size(92, 17);
            this.radioButtonBlockHead.TabIndex = 7;
            this.radioButtonBlockHead.TabStop = true;
            this.radioButtonBlockHead.Text = "блок  головы";
            this.radioButtonBlockHead.UseVisualStyleBackColor = true;
            // 
            // groupBoxHit
            // 
            this.groupBoxHit.Controls.Add(this.radioButtonHitLegs);
            this.groupBoxHit.Controls.Add(this.radioButtonHitHead);
            this.groupBoxHit.Controls.Add(this.radioButtonHitChest);
            this.groupBoxHit.Location = new System.Drawing.Point(139, 186);
            this.groupBoxHit.Name = "groupBoxHit";
            this.groupBoxHit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxHit.Size = new System.Drawing.Size(200, 100);
            this.groupBoxHit.TabIndex = 10;
            this.groupBoxHit.TabStop = false;
            this.groupBoxHit.Text = "Атака";
            // 
            // groupBoxBlock
            // 
            this.groupBoxBlock.Controls.Add(this.radioButtonBlockLegs);
            this.groupBoxBlock.Controls.Add(this.radioButtonBlockHead);
            this.groupBoxBlock.Controls.Add(this.radioButtonBlockChest);
            this.groupBoxBlock.Location = new System.Drawing.Point(446, 186);
            this.groupBoxBlock.Name = "groupBoxBlock";
            this.groupBoxBlock.Size = new System.Drawing.Size(200, 100);
            this.groupBoxBlock.TabIndex = 11;
            this.groupBoxBlock.TabStop = false;
            this.groupBoxBlock.Text = "Защита";
            // 
            // textPlayerHealth_1
            // 
            this.textPlayerHealth_1.Location = new System.Drawing.Point(13, 66);
            this.textPlayerHealth_1.Name = "textPlayerHealth_1";
            this.textPlayerHealth_1.Size = new System.Drawing.Size(100, 20);
            this.textPlayerHealth_1.TabIndex = 12;
            // 
            // textPlayerHealth_2
            // 
            this.textPlayerHealth_2.Location = new System.Drawing.Point(672, 66);
            this.textPlayerHealth_2.Name = "textPlayerHealth_2";
            this.textPlayerHealth_2.Size = new System.Drawing.Size(100, 20);
            this.textPlayerHealth_2.TabIndex = 13;
            // 
            // progressBarPlayerHealth_1
            // 
            this.progressBarPlayerHealth_1.Location = new System.Drawing.Point(13, 12);
            this.progressBarPlayerHealth_1.Name = "progressBarPlayerHealth_1";
            this.progressBarPlayerHealth_1.Size = new System.Drawing.Size(326, 20);
            this.progressBarPlayerHealth_1.TabIndex = 14;
            // 
            // progressBarPlayerHealth_2
            // 
            this.progressBarPlayerHealth_2.Location = new System.Drawing.Point(446, 12);
            this.progressBarPlayerHealth_2.Name = "progressBarPlayerHealth_2";
            this.progressBarPlayerHealth_2.Size = new System.Drawing.Size(326, 20);
            this.progressBarPlayerHealth_2.TabIndex = 15;
            // 
            // buttonStartRound
            // 
            this.buttonStartRound.Location = new System.Drawing.Point(345, 343);
            this.buttonStartRound.Name = "buttonStartRound";
            this.buttonStartRound.Size = new System.Drawing.Size(95, 23);
            this.buttonStartRound.TabIndex = 16;
            this.buttonStartRound.Text = "Вперёд!!!";
            this.buttonStartRound.UseVisualStyleBackColor = true;
            this.buttonStartRound.Click += new System.EventHandler(this.buttonStartRound_Click);
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.buttonStartRound);
            this.Controls.Add(this.progressBarPlayerHealth_2);
            this.Controls.Add(this.progressBarPlayerHealth_1);
            this.Controls.Add(this.textPlayerHealth_2);
            this.Controls.Add(this.textPlayerHealth_1);
            this.Controls.Add(this.groupBoxBlock);
            this.Controls.Add(this.groupBoxHit);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.textRoundNumber);
            this.Controls.Add(this.textPlayerName_2);
            this.Controls.Add(this.textPlayerName_1);
            this.Name = "GameView";
            this.Text = "Form1";
            this.groupBoxHit.ResumeLayout(false);
            this.groupBoxHit.PerformLayout();
            this.groupBoxBlock.ResumeLayout(false);
            this.groupBoxBlock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPlayerName_1;
        private System.Windows.Forms.TextBox textPlayerName_2;
        private System.Windows.Forms.TextBox textRoundNumber;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.RadioButton radioButtonHitHead;
        private System.Windows.Forms.RadioButton radioButtonHitChest;
        private System.Windows.Forms.RadioButton radioButtonHitLegs;
        private System.Windows.Forms.RadioButton radioButtonBlockLegs;
        private System.Windows.Forms.RadioButton radioButtonBlockChest;
        private System.Windows.Forms.RadioButton radioButtonBlockHead;
        private System.Windows.Forms.GroupBox groupBoxHit;
        private System.Windows.Forms.GroupBox groupBoxBlock;
        private System.Windows.Forms.TextBox textPlayerHealth_1;
        private System.Windows.Forms.TextBox textPlayerHealth_2;
        private System.Windows.Forms.ProgressBar progressBarPlayerHealth_1;
        private System.Windows.Forms.ProgressBar progressBarPlayerHealth_2;
        private System.Windows.Forms.Button buttonStartRound;
    }
}

