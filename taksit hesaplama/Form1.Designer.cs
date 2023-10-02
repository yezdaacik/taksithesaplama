namespace taksit_hesaplama
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
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.tbTaksit = new System.Windows.Forms.TrackBar();
            this.lblTaksit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(31, 87);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(121, 20);
            this.txtTutar.TabIndex = 1;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTutar.TextChanged += new System.EventHandler(this.txtTutar_TextChanged);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(27, 127);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(99, 20);
            this.lblTutar.TabIndex = 3;
            this.lblTutar.Text = "Taksit Tutarı:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(158, 79);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(121, 35);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Taksit Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTaksit
            // 
            this.tbTaksit.Location = new System.Drawing.Point(22, 28);
            this.tbTaksit.Maximum = 12;
            this.tbTaksit.Minimum = 1;
            this.tbTaksit.Name = "tbTaksit";
            this.tbTaksit.Size = new System.Drawing.Size(257, 45);
            this.tbTaksit.TabIndex = 5;
            this.tbTaksit.Value = 1;
            this.tbTaksit.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Location = new System.Drawing.Point(317, 57);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(0, 13);
            this.lblTaksit.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 234);
            this.Controls.Add(this.lblTaksit);
            this.Controls.Add(this.tbTaksit);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtTutar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TrackBar tbTaksit;
        private System.Windows.Forms.Label lblTaksit;
    }
}

