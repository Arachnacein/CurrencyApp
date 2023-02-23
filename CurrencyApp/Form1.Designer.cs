
namespace CurrencyApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelGold = new System.Windows.Forms.Label();
            this.labelSilver = new System.Windows.Forms.Label();
            this.labelGsRatio = new System.Windows.Forms.Label();
            this.labelGoldValuePLN = new System.Windows.Forms.Label();
            this.labelSilverValuePLN = new System.Windows.Forms.Label();
            this.labelPLN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSilverValueDollar = new System.Windows.Forms.Label();
            this.labelGoldValueDollar = new System.Windows.Forms.Label();
            this.labelGsRatioValue = new System.Windows.Forms.Label();
            this.pictureBoxUS = new System.Windows.Forms.PictureBox();
            this.pictureBoxUK = new System.Windows.Forms.PictureBox();
            this.pictureBoxEU = new System.Windows.Forms.PictureBox();
            this.pictureBoxNOK = new System.Windows.Forms.PictureBox();
            this.labelValueDollar = new System.Windows.Forms.Label();
            this.labelValuePound = new System.Windows.Forms.Label();
            this.labelValueEuro = new System.Windows.Forms.Label();
            this.labelValueNOK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNOK)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGold
            // 
            this.labelGold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelGold.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGold.Location = new System.Drawing.Point(12, 43);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(65, 30);
            this.labelGold.TabIndex = 0;
            this.labelGold.Text = "Gold";
            this.labelGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSilver
            // 
            this.labelSilver.BackColor = System.Drawing.Color.DarkGray;
            this.labelSilver.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSilver.Location = new System.Drawing.Point(12, 80);
            this.labelSilver.Name = "labelSilver";
            this.labelSilver.Size = new System.Drawing.Size(65, 30);
            this.labelSilver.TabIndex = 1;
            this.labelSilver.Text = "Silver";
            this.labelSilver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGsRatio
            // 
            this.labelGsRatio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelGsRatio.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGsRatio.Location = new System.Drawing.Point(12, 120);
            this.labelGsRatio.Name = "labelGsRatio";
            this.labelGsRatio.Size = new System.Drawing.Size(80, 30);
            this.labelGsRatio.TabIndex = 2;
            this.labelGsRatio.Text = "G/S Ratio";
            this.labelGsRatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGsRatio.Click += new System.EventHandler(this.labelGsRatio_Click);
            // 
            // labelGoldValuePLN
            // 
            this.labelGoldValuePLN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGoldValuePLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGoldValuePLN.Location = new System.Drawing.Point(100, 43);
            this.labelGoldValuePLN.Name = "labelGoldValuePLN";
            this.labelGoldValuePLN.Size = new System.Drawing.Size(65, 30);
            this.labelGoldValuePLN.TabIndex = 3;
            this.labelGoldValuePLN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSilverValuePLN
            // 
            this.labelSilverValuePLN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSilverValuePLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSilverValuePLN.Location = new System.Drawing.Point(100, 80);
            this.labelSilverValuePLN.Name = "labelSilverValuePLN";
            this.labelSilverValuePLN.Size = new System.Drawing.Size(65, 30);
            this.labelSilverValuePLN.TabIndex = 4;
            this.labelSilverValuePLN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPLN
            // 
            this.labelPLN.AutoSize = true;
            this.labelPLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPLN.Location = new System.Drawing.Point(113, 9);
            this.labelPLN.Name = "labelPLN";
            this.labelPLN.Size = new System.Drawing.Size(31, 13);
            this.labelPLN.TabIndex = 5;
            this.labelPLN.Text = "PLN";
            this.labelPLN.Click += new System.EventHandler(this.labelPLN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "$";
            // 
            // labelSilverValueDollar
            // 
            this.labelSilverValueDollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSilverValueDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSilverValueDollar.Location = new System.Drawing.Point(171, 80);
            this.labelSilverValueDollar.Name = "labelSilverValueDollar";
            this.labelSilverValueDollar.Size = new System.Drawing.Size(65, 30);
            this.labelSilverValueDollar.TabIndex = 7;
            this.labelSilverValueDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGoldValueDollar
            // 
            this.labelGoldValueDollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGoldValueDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGoldValueDollar.Location = new System.Drawing.Point(171, 43);
            this.labelGoldValueDollar.Name = "labelGoldValueDollar";
            this.labelGoldValueDollar.Size = new System.Drawing.Size(65, 30);
            this.labelGoldValueDollar.TabIndex = 6;
            this.labelGoldValueDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGsRatioValue
            // 
            this.labelGsRatioValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGsRatioValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGsRatioValue.Location = new System.Drawing.Point(100, 120);
            this.labelGsRatioValue.Name = "labelGsRatioValue";
            this.labelGsRatioValue.Size = new System.Drawing.Size(136, 30);
            this.labelGsRatioValue.TabIndex = 9;
            // 
            // pictureBoxUS
            // 
            this.pictureBoxUS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUS.Image")));
            this.pictureBoxUS.Location = new System.Drawing.Point(16, 162);
            this.pictureBoxUS.Name = "pictureBoxUS";
            this.pictureBoxUS.Size = new System.Drawing.Size(50, 30);
            this.pictureBoxUS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUS.TabIndex = 10;
            this.pictureBoxUS.TabStop = false;
            // 
            // pictureBoxUK
            // 
            this.pictureBoxUK.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUK.Image")));
            this.pictureBoxUK.Location = new System.Drawing.Point(72, 162);
            this.pictureBoxUK.Name = "pictureBoxUK";
            this.pictureBoxUK.Size = new System.Drawing.Size(50, 30);
            this.pictureBoxUK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUK.TabIndex = 11;
            this.pictureBoxUK.TabStop = false;
            // 
            // pictureBoxEU
            // 
            this.pictureBoxEU.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEU.Image")));
            this.pictureBoxEU.Location = new System.Drawing.Point(128, 162);
            this.pictureBoxEU.Name = "pictureBoxEU";
            this.pictureBoxEU.Size = new System.Drawing.Size(50, 30);
            this.pictureBoxEU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEU.TabIndex = 12;
            this.pictureBoxEU.TabStop = false;
            // 
            // pictureBoxNOK
            // 
            this.pictureBoxNOK.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNOK.Image")));
            this.pictureBoxNOK.Location = new System.Drawing.Point(184, 162);
            this.pictureBoxNOK.Name = "pictureBoxNOK";
            this.pictureBoxNOK.Size = new System.Drawing.Size(50, 30);
            this.pictureBoxNOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxNOK.TabIndex = 13;
            this.pictureBoxNOK.TabStop = false;
            // 
            // labelValueDollar
            // 
            this.labelValueDollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValueDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValueDollar.Location = new System.Drawing.Point(16, 200);
            this.labelValueDollar.Name = "labelValueDollar";
            this.labelValueDollar.Size = new System.Drawing.Size(50, 30);
            this.labelValueDollar.TabIndex = 14;
            // 
            // labelValuePound
            // 
            this.labelValuePound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValuePound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValuePound.Location = new System.Drawing.Point(72, 200);
            this.labelValuePound.Name = "labelValuePound";
            this.labelValuePound.Size = new System.Drawing.Size(50, 30);
            this.labelValuePound.TabIndex = 15;
            // 
            // labelValueEuro
            // 
            this.labelValueEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValueEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValueEuro.Location = new System.Drawing.Point(128, 200);
            this.labelValueEuro.Name = "labelValueEuro";
            this.labelValueEuro.Size = new System.Drawing.Size(50, 30);
            this.labelValueEuro.TabIndex = 16;
            // 
            // labelValueNOK
            // 
            this.labelValueNOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelValueNOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValueNOK.Location = new System.Drawing.Point(184, 200);
            this.labelValueNOK.Name = "labelValueNOK";
            this.labelValueNOK.Size = new System.Drawing.Size(50, 30);
            this.labelValueNOK.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(252, 242);
            this.Controls.Add(this.labelValueNOK);
            this.Controls.Add(this.labelValueEuro);
            this.Controls.Add(this.labelValuePound);
            this.Controls.Add(this.labelValueDollar);
            this.Controls.Add(this.pictureBoxNOK);
            this.Controls.Add(this.pictureBoxEU);
            this.Controls.Add(this.pictureBoxUK);
            this.Controls.Add(this.pictureBoxUS);
            this.Controls.Add(this.labelGsRatioValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSilverValueDollar);
            this.Controls.Add(this.labelGoldValueDollar);
            this.Controls.Add(this.labelPLN);
            this.Controls.Add(this.labelSilverValuePLN);
            this.Controls.Add(this.labelGoldValuePLN);
            this.Controls.Add(this.labelGsRatio);
            this.Controls.Add(this.labelSilver);
            this.Controls.Add(this.labelGold);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Label labelSilver;
        private System.Windows.Forms.Label labelGsRatio;
        private System.Windows.Forms.Label labelGoldValuePLN;
        private System.Windows.Forms.Label labelSilverValuePLN;
        private System.Windows.Forms.Label labelPLN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSilverValueDollar;
        private System.Windows.Forms.Label labelGoldValueDollar;
        private System.Windows.Forms.Label labelGsRatioValue;
        private System.Windows.Forms.PictureBox pictureBoxUS;
        private System.Windows.Forms.PictureBox pictureBoxUK;
        private System.Windows.Forms.PictureBox pictureBoxEU;
        private System.Windows.Forms.PictureBox pictureBoxNOK;
        private System.Windows.Forms.Label labelValueDollar;
        private System.Windows.Forms.Label labelValuePound;
        private System.Windows.Forms.Label labelValueEuro;
        private System.Windows.Forms.Label labelValueNOK;
    }
}

