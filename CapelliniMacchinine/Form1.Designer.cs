namespace CapelliniMacchinine
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.bckwBlackCar = new System.ComponentModel.BackgroundWorker();
            this.bckwRedCar = new System.ComponentModel.BackgroundWorker();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnRivincita = new System.Windows.Forms.Button();
            this.picbRedCar = new System.Windows.Forms.PictureBox();
            this.picbBlackCar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbRedCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbBlackCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bckwBlackCar
            // 
            this.bckwBlackCar.WorkerReportsProgress = true;
            this.bckwBlackCar.WorkerSupportsCancellation = true;
            this.bckwBlackCar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bckwBlackCar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bckwBlackCar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // bckwRedCar
            // 
            this.bckwRedCar.WorkerReportsProgress = true;
            this.bckwRedCar.WorkerSupportsCancellation = true;
            this.bckwRedCar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bckwRedCar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bckwRedCar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(14, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(164, 53);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(460, 12);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(164, 53);
            this.btnSwitch.TabIndex = 13;
            this.btnSwitch.Text = "CAMBIA PERCORSO";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnRivincita
            // 
            this.btnRivincita.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRivincita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRivincita.Location = new System.Drawing.Point(237, 12);
            this.btnRivincita.Name = "btnRivincita";
            this.btnRivincita.Size = new System.Drawing.Size(164, 53);
            this.btnRivincita.TabIndex = 14;
            this.btnRivincita.Text = "RIVINCITA";
            this.btnRivincita.UseVisualStyleBackColor = false;
            this.btnRivincita.Click += new System.EventHandler(this.btnRivincita_Click);
            // 
            // picbRedCar
            // 
            this.picbRedCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.picbRedCar.Image = global::CapelliniMacchinine.Properties.Resources.macchinarossa;
            this.picbRedCar.Location = new System.Drawing.Point(12, 349);
            this.picbRedCar.Name = "picbRedCar";
            this.picbRedCar.Size = new System.Drawing.Size(125, 64);
            this.picbRedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbRedCar.TabIndex = 2;
            this.picbRedCar.TabStop = false;
            // 
            // picbBlackCar
            // 
            this.picbBlackCar.BackColor = System.Drawing.Color.Black;
            this.picbBlackCar.Image = global::CapelliniMacchinine.Properties.Resources.macchinanera;
            this.picbBlackCar.Location = new System.Drawing.Point(14, 198);
            this.picbBlackCar.Name = "picbBlackCar";
            this.picbBlackCar.Size = new System.Drawing.Size(123, 66);
            this.picbBlackCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbBlackCar.TabIndex = 1;
            this.picbBlackCar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapelliniMacchinine.Properties.Resources.road_trip_background_10864211;
            this.pictureBox1.Location = new System.Drawing.Point(14, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1037, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(1168, 504);
            this.Controls.Add(this.btnRivincita);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picbRedCar);
            this.Controls.Add(this.picbBlackCar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbRedCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbBlackCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picbBlackCar;
        private System.Windows.Forms.PictureBox picbRedCar;
        private System.ComponentModel.BackgroundWorker bckwBlackCar;
        private System.ComponentModel.BackgroundWorker bckwRedCar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnRivincita;
    }
}

