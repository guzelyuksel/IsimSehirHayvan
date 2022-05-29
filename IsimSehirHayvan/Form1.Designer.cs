namespace IsimSehirHayvan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHarfVer = new System.Windows.Forms.Button();
            this.lblHarf = new System.Windows.Forms.Label();
            this.tSure = new System.Windows.Forms.Timer(this.components);
            this.lblZaman = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblOyunSekli = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblIsimKural = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.lblSehirKural = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.tableSoruPaneli = new System.Windows.Forms.TableLayoutPanel();
            this.lblHayvan = new System.Windows.Forms.Label();
            this.lblBitki = new System.Windows.Forms.Label();
            this.lblEsya = new System.Windows.Forms.Label();
            this.lblUnlu = new System.Windows.Forms.Label();
            this.txtHayvan = new System.Windows.Forms.TextBox();
            this.txtBitki = new System.Windows.Forms.TextBox();
            this.txtEsya = new System.Windows.Forms.TextBox();
            this.txtUnlu = new System.Windows.Forms.TextBox();
            this.lblHayvanKural = new System.Windows.Forms.Label();
            this.lblBitkiKural = new System.Windows.Forms.Label();
            this.lblEsyaKural = new System.Windows.Forms.Label();
            this.lblUnluKural = new System.Windows.Forms.Label();
            this.lblKurallar = new System.Windows.Forms.Label();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.lblPuan = new System.Windows.Forms.Label();
            this.pbUnlu = new System.Windows.Forms.PictureBox();
            this.pbEsya = new System.Windows.Forms.PictureBox();
            this.pbBitki = new System.Windows.Forms.PictureBox();
            this.pbHayvan = new System.Windows.Forms.PictureBox();
            this.pbSehir = new System.Windows.Forms.PictureBox();
            this.pbIsim = new System.Windows.Forms.PictureBox();
            this.tableSoruPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEsya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBitki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHayvan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHarfVer
            // 
            this.btnHarfVer.Location = new System.Drawing.Point(12, 12);
            this.btnHarfVer.Name = "btnHarfVer";
            this.btnHarfVer.Size = new System.Drawing.Size(91, 32);
            this.btnHarfVer.TabIndex = 0;
            this.btnHarfVer.Text = "Harf Ver";
            this.btnHarfVer.UseVisualStyleBackColor = true;
            this.btnHarfVer.Click += new System.EventHandler(this.btnHarfVer_Click);
            // 
            // lblHarf
            // 
            this.lblHarf.AutoSize = true;
            this.lblHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHarf.Location = new System.Drawing.Point(109, 20);
            this.lblHarf.Name = "lblHarf";
            this.lblHarf.Size = new System.Drawing.Size(44, 16);
            this.lblHarf.TabIndex = 1;
            this.lblHarf.Text = "Harf: ";
            // 
            // tSure
            // 
            this.tSure.Interval = 1000;
            this.tSure.Tick += new System.EventHandler(this.tSure_Tick);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(273, 20);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(62, 16);
            this.lblZaman.TabIndex = 3;
            this.lblZaman.Text = "Zaman: ";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Enabled = false;
            this.btnBaslat.Location = new System.Drawing.Point(176, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(91, 32);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Süreyi Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblOyunSekli
            // 
            this.lblOyunSekli.AutoSize = true;
            this.lblOyunSekli.BackColor = System.Drawing.SystemColors.Control;
            this.lblOyunSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyunSekli.ForeColor = System.Drawing.Color.Red;
            this.lblOyunSekli.Location = new System.Drawing.Point(12, 61);
            this.lblOyunSekli.Name = "lblOyunSekli";
            this.lblOyunSekli.Size = new System.Drawing.Size(804, 15);
            this.lblOyunSekli.TabIndex = 4;
            this.lblOyunSekli.Text = "Oyun Şekli: 60 saniye içinde size yukarıda verilen harfe göre, aşağıdaki alanları" +
    " ilk harfi verilen harf olacak şekilde doldurun.";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsim.Location = new System.Drawing.Point(3, 0);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(86, 15);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "İsim (10 puan)";
            // 
            // lblIsimKural
            // 
            this.lblIsimKural.AutoSize = true;
            this.lblIsimKural.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsimKural.Location = new System.Drawing.Point(3, 42);
            this.lblIsimKural.Name = "lblIsimKural";
            this.lblIsimKural.Size = new System.Drawing.Size(64, 15);
            this.lblIsimKural.TabIndex = 1;
            this.lblIsimKural.Text = "Min 2 Harf";
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(3, 18);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(135, 21);
            this.txtIsim.TabIndex = 2;
            // 
            // txtSehir
            // 
            this.txtSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSehir.Location = new System.Drawing.Point(144, 18);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(135, 21);
            this.txtSehir.TabIndex = 5;
            // 
            // lblSehirKural
            // 
            this.lblSehirKural.AutoSize = true;
            this.lblSehirKural.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehirKural.Location = new System.Drawing.Point(144, 42);
            this.lblSehirKural.Name = "lblSehirKural";
            this.lblSehirKural.Size = new System.Drawing.Size(64, 15);
            this.lblSehirKural.TabIndex = 4;
            this.lblSehirKural.Text = "Min 3 Harf";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehir.Location = new System.Drawing.Point(144, 0);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(92, 15);
            this.lblSehir.TabIndex = 3;
            this.lblSehir.Text = "Şehir (10 puan)";
            // 
            // tableSoruPaneli
            // 
            this.tableSoruPaneli.AutoSize = true;
            this.tableSoruPaneli.ColumnCount = 6;
            this.tableSoruPaneli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSoruPaneli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSoruPaneli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSoruPaneli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSoruPaneli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSoruPaneli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSoruPaneli.Controls.Add(this.pbUnlu, 5, 3);
            this.tableSoruPaneli.Controls.Add(this.pbEsya, 4, 3);
            this.tableSoruPaneli.Controls.Add(this.pbBitki, 3, 3);
            this.tableSoruPaneli.Controls.Add(this.pbHayvan, 2, 3);
            this.tableSoruPaneli.Controls.Add(this.pbSehir, 1, 3);
            this.tableSoruPaneli.Controls.Add(this.pbIsim, 0, 3);
            this.tableSoruPaneli.Controls.Add(this.lblUnluKural, 5, 2);
            this.tableSoruPaneli.Controls.Add(this.lblEsyaKural, 4, 2);
            this.tableSoruPaneli.Controls.Add(this.lblBitkiKural, 3, 2);
            this.tableSoruPaneli.Controls.Add(this.lblHayvanKural, 2, 2);
            this.tableSoruPaneli.Controls.Add(this.txtUnlu, 5, 1);
            this.tableSoruPaneli.Controls.Add(this.txtEsya, 4, 1);
            this.tableSoruPaneli.Controls.Add(this.txtBitki, 3, 1);
            this.tableSoruPaneli.Controls.Add(this.txtHayvan, 2, 1);
            this.tableSoruPaneli.Controls.Add(this.lblUnlu, 5, 0);
            this.tableSoruPaneli.Controls.Add(this.lblEsya, 4, 0);
            this.tableSoruPaneli.Controls.Add(this.lblBitki, 3, 0);
            this.tableSoruPaneli.Controls.Add(this.lblHayvan, 2, 0);
            this.tableSoruPaneli.Controls.Add(this.lblSehirKural, 1, 2);
            this.tableSoruPaneli.Controls.Add(this.txtSehir, 1, 1);
            this.tableSoruPaneli.Controls.Add(this.lblIsim, 0, 0);
            this.tableSoruPaneli.Controls.Add(this.lblSehir, 1, 0);
            this.tableSoruPaneli.Controls.Add(this.txtIsim, 0, 1);
            this.tableSoruPaneli.Controls.Add(this.lblIsimKural, 0, 2);
            this.tableSoruPaneli.Location = new System.Drawing.Point(15, 93);
            this.tableSoruPaneli.Name = "tableSoruPaneli";
            this.tableSoruPaneli.RowCount = 4;
            this.tableSoruPaneli.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSoruPaneli.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSoruPaneli.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSoruPaneli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSoruPaneli.Size = new System.Drawing.Size(846, 82);
            this.tableSoruPaneli.TabIndex = 6;
            // 
            // lblHayvan
            // 
            this.lblHayvan.AutoSize = true;
            this.lblHayvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHayvan.Location = new System.Drawing.Point(285, 0);
            this.lblHayvan.Name = "lblHayvan";
            this.lblHayvan.Size = new System.Drawing.Size(103, 15);
            this.lblHayvan.TabIndex = 6;
            this.lblHayvan.Text = "Hayvan (10 puan)";
            // 
            // lblBitki
            // 
            this.lblBitki.AutoSize = true;
            this.lblBitki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitki.Location = new System.Drawing.Point(426, 0);
            this.lblBitki.Name = "lblBitki";
            this.lblBitki.Size = new System.Drawing.Size(86, 15);
            this.lblBitki.TabIndex = 7;
            this.lblBitki.Text = "Bitki (10 puan)";
            // 
            // lblEsya
            // 
            this.lblEsya.AutoSize = true;
            this.lblEsya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEsya.Location = new System.Drawing.Point(567, 0);
            this.lblEsya.Name = "lblEsya";
            this.lblEsya.Size = new System.Drawing.Size(89, 15);
            this.lblEsya.TabIndex = 8;
            this.lblEsya.Text = "Eşya (10 puan)";
            // 
            // lblUnlu
            // 
            this.lblUnlu.AutoSize = true;
            this.lblUnlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnlu.Location = new System.Drawing.Point(708, 0);
            this.lblUnlu.Name = "lblUnlu";
            this.lblUnlu.Size = new System.Drawing.Size(89, 15);
            this.lblUnlu.TabIndex = 9;
            this.lblUnlu.Text = "Ünlü (10 puan)";
            // 
            // txtHayvan
            // 
            this.txtHayvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHayvan.Location = new System.Drawing.Point(285, 18);
            this.txtHayvan.Name = "txtHayvan";
            this.txtHayvan.Size = new System.Drawing.Size(135, 21);
            this.txtHayvan.TabIndex = 10;
            // 
            // txtBitki
            // 
            this.txtBitki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBitki.Location = new System.Drawing.Point(426, 18);
            this.txtBitki.Name = "txtBitki";
            this.txtBitki.Size = new System.Drawing.Size(135, 21);
            this.txtBitki.TabIndex = 11;
            // 
            // txtEsya
            // 
            this.txtEsya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEsya.Location = new System.Drawing.Point(567, 18);
            this.txtEsya.Name = "txtEsya";
            this.txtEsya.Size = new System.Drawing.Size(135, 21);
            this.txtEsya.TabIndex = 12;
            // 
            // txtUnlu
            // 
            this.txtUnlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnlu.Location = new System.Drawing.Point(708, 18);
            this.txtUnlu.Name = "txtUnlu";
            this.txtUnlu.Size = new System.Drawing.Size(135, 21);
            this.txtUnlu.TabIndex = 13;
            // 
            // lblHayvanKural
            // 
            this.lblHayvanKural.AutoSize = true;
            this.lblHayvanKural.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHayvanKural.Location = new System.Drawing.Point(285, 42);
            this.lblHayvanKural.Name = "lblHayvanKural";
            this.lblHayvanKural.Size = new System.Drawing.Size(64, 15);
            this.lblHayvanKural.TabIndex = 14;
            this.lblHayvanKural.Text = "Min 2 Harf";
            // 
            // lblBitkiKural
            // 
            this.lblBitkiKural.AutoSize = true;
            this.lblBitkiKural.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitkiKural.Location = new System.Drawing.Point(426, 42);
            this.lblBitkiKural.Name = "lblBitkiKural";
            this.lblBitkiKural.Size = new System.Drawing.Size(64, 15);
            this.lblBitkiKural.TabIndex = 15;
            this.lblBitkiKural.Text = "Min 3 Harf";
            // 
            // lblEsyaKural
            // 
            this.lblEsyaKural.AutoSize = true;
            this.lblEsyaKural.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEsyaKural.Location = new System.Drawing.Point(567, 42);
            this.lblEsyaKural.Name = "lblEsyaKural";
            this.lblEsyaKural.Size = new System.Drawing.Size(64, 15);
            this.lblEsyaKural.TabIndex = 16;
            this.lblEsyaKural.Text = "Min 3 Harf";
            // 
            // lblUnluKural
            // 
            this.lblUnluKural.AutoSize = true;
            this.lblUnluKural.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnluKural.Location = new System.Drawing.Point(708, 42);
            this.lblUnluKural.Name = "lblUnluKural";
            this.lblUnluKural.Size = new System.Drawing.Size(64, 15);
            this.lblUnluKural.TabIndex = 17;
            this.lblUnluKural.Text = "Min 5 Harf";
            // 
            // lblKurallar
            // 
            this.lblKurallar.AutoSize = true;
            this.lblKurallar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKurallar.ForeColor = System.Drawing.Color.Red;
            this.lblKurallar.Location = new System.Drawing.Point(12, 200);
            this.lblKurallar.Name = "lblKurallar";
            this.lblKurallar.Size = new System.Drawing.Size(584, 105);
            this.lblKurallar.TabIndex = 7;
            this.lblKurallar.Text = resources.GetString("lblKurallar.Text");
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Enabled = false;
            this.btnKontrolEt.Location = new System.Drawing.Point(864, 93);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(147, 82);
            this.btnKontrolEt.TabIndex = 8;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(1017, 123);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(55, 20);
            this.lblPuan.TabIndex = 9;
            this.lblPuan.Text = "Puan:";
            // 
            // pbUnlu
            // 
            this.pbUnlu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUnlu.Location = new System.Drawing.Point(708, 60);
            this.pbUnlu.Name = "pbUnlu";
            this.pbUnlu.Size = new System.Drawing.Size(135, 19);
            this.pbUnlu.TabIndex = 22;
            this.pbUnlu.TabStop = false;
            // 
            // pbEsya
            // 
            this.pbEsya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEsya.Location = new System.Drawing.Point(567, 60);
            this.pbEsya.Name = "pbEsya";
            this.pbEsya.Size = new System.Drawing.Size(135, 19);
            this.pbEsya.TabIndex = 21;
            this.pbEsya.TabStop = false;
            // 
            // pbBitki
            // 
            this.pbBitki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBitki.Location = new System.Drawing.Point(426, 60);
            this.pbBitki.Name = "pbBitki";
            this.pbBitki.Size = new System.Drawing.Size(135, 19);
            this.pbBitki.TabIndex = 20;
            this.pbBitki.TabStop = false;
            // 
            // pbHayvan
            // 
            this.pbHayvan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHayvan.Location = new System.Drawing.Point(285, 60);
            this.pbHayvan.Name = "pbHayvan";
            this.pbHayvan.Size = new System.Drawing.Size(135, 19);
            this.pbHayvan.TabIndex = 19;
            this.pbHayvan.TabStop = false;
            // 
            // pbSehir
            // 
            this.pbSehir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSehir.Location = new System.Drawing.Point(144, 60);
            this.pbSehir.Name = "pbSehir";
            this.pbSehir.Size = new System.Drawing.Size(135, 19);
            this.pbSehir.TabIndex = 18;
            this.pbSehir.TabStop = false;
            // 
            // pbIsim
            // 
            this.pbIsim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbIsim.Location = new System.Drawing.Point(3, 60);
            this.pbIsim.Name = "pbIsim";
            this.pbIsim.Size = new System.Drawing.Size(135, 19);
            this.pbIsim.TabIndex = 10;
            this.pbIsim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 327);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.lblKurallar);
            this.Controls.Add(this.tableSoruPaneli);
            this.Controls.Add(this.lblOyunSekli);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lblHarf);
            this.Controls.Add(this.btnHarfVer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableSoruPaneli.ResumeLayout(false);
            this.tableSoruPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEsya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBitki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHayvan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHarfVer;
        private System.Windows.Forms.Label lblHarf;
        private System.Windows.Forms.Timer tSure;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblOyunSekli;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblIsimKural;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Label lblSehirKural;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.TableLayoutPanel tableSoruPaneli;
        private System.Windows.Forms.Label lblUnlu;
        private System.Windows.Forms.Label lblEsya;
        private System.Windows.Forms.Label lblBitki;
        private System.Windows.Forms.Label lblHayvan;
        private System.Windows.Forms.TextBox txtUnlu;
        private System.Windows.Forms.TextBox txtEsya;
        private System.Windows.Forms.TextBox txtBitki;
        private System.Windows.Forms.TextBox txtHayvan;
        private System.Windows.Forms.Label lblUnluKural;
        private System.Windows.Forms.Label lblEsyaKural;
        private System.Windows.Forms.Label lblBitkiKural;
        private System.Windows.Forms.Label lblHayvanKural;
        private System.Windows.Forms.Label lblKurallar;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.PictureBox pbUnlu;
        private System.Windows.Forms.PictureBox pbEsya;
        private System.Windows.Forms.PictureBox pbBitki;
        private System.Windows.Forms.PictureBox pbHayvan;
        private System.Windows.Forms.PictureBox pbSehir;
        private System.Windows.Forms.PictureBox pbIsim;
    }
}

