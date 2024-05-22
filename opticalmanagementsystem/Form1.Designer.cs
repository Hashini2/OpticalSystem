
namespace opticalmanagementsystem
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.myprogressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.presentagelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(119, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Janasewa Optical";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // myprogressBar
            // 
            this.myprogressBar.ForeColor = System.Drawing.Color.Red;
            this.myprogressBar.Location = new System.Drawing.Point(1, 283);
            this.myprogressBar.Margin = new System.Windows.Forms.Padding(2);
            this.myprogressBar.Name = "myprogressBar";
            this.myprogressBar.Size = new System.Drawing.Size(634, 14);
            this.myprogressBar.TabIndex = 2;
            this.myprogressBar.Click += new System.EventHandler(this.myprogressBar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(180, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loading Module";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // presentagelbl
            // 
            this.presentagelbl.AutoSize = true;
            this.presentagelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentagelbl.ForeColor = System.Drawing.Color.Indigo;
            this.presentagelbl.Location = new System.Drawing.Point(403, 239);
            this.presentagelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.presentagelbl.Name = "presentagelbl";
            this.presentagelbl.Size = new System.Drawing.Size(39, 31);
            this.presentagelbl.TabIndex = 6;
            this.presentagelbl.Text = "%";
            this.presentagelbl.Click += new System.EventHandler(this.presentagelbl_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::opticalmanagementsystem.Properties.Resources._1000_F_208876597_95kY23jTMOdcuhgjO3vHIbi1djvKf8Ke;
            this.pictureBox1.Location = new System.Drawing.Point(177, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(635, 299);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.presentagelbl);
            this.Controls.Add(this.myprogressBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar myprogressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label presentagelbl;
        private System.Windows.Forms.Timer timer1;
    }
}

