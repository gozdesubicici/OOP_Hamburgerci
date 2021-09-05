
namespace OOP_Hamburgerci
{
    partial class Form3
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
            this.grpEkstraMalzEkle = new System.Windows.Forms.GroupBox();
            this.btnEkstraEkle = new System.Windows.Forms.Button();
            this.nmrEkstraFiyatı = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEkstraMalzEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyatı)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkstraMalzEkle
            // 
            this.grpEkstraMalzEkle.Controls.Add(this.btnEkstraEkle);
            this.grpEkstraMalzEkle.Controls.Add(this.nmrEkstraFiyatı);
            this.grpEkstraMalzEkle.Controls.Add(this.txtEkstraMalz);
            this.grpEkstraMalzEkle.Controls.Add(this.label2);
            this.grpEkstraMalzEkle.Controls.Add(this.label1);
            this.grpEkstraMalzEkle.Location = new System.Drawing.Point(12, 12);
            this.grpEkstraMalzEkle.Name = "grpEkstraMalzEkle";
            this.grpEkstraMalzEkle.Size = new System.Drawing.Size(326, 156);
            this.grpEkstraMalzEkle.TabIndex = 1;
            this.grpEkstraMalzEkle.TabStop = false;
            this.grpEkstraMalzEkle.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnEkstraEkle
            // 
            this.btnEkstraEkle.Location = new System.Drawing.Point(151, 90);
            this.btnEkstraEkle.Name = "btnEkstraEkle";
            this.btnEkstraEkle.Size = new System.Drawing.Size(166, 51);
            this.btnEkstraEkle.TabIndex = 1;
            this.btnEkstraEkle.Text = "EKSTRA MALZEMEYİ KAYDET";
            this.btnEkstraEkle.UseVisualStyleBackColor = true;
            this.btnEkstraEkle.Click += new System.EventHandler(this.btnEkstraEkle_Click);
            // 
            // nmrEkstraFiyatı
            // 
            this.nmrEkstraFiyatı.DecimalPlaces = 2;
            this.nmrEkstraFiyatı.Location = new System.Drawing.Point(151, 58);
            this.nmrEkstraFiyatı.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrEkstraFiyatı.Name = "nmrEkstraFiyatı";
            this.nmrEkstraFiyatı.Size = new System.Drawing.Size(166, 26);
            this.nmrEkstraFiyatı.TabIndex = 3;
            this.nmrEkstraFiyatı.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtEkstraMalz
            // 
            this.txtEkstraMalz.Location = new System.Drawing.Point(151, 26);
            this.txtEkstraMalz.Name = "txtEkstraMalz";
            this.txtEkstraMalz.Size = new System.Drawing.Size(166, 26);
            this.txtEkstraMalz.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 176);
            this.Controls.Add(this.grpEkstraMalzEkle);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grpEkstraMalzEkle.ResumeLayout(false);
            this.grpEkstraMalzEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraFiyatı)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkstraMalzEkle;
        private System.Windows.Forms.Button btnEkstraEkle;
        private System.Windows.Forms.NumericUpDown nmrEkstraFiyatı;
        private System.Windows.Forms.TextBox txtEkstraMalz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}