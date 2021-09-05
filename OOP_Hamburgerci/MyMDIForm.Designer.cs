
namespace OOP_Hamburgerci
{
    partial class MyMDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fsmSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.fsmSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.fsmUrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.fsmMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.fsmEkstraEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişYönetimiToolStripMenuItem,
            this.fsmUrunYonetimi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fsmSiparisOlustur,
            this.fsmSiparisBilgileri});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // fsmSiparisOlustur
            // 
            this.fsmSiparisOlustur.Name = "fsmSiparisOlustur";
            this.fsmSiparisOlustur.Size = new System.Drawing.Size(180, 22);
            this.fsmSiparisOlustur.Text = "Sipariş Oluştur";
            this.fsmSiparisOlustur.Click += new System.EventHandler(this.fsmSiparisOlustur_Click);
            // 
            // fsmSiparisBilgileri
            // 
            this.fsmSiparisBilgileri.Name = "fsmSiparisBilgileri";
            this.fsmSiparisBilgileri.Size = new System.Drawing.Size(180, 22);
            this.fsmSiparisBilgileri.Text = "Sipariş Bilgileri";
            this.fsmSiparisBilgileri.Click += new System.EventHandler(this.fsmSiparisBilgileri_Click);
            // 
            // fsmUrunYonetimi
            // 
            this.fsmUrunYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fsmMenuEkle,
            this.fsmEkstraEkle});
            this.fsmUrunYonetimi.Name = "fsmUrunYonetimi";
            this.fsmUrunYonetimi.Size = new System.Drawing.Size(95, 20);
            this.fsmUrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // fsmMenuEkle
            // 
            this.fsmMenuEkle.Name = "fsmMenuEkle";
            this.fsmMenuEkle.Size = new System.Drawing.Size(180, 22);
            this.fsmMenuEkle.Text = "Menü Ekle";
            this.fsmMenuEkle.Click += new System.EventHandler(this.fsmMenuEkle_Click);
            // 
            // fsmEkstraEkle
            // 
            this.fsmEkstraEkle.Name = "fsmEkstraEkle";
            this.fsmEkstraEkle.Size = new System.Drawing.Size(180, 22);
            this.fsmEkstraEkle.Text = "Ekstra Malzeme Ekle";
            this.fsmEkstraEkle.Click += new System.EventHandler(this.fsmEkstraEkle_Click);
            // 
            // MyMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyMDIForm";
            this.Text = "MyMDIForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fsmSiparisOlustur;
        private System.Windows.Forms.ToolStripMenuItem fsmSiparisBilgileri;
        private System.Windows.Forms.ToolStripMenuItem fsmUrunYonetimi;
        private System.Windows.Forms.ToolStripMenuItem fsmMenuEkle;
        private System.Windows.Forms.ToolStripMenuItem fsmEkstraEkle;
    }
}