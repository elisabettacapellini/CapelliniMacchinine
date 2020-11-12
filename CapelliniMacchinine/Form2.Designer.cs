namespace CapelliniMacchinine
{
    partial class Form2
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
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnRivincita2 = new System.Windows.Forms.Button();
            this.btnSwitch2 = new System.Windows.Forms.Button();
            this.bgwBabbo = new System.ComponentModel.BackgroundWorker();
            this.bgwSacco = new System.ComponentModel.BackgroundWorker();
            this.picbSacco = new System.Windows.Forms.PictureBox();
            this.picbBabbo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbSacco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbBabbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart2
            // 
            this.btnStart2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart2.Location = new System.Drawing.Point(12, 51);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(132, 53);
            this.btnStart2.TabIndex = 3;
            this.btnStart2.Text = "START";
            this.btnStart2.UseVisualStyleBackColor = false;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // btnRivincita2
            // 
            this.btnRivincita2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRivincita2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRivincita2.Location = new System.Drawing.Point(12, 143);
            this.btnRivincita2.Name = "btnRivincita2";
            this.btnRivincita2.Size = new System.Drawing.Size(132, 53);
            this.btnRivincita2.TabIndex = 4;
            this.btnRivincita2.Text = "RIVINCITA";
            this.btnRivincita2.UseVisualStyleBackColor = false;
            this.btnRivincita2.Click += new System.EventHandler(this.btnRivincita2_Click);
            // 
            // btnSwitch2
            // 
            this.btnSwitch2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSwitch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch2.Location = new System.Drawing.Point(12, 235);
            this.btnSwitch2.Name = "btnSwitch2";
            this.btnSwitch2.Size = new System.Drawing.Size(132, 53);
            this.btnSwitch2.TabIndex = 5;
            this.btnSwitch2.Text = "CAMBIA PERCORSO";
            this.btnSwitch2.UseVisualStyleBackColor = false;
            this.btnSwitch2.Click += new System.EventHandler(this.btnSwitch2_Click);
            // 
            // bgwBabbo
            // 
            this.bgwBabbo.WorkerReportsProgress = true;
            this.bgwBabbo.WorkerSupportsCancellation = true;
            this.bgwBabbo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgwBabbo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgwBabbo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // bgwSacco
            // 
            this.bgwSacco.WorkerReportsProgress = true;
            this.bgwSacco.WorkerSupportsCancellation = true;
            this.bgwSacco.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgwSacco.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgwSacco.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // picbSacco
            // 
            this.picbSacco.BackColor = System.Drawing.Color.Transparent;
            this.picbSacco.Image = global::CapelliniMacchinine.Properties.Resources.sacco1;
            this.picbSacco.Location = new System.Drawing.Point(409, 12);
            this.picbSacco.Name = "picbSacco";
            this.picbSacco.Size = new System.Drawing.Size(114, 105);
            this.picbSacco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbSacco.TabIndex = 2;
            this.picbSacco.TabStop = false;
            // 
            // picbBabbo
            // 
            this.picbBabbo.BackColor = System.Drawing.Color.Transparent;
            this.picbBabbo.Image = global::CapelliniMacchinine.Properties.Resources.babbo;
            this.picbBabbo.Location = new System.Drawing.Point(266, 12);
            this.picbBabbo.Name = "picbBabbo";
            this.picbBabbo.Size = new System.Drawing.Size(114, 105);
            this.picbBabbo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbBabbo.TabIndex = 1;
            this.picbBabbo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapelliniMacchinine.Properties.Resources.camino1;
            this.pictureBox1.Location = new System.Drawing.Point(212, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 774);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 860);
            this.Controls.Add(this.btnSwitch2);
            this.Controls.Add(this.btnRivincita2);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.picbSacco);
            this.Controls.Add(this.picbBabbo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picbSacco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbBabbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picbBabbo;
        private System.Windows.Forms.PictureBox picbSacco;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Button btnRivincita2;
        private System.Windows.Forms.Button btnSwitch2;
        private System.ComponentModel.BackgroundWorker bgwBabbo;
        private System.ComponentModel.BackgroundWorker bgwSacco;
    }
}