namespace SlotMachine
{
    partial class frmSlot
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
            this.components = new System.ComponentModel.Container();
            this.lblWheel1 = new System.Windows.Forms.Label();
            this.btnHandle = new System.Windows.Forms.Button();
            this.tmrWheel1 = new System.Windows.Forms.Timer(this.components);
            this.pbxWheel1 = new System.Windows.Forms.PictureBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbxWheel2 = new System.Windows.Forms.PictureBox();
            this.lblWheel2 = new System.Windows.Forms.Label();
            this.pbxWheel3 = new System.Windows.Forms.PictureBox();
            this.lblWheel3 = new System.Windows.Forms.Label();
            this.tmrWheel2 = new System.Windows.Forms.Timer(this.components);
            this.tmrWheel3 = new System.Windows.Forms.Timer(this.components);
            this.pbxWinWheel1 = new System.Windows.Forms.PictureBox();
            this.pbxWinWheel2 = new System.Windows.Forms.PictureBox();
            this.pbxWinWheel3 = new System.Windows.Forms.PictureBox();
            this.tmrWinWheel = new System.Windows.Forms.Timer(this.components);
            this.lblBalanceLabel = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBetLabel = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblWinningsLabel = new System.Windows.Forms.Label();
            this.lblWinnings = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBet50 = new System.Windows.Forms.Button();
            this.btnBet20 = new System.Windows.Forms.Button();
            this.btnBetDouble = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWheel1
            // 
            this.lblWheel1.AutoSize = true;
            this.lblWheel1.ForeColor = System.Drawing.Color.White;
            this.lblWheel1.Location = new System.Drawing.Point(178, 64);
            this.lblWheel1.Name = "lblWheel1";
            this.lblWheel1.Size = new System.Drawing.Size(13, 13);
            this.lblWheel1.TabIndex = 0;
            this.lblWheel1.Text = "1";
            this.lblWheel1.Visible = false;
            // 
            // btnHandle
            // 
            this.btnHandle.BackColor = System.Drawing.Color.Lime;
            this.btnHandle.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandle.Location = new System.Drawing.Point(504, 80);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(102, 52);
            this.btnHandle.TabIndex = 1;
            this.btnHandle.Text = "Play";
            this.btnHandle.UseVisualStyleBackColor = false;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // tmrWheel1
            // 
            this.tmrWheel1.Tick += new System.EventHandler(this.tmrWheel1_Tick);
            // 
            // pbxWheel1
            // 
            this.pbxWheel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWheel1.Image = global::SlotMachine.Properties.Resources.watermelon;
            this.pbxWheel1.Location = new System.Drawing.Point(134, 95);
            this.pbxWheel1.Name = "pbxWheel1";
            this.pbxWheel1.Size = new System.Drawing.Size(90, 90);
            this.pbxWheel1.TabIndex = 2;
            this.pbxWheel1.TabStop = false;
            // 
            // pbx1
            // 
            this.pbx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx1.Image = global::SlotMachine.Properties.Resources.watermelon;
            this.pbx1.Location = new System.Drawing.Point(26, 0);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(50, 50);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 3;
            this.pbx1.TabStop = false;
            this.pbx1.Visible = false;
            // 
            // pbx2
            // 
            this.pbx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx2.Image = global::SlotMachine.Properties.Resources.banana;
            this.pbx2.Location = new System.Drawing.Point(112, 0);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(50, 50);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 4;
            this.pbx2.TabStop = false;
            this.pbx2.Visible = false;
            // 
            // pbx3
            // 
            this.pbx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx3.Image = global::SlotMachine.Properties.Resources.orange;
            this.pbx3.Location = new System.Drawing.Point(198, 0);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(50, 50);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 5;
            this.pbx3.TabStop = false;
            this.pbx3.Visible = false;
            // 
            // pbx4
            // 
            this.pbx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx4.Image = global::SlotMachine.Properties.Resources.lemon;
            this.pbx4.Location = new System.Drawing.Point(284, 0);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(50, 50);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 6;
            this.pbx4.TabStop = false;
            this.pbx4.Visible = false;
            // 
            // pbx5
            // 
            this.pbx5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx5.Image = global::SlotMachine.Properties.Resources.grape;
            this.pbx5.Location = new System.Drawing.Point(370, 0);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(50, 50);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 7;
            this.pbx5.TabStop = false;
            this.pbx5.Visible = false;
            // 
            // pbx6
            // 
            this.pbx6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx6.Image = global::SlotMachine.Properties.Resources.cherry;
            this.pbx6.Location = new System.Drawing.Point(455, 0);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(50, 50);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 8;
            this.pbx6.TabStop = false;
            this.pbx6.Visible = false;
            // 
            // pbx7
            // 
            this.pbx7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx7.Image = global::SlotMachine.Properties.Resources.berry;
            this.pbx7.Location = new System.Drawing.Point(541, 0);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(50, 50);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 9;
            this.pbx7.TabStop = false;
            this.pbx7.Visible = false;
            // 
            // pbxWheel2
            // 
            this.pbxWheel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWheel2.Image = global::SlotMachine.Properties.Resources.watermelon;
            this.pbxWheel2.Location = new System.Drawing.Point(257, 95);
            this.pbxWheel2.Name = "pbxWheel2";
            this.pbxWheel2.Size = new System.Drawing.Size(90, 90);
            this.pbxWheel2.TabIndex = 11;
            this.pbxWheel2.TabStop = false;
            // 
            // lblWheel2
            // 
            this.lblWheel2.AutoSize = true;
            this.lblWheel2.ForeColor = System.Drawing.Color.White;
            this.lblWheel2.Location = new System.Drawing.Point(301, 64);
            this.lblWheel2.Name = "lblWheel2";
            this.lblWheel2.Size = new System.Drawing.Size(13, 13);
            this.lblWheel2.TabIndex = 10;
            this.lblWheel2.Text = "1";
            this.lblWheel2.Visible = false;
            // 
            // pbxWheel3
            // 
            this.pbxWheel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWheel3.Image = global::SlotMachine.Properties.Resources.watermelon;
            this.pbxWheel3.Location = new System.Drawing.Point(377, 95);
            this.pbxWheel3.Name = "pbxWheel3";
            this.pbxWheel3.Size = new System.Drawing.Size(90, 90);
            this.pbxWheel3.TabIndex = 13;
            this.pbxWheel3.TabStop = false;
            // 
            // lblWheel3
            // 
            this.lblWheel3.AutoSize = true;
            this.lblWheel3.ForeColor = System.Drawing.Color.White;
            this.lblWheel3.Location = new System.Drawing.Point(424, 64);
            this.lblWheel3.Name = "lblWheel3";
            this.lblWheel3.Size = new System.Drawing.Size(13, 13);
            this.lblWheel3.TabIndex = 12;
            this.lblWheel3.Text = "1";
            this.lblWheel3.Visible = false;
            // 
            // tmrWheel2
            // 
            this.tmrWheel2.Tick += new System.EventHandler(this.tmrWheel2_Tick);
            // 
            // tmrWheel3
            // 
            this.tmrWheel3.Tick += new System.EventHandler(this.tmrWheel3_Tick);
            // 
            // pbxWinWheel1
            // 
            this.pbxWinWheel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbxWinWheel1.Location = new System.Drawing.Point(120, 80);
            this.pbxWinWheel1.Name = "pbxWinWheel1";
            this.pbxWinWheel1.Size = new System.Drawing.Size(120, 120);
            this.pbxWinWheel1.TabIndex = 14;
            this.pbxWinWheel1.TabStop = false;
            // 
            // pbxWinWheel2
            // 
            this.pbxWinWheel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbxWinWheel2.Location = new System.Drawing.Point(241, 80);
            this.pbxWinWheel2.Name = "pbxWinWheel2";
            this.pbxWinWheel2.Size = new System.Drawing.Size(120, 120);
            this.pbxWinWheel2.TabIndex = 15;
            this.pbxWinWheel2.TabStop = false;
            // 
            // pbxWinWheel3
            // 
            this.pbxWinWheel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbxWinWheel3.Location = new System.Drawing.Point(362, 80);
            this.pbxWinWheel3.Name = "pbxWinWheel3";
            this.pbxWinWheel3.Size = new System.Drawing.Size(120, 120);
            this.pbxWinWheel3.TabIndex = 16;
            this.pbxWinWheel3.TabStop = false;
            // 
            // tmrWinWheel
            // 
            this.tmrWinWheel.Tick += new System.EventHandler(this.tmrWinWheel_Tick);
            // 
            // lblBalanceLabel
            // 
            this.lblBalanceLabel.AutoSize = true;
            this.lblBalanceLabel.BackColor = System.Drawing.Color.Black;
            this.lblBalanceLabel.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceLabel.ForeColor = System.Drawing.Color.Cyan;
            this.lblBalanceLabel.Location = new System.Drawing.Point(20, 219);
            this.lblBalanceLabel.Name = "lblBalanceLabel";
            this.lblBalanceLabel.Size = new System.Drawing.Size(109, 32);
            this.lblBalanceLabel.TabIndex = 17;
            this.lblBalanceLabel.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(20, 269);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(78, 32);
            this.lblBalance.TabIndex = 18;
            this.lblBalance.Text = "$0.00";
            // 
            // lblBetLabel
            // 
            this.lblBetLabel.AutoSize = true;
            this.lblBetLabel.BackColor = System.Drawing.Color.Black;
            this.lblBetLabel.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetLabel.ForeColor = System.Drawing.Color.Yellow;
            this.lblBetLabel.Location = new System.Drawing.Point(463, 219);
            this.lblBetLabel.Name = "lblBetLabel";
            this.lblBetLabel.Size = new System.Drawing.Size(98, 32);
            this.lblBetLabel.TabIndex = 19;
            this.lblBetLabel.Text = "Betting";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.Color.White;
            this.lblBet.Location = new System.Drawing.Point(463, 269);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(78, 32);
            this.lblBet.TabIndex = 20;
            this.lblBet.Text = "$0.00";
            // 
            // lblWinningsLabel
            // 
            this.lblWinningsLabel.AutoSize = true;
            this.lblWinningsLabel.BackColor = System.Drawing.Color.Black;
            this.lblWinningsLabel.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinningsLabel.ForeColor = System.Drawing.Color.Lime;
            this.lblWinningsLabel.Location = new System.Drawing.Point(236, 219);
            this.lblWinningsLabel.Name = "lblWinningsLabel";
            this.lblWinningsLabel.Size = new System.Drawing.Size(131, 32);
            this.lblWinningsLabel.TabIndex = 21;
            this.lblWinningsLabel.Text = "Winnings";
            // 
            // lblWinnings
            // 
            this.lblWinnings.AutoSize = true;
            this.lblWinnings.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnings.ForeColor = System.Drawing.Color.White;
            this.lblWinnings.Location = new System.Drawing.Point(236, 269);
            this.lblWinnings.Name = "lblWinnings";
            this.lblWinnings.Size = new System.Drawing.Size(78, 32);
            this.lblWinnings.TabIndex = 22;
            this.lblWinnings.Text = "$0.00";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(516, 165);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 35);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBet50
            // 
            this.btnBet50.BackColor = System.Drawing.Color.Yellow;
            this.btnBet50.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet50.Location = new System.Drawing.Point(17, 120);
            this.btnBet50.Name = "btnBet50";
            this.btnBet50.Size = new System.Drawing.Size(86, 34);
            this.btnBet50.TabIndex = 24;
            this.btnBet50.Text = "Bet $50";
            this.btnBet50.UseVisualStyleBackColor = false;
            this.btnBet50.Click += new System.EventHandler(this.btnBet50_Click);
            // 
            // btnBet20
            // 
            this.btnBet20.BackColor = System.Drawing.Color.Yellow;
            this.btnBet20.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet20.Location = new System.Drawing.Point(17, 80);
            this.btnBet20.Name = "btnBet20";
            this.btnBet20.Size = new System.Drawing.Size(86, 34);
            this.btnBet20.TabIndex = 25;
            this.btnBet20.Text = "Bet $20";
            this.btnBet20.UseVisualStyleBackColor = false;
            this.btnBet20.Click += new System.EventHandler(this.btnBet20_Click);
            // 
            // btnBetDouble
            // 
            this.btnBetDouble.BackColor = System.Drawing.Color.Yellow;
            this.btnBetDouble.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetDouble.Location = new System.Drawing.Point(17, 160);
            this.btnBetDouble.Name = "btnBetDouble";
            this.btnBetDouble.Size = new System.Drawing.Size(86, 34);
            this.btnBetDouble.TabIndex = 26;
            this.btnBetDouble.Text = "Bet X 2";
            this.btnBetDouble.UseVisualStyleBackColor = false;
            this.btnBetDouble.Click += new System.EventHandler(this.btnBetDouble_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(120, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 120);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Gold;
            this.lblName.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(104, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(393, 44);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Fruity Fortunes";
            // 
            // frmSlot
            // 
            this.AcceptButton = this.btnHandle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(620, 336);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBetDouble);
            this.Controls.Add(this.btnBet20);
            this.Controls.Add(this.btnBet50);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWinnings);
            this.Controls.Add(this.lblWinningsLabel);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblBetLabel);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalanceLabel);
            this.Controls.Add(this.pbxWheel3);
            this.Controls.Add(this.lblWheel3);
            this.Controls.Add(this.pbxWheel2);
            this.Controls.Add(this.lblWheel2);
            this.Controls.Add(this.pbx7);
            this.Controls.Add(this.pbx6);
            this.Controls.Add(this.pbx5);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.pbxWheel1);
            this.Controls.Add(this.btnHandle);
            this.Controls.Add(this.lblWheel1);
            this.Controls.Add(this.pbxWinWheel1);
            this.Controls.Add(this.pbxWinWheel2);
            this.Controls.Add(this.pbxWinWheel3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSlot";
            this.Text = "Fruity Fortunes";
            this.Load += new System.EventHandler(this.frmSlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWheel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinWheel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWheel1;
        private System.Windows.Forms.Button btnHandle;
        private System.Windows.Forms.Timer tmrWheel1;
        private System.Windows.Forms.PictureBox pbxWheel1;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbxWheel2;
        private System.Windows.Forms.Label lblWheel2;
        private System.Windows.Forms.PictureBox pbxWheel3;
        private System.Windows.Forms.Label lblWheel3;
        private System.Windows.Forms.Timer tmrWheel2;
        private System.Windows.Forms.Timer tmrWheel3;
        private System.Windows.Forms.PictureBox pbxWinWheel1;
        private System.Windows.Forms.PictureBox pbxWinWheel2;
        private System.Windows.Forms.PictureBox pbxWinWheel3;
        private System.Windows.Forms.Timer tmrWinWheel;
        private System.Windows.Forms.Label lblBalanceLabel;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBetLabel;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblWinningsLabel;
        private System.Windows.Forms.Label lblWinnings;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBet50;
        private System.Windows.Forms.Button btnBet20;
        private System.Windows.Forms.Button btnBetDouble;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
    }
}

