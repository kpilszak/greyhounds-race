namespace greyhounds_race
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.raceTrackPictureBox = new System.Windows.Forms.PictureBox();
            this.greyhoundPictureBox1 = new System.Windows.Forms.PictureBox();
            this.greyhoundPictureBox2 = new System.Windows.Forms.PictureBox();
            this.greyhoundPictureBox3 = new System.Windows.Forms.PictureBox();
            this.greyhoundPictureBox4 = new System.Windows.Forms.PictureBox();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.playerRadioButton1 = new System.Windows.Forms.RadioButton();
            this.playerRadioButton2 = new System.Windows.Forms.RadioButton();
            this.playerRadioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.betsButton = new System.Windows.Forms.Button();
            this.amountButton = new System.Windows.Forms.DomainUpDown();
            this.betLabel = new System.Windows.Forms.Label();
            this.grehoundNumberButton = new System.Windows.Forms.DomainUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playerLabel1 = new System.Windows.Forms.Label();
            this.playerLabel2 = new System.Windows.Forms.Label();
            this.playerLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(571, 22);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(237, 275);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // raceTrackPictureBox
            // 
            this.raceTrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("raceTrackPictureBox.Image")));
            this.raceTrackPictureBox.Location = new System.Drawing.Point(13, 13);
            this.raceTrackPictureBox.Name = "raceTrackPictureBox";
            this.raceTrackPictureBox.Size = new System.Drawing.Size(814, 230);
            this.raceTrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrackPictureBox.TabIndex = 1;
            this.raceTrackPictureBox.TabStop = false;
            // 
            // greyhoundPictureBox1
            // 
            this.greyhoundPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("greyhoundPictureBox1.Image")));
            this.greyhoundPictureBox1.Location = new System.Drawing.Point(25, 23);
            this.greyhoundPictureBox1.Name = "greyhoundPictureBox1";
            this.greyhoundPictureBox1.Size = new System.Drawing.Size(105, 28);
            this.greyhoundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greyhoundPictureBox1.TabIndex = 2;
            this.greyhoundPictureBox1.TabStop = false;
            // 
            // greyhoundPictureBox2
            // 
            this.greyhoundPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("greyhoundPictureBox2.Image")));
            this.greyhoundPictureBox2.Location = new System.Drawing.Point(25, 76);
            this.greyhoundPictureBox2.Name = "greyhoundPictureBox2";
            this.greyhoundPictureBox2.Size = new System.Drawing.Size(105, 28);
            this.greyhoundPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greyhoundPictureBox2.TabIndex = 3;
            this.greyhoundPictureBox2.TabStop = false;
            // 
            // greyhoundPictureBox3
            // 
            this.greyhoundPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("greyhoundPictureBox3.Image")));
            this.greyhoundPictureBox3.Location = new System.Drawing.Point(25, 140);
            this.greyhoundPictureBox3.Name = "greyhoundPictureBox3";
            this.greyhoundPictureBox3.Size = new System.Drawing.Size(105, 28);
            this.greyhoundPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greyhoundPictureBox3.TabIndex = 4;
            this.greyhoundPictureBox3.TabStop = false;
            // 
            // greyhoundPictureBox4
            // 
            this.greyhoundPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("greyhoundPictureBox4.Image")));
            this.greyhoundPictureBox4.Location = new System.Drawing.Point(25, 199);
            this.greyhoundPictureBox4.Name = "greyhoundPictureBox4";
            this.greyhoundPictureBox4.Size = new System.Drawing.Size(105, 28);
            this.greyhoundPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greyhoundPictureBox4.TabIndex = 5;
            this.greyhoundPictureBox4.TabStop = false;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(15, 61);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(171, 25);
            this.minimumBetLabel.TabIndex = 7;
            this.minimumBetLabel.Text = "Minimum bet: 5$";
            // 
            // playerRadioButton1
            // 
            this.playerRadioButton1.AutoSize = true;
            this.playerRadioButton1.Checked = true;
            this.playerRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRadioButton1.Location = new System.Drawing.Point(20, 107);
            this.playerRadioButton1.Name = "playerRadioButton1";
            this.playerRadioButton1.Size = new System.Drawing.Size(175, 24);
            this.playerRadioButton1.TabIndex = 8;
            this.playerRadioButton1.TabStop = true;
            this.playerRadioButton1.Text = "playerRadioButton1";
            this.playerRadioButton1.UseVisualStyleBackColor = true;
            // 
            // playerRadioButton2
            // 
            this.playerRadioButton2.AutoSize = true;
            this.playerRadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRadioButton2.Location = new System.Drawing.Point(20, 163);
            this.playerRadioButton2.Name = "playerRadioButton2";
            this.playerRadioButton2.Size = new System.Drawing.Size(175, 24);
            this.playerRadioButton2.TabIndex = 9;
            this.playerRadioButton2.TabStop = true;
            this.playerRadioButton2.Text = "playerRadioButton2";
            this.playerRadioButton2.UseVisualStyleBackColor = true;
            // 
            // playerRadioButton3
            // 
            this.playerRadioButton3.AutoSize = true;
            this.playerRadioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRadioButton3.Location = new System.Drawing.Point(20, 220);
            this.playerRadioButton3.Name = "playerRadioButton3";
            this.playerRadioButton3.Size = new System.Drawing.Size(175, 24);
            this.playerRadioButton3.TabIndex = 10;
            this.playerRadioButton3.TabStop = true;
            this.playerRadioButton3.Text = "playerRadioButton3";
            this.playerRadioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bets";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(16, 271);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 20);
            this.name.TabIndex = 15;
            this.name.Text = "name";
            // 
            // betsButton
            // 
            this.betsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betsButton.Location = new System.Drawing.Point(111, 268);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(75, 31);
            this.betsButton.TabIndex = 16;
            this.betsButton.Text = "bets";
            this.betsButton.UseVisualStyleBackColor = true;
            // 
            // amountButton
            // 
            this.amountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountButton.Location = new System.Drawing.Point(203, 269);
            this.amountButton.Name = "amountButton";
            this.amountButton.Size = new System.Drawing.Size(79, 26);
            this.amountButton.TabIndex = 17;
            this.amountButton.Text = "5";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.Location = new System.Drawing.Point(288, 273);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(177, 20);
            this.betLabel.TabIndex = 18;
            this.betLabel.Text = "$ on greyhound number";
            // 
            // grehoundNumberButton
            // 
            this.grehoundNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grehoundNumberButton.Location = new System.Drawing.Point(482, 271);
            this.grehoundNumberButton.Name = "grehoundNumberButton";
            this.grehoundNumberButton.Size = new System.Drawing.Size(50, 26);
            this.grehoundNumberButton.TabIndex = 19;
            this.grehoundNumberButton.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerLabel3);
            this.groupBox1.Controls.Add(this.playerLabel2);
            this.groupBox1.Controls.Add(this.playerLabel1);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Controls.Add(this.grehoundNumberButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.betLabel);
            this.groupBox1.Controls.Add(this.playerRadioButton1);
            this.groupBox1.Controls.Add(this.amountButton);
            this.groupBox1.Controls.Add(this.playerRadioButton2);
            this.groupBox1.Controls.Add(this.betsButton);
            this.groupBox1.Controls.Add(this.playerRadioButton3);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 303);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting House";
            // 
            // playerLabel1
            // 
            this.playerLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel1.Location = new System.Drawing.Point(255, 108);
            this.playerLabel1.Name = "playerLabel1";
            this.playerLabel1.Size = new System.Drawing.Size(277, 26);
            this.playerLabel1.TabIndex = 20;
            this.playerLabel1.Text = "playerLabel1";
            // 
            // playerLabel2
            // 
            this.playerLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel2.Location = new System.Drawing.Point(255, 164);
            this.playerLabel2.Name = "playerLabel2";
            this.playerLabel2.Size = new System.Drawing.Size(277, 26);
            this.playerLabel2.TabIndex = 21;
            this.playerLabel2.Text = "playerLabel2";
            // 
            // playerLabel3
            // 
            this.playerLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel3.Location = new System.Drawing.Point(255, 221);
            this.playerLabel3.Name = "playerLabel3";
            this.playerLabel3.Size = new System.Drawing.Size(277, 26);
            this.playerLabel3.TabIndex = 22;
            this.playerLabel3.Text = "playerLabel3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.greyhoundPictureBox4);
            this.Controls.Add(this.greyhoundPictureBox3);
            this.Controls.Add(this.greyhoundPictureBox2);
            this.Controls.Add(this.greyhoundPictureBox1);
            this.Controls.Add(this.raceTrackPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Welcome to The Greyhounds\' Race!";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundPictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox raceTrackPictureBox;
        private System.Windows.Forms.PictureBox greyhoundPictureBox1;
        private System.Windows.Forms.PictureBox greyhoundPictureBox2;
        private System.Windows.Forms.PictureBox greyhoundPictureBox3;
        private System.Windows.Forms.PictureBox greyhoundPictureBox4;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.RadioButton playerRadioButton1;
        private System.Windows.Forms.RadioButton playerRadioButton2;
        private System.Windows.Forms.RadioButton playerRadioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.DomainUpDown amountButton;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.DomainUpDown grehoundNumberButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label playerLabel3;
        private System.Windows.Forms.Label playerLabel2;
        private System.Windows.Forms.Label playerLabel1;
    }
}

