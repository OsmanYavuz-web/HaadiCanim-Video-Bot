namespace HaadiCanım_Video_Bot
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView_VideoListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Tirnak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progress_VideoYukleme = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.progress_VideoIndirme = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.button_VideoEkle = new System.Windows.Forms.Button();
            this.label_Aciklama_Limit = new System.Windows.Forms.Label();
            this.label_Baslik_Limit = new System.Windows.Forms.Label();
            this.textBox_VideoKategori = new System.Windows.Forms.TextBox();
            this.pictureBox_VideoResim = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_VideoAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_VideoEtiketleri = new System.Windows.Forms.TextBox();
            this.textBox_VideoAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_VideoResim = new System.Windows.Forms.TextBox();
            this.textBox_VideoKaynak = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_VideoLocalKayitYol = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox_YoutubeLink = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoResim)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Videoları Çek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView_VideoListesi
            // 
            this.listView_VideoListesi.BackColor = System.Drawing.SystemColors.Window;
            this.listView_VideoListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_VideoListesi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_VideoListesi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView_VideoListesi.FullRowSelect = true;
            this.listView_VideoListesi.LabelWrap = false;
            this.listView_VideoListesi.Location = new System.Drawing.Point(12, 42);
            this.listView_VideoListesi.Name = "listView_VideoListesi";
            this.listView_VideoListesi.Size = new System.Drawing.Size(577, 190);
            this.listView_VideoListesi.TabIndex = 1;
            this.listView_VideoListesi.UseCompatibleStateImageBehavior = false;
            this.listView_VideoListesi.View = System.Windows.Forms.View.Details;
            this.listView_VideoListesi.SelectedIndexChanged += new System.EventHandler(this.listView_VideoListesi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Video Adı";
            this.columnHeader1.Width = 550;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Video Url";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Video Resim";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Video Açıklama";
            this.columnHeader4.Width = 0;
            // 
            // textBox_Tirnak
            // 
            this.textBox_Tirnak.Location = new System.Drawing.Point(593, 14);
            this.textBox_Tirnak.Name = "textBox_Tirnak";
            this.textBox_Tirnak.ReadOnly = true;
            this.textBox_Tirnak.Size = new System.Drawing.Size(14, 22);
            this.textBox_Tirnak.TabIndex = 4;
            this.textBox_Tirnak.Text = "\"";
            this.textBox_Tirnak.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progress_VideoYukleme);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.progress_VideoIndirme);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button_VideoEkle);
            this.groupBox1.Controls.Add(this.label_Aciklama_Limit);
            this.groupBox1.Controls.Add(this.label_Baslik_Limit);
            this.groupBox1.Controls.Add(this.textBox_VideoKategori);
            this.groupBox1.Controls.Add(this.pictureBox_VideoResim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_VideoAdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_VideoEtiketleri);
            this.groupBox1.Controls.Add(this.textBox_VideoAciklama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 394);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçili Video Bilgileri";
            // 
            // progress_VideoYukleme
            // 
            this.progress_VideoYukleme.Location = new System.Drawing.Point(180, 347);
            this.progress_VideoYukleme.Name = "progress_VideoYukleme";
            this.progress_VideoYukleme.Size = new System.Drawing.Size(376, 12);
            this.progress_VideoYukleme.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 14);
            this.label12.TabIndex = 20;
            this.label12.Text = "Youtube Video Yükleme";
            // 
            // progress_VideoIndirme
            // 
            this.progress_VideoIndirme.Location = new System.Drawing.Point(180, 320);
            this.progress_VideoIndirme.Name = "progress_VideoIndirme";
            this.progress_VideoIndirme.Size = new System.Drawing.Size(376, 12);
            this.progress_VideoIndirme.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "Video İndirme Durumu";
            // 
            // button_VideoEkle
            // 
            this.button_VideoEkle.AutoSize = true;
            this.button_VideoEkle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_VideoEkle.Enabled = false;
            this.button_VideoEkle.Location = new System.Drawing.Point(22, 266);
            this.button_VideoEkle.Name = "button_VideoEkle";
            this.button_VideoEkle.Size = new System.Drawing.Size(534, 40);
            this.button_VideoEkle.TabIndex = 18;
            this.button_VideoEkle.Text = "Videoyu Siteye Ekle";
            this.button_VideoEkle.UseVisualStyleBackColor = false;
            this.button_VideoEkle.Click += new System.EventHandler(this.button_VideoEkle_Click);
            // 
            // label_Aciklama_Limit
            // 
            this.label_Aciklama_Limit.AutoSize = true;
            this.label_Aciklama_Limit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Aciklama_Limit.Location = new System.Drawing.Point(371, 71);
            this.label_Aciklama_Limit.Name = "label_Aciklama_Limit";
            this.label_Aciklama_Limit.Size = new System.Drawing.Size(14, 14);
            this.label_Aciklama_Limit.TabIndex = 17;
            this.label_Aciklama_Limit.Text = "0";
            this.label_Aciklama_Limit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Baslik_Limit
            // 
            this.label_Baslik_Limit.AutoSize = true;
            this.label_Baslik_Limit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Baslik_Limit.Location = new System.Drawing.Point(89, 27);
            this.label_Baslik_Limit.Name = "label_Baslik_Limit";
            this.label_Baslik_Limit.Size = new System.Drawing.Size(14, 14);
            this.label_Baslik_Limit.TabIndex = 12;
            this.label_Baslik_Limit.Text = "0";
            this.label_Baslik_Limit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_VideoKategori
            // 
            this.textBox_VideoKategori.Location = new System.Drawing.Point(270, 196);
            this.textBox_VideoKategori.Name = "textBox_VideoKategori";
            this.textBox_VideoKategori.Size = new System.Drawing.Size(286, 22);
            this.textBox_VideoKategori.TabIndex = 11;
            // 
            // pictureBox_VideoResim
            // 
            this.pictureBox_VideoResim.Location = new System.Drawing.Point(21, 86);
            this.pictureBox_VideoResim.Name = "pictureBox_VideoResim";
            this.pictureBox_VideoResim.Size = new System.Drawing.Size(234, 132);
            this.pictureBox_VideoResim.TabIndex = 5;
            this.pictureBox_VideoResim.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Video Kategori";
            // 
            // textBox_VideoAdi
            // 
            this.textBox_VideoAdi.Location = new System.Drawing.Point(22, 44);
            this.textBox_VideoAdi.Name = "textBox_VideoAdi";
            this.textBox_VideoAdi.Size = new System.Drawing.Size(534, 22);
            this.textBox_VideoAdi.TabIndex = 4;
            this.textBox_VideoAdi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_VideoAdi_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "Video Resim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Video Adı -";
            // 
            // textBox_VideoEtiketleri
            // 
            this.textBox_VideoEtiketleri.Location = new System.Drawing.Point(21, 238);
            this.textBox_VideoEtiketleri.Name = "textBox_VideoEtiketleri";
            this.textBox_VideoEtiketleri.Size = new System.Drawing.Size(535, 22);
            this.textBox_VideoEtiketleri.TabIndex = 7;
            // 
            // textBox_VideoAciklama
            // 
            this.textBox_VideoAciklama.Location = new System.Drawing.Point(270, 88);
            this.textBox_VideoAciklama.Multiline = true;
            this.textBox_VideoAciklama.Name = "textBox_VideoAciklama";
            this.textBox_VideoAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_VideoAciklama.Size = new System.Drawing.Size(286, 88);
            this.textBox_VideoAciklama.TabIndex = 6;
            this.textBox_VideoAciklama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_VideoAciklama_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Video Açıklama -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Video Etiket";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(613, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 22);
            this.textBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Site Kaynak Url";
            // 
            // textBox_VideoResim
            // 
            this.textBox_VideoResim.Location = new System.Drawing.Point(613, 259);
            this.textBox_VideoResim.Name = "textBox_VideoResim";
            this.textBox_VideoResim.Size = new System.Drawing.Size(234, 22);
            this.textBox_VideoResim.TabIndex = 12;
            // 
            // textBox_VideoKaynak
            // 
            this.textBox_VideoKaynak.Location = new System.Drawing.Point(612, 306);
            this.textBox_VideoKaynak.Name = "textBox_VideoKaynak";
            this.textBox_VideoKaynak.Size = new System.Drawing.Size(235, 22);
            this.textBox_VideoKaynak.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Video Kaynak";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(613, 17);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(244, 167);
            this.webBrowser1.TabIndex = 15;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "Video Resim Url";
            // 
            // textBox_VideoLocalKayitYol
            // 
            this.textBox_VideoLocalKayitYol.Location = new System.Drawing.Point(613, 353);
            this.textBox_VideoLocalKayitYol.Name = "textBox_VideoLocalKayitYol";
            this.textBox_VideoLocalKayitYol.Size = new System.Drawing.Size(235, 22);
            this.textBox_VideoLocalKayitYol.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(610, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 14);
            this.label11.TabIndex = 17;
            this.label11.Text = "Video Local Kayıt Yol";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(881, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(72, 17);
            this.statusLabel.Text = "Bekleniyor..";
            // 
            // textBox_YoutubeLink
            // 
            this.textBox_YoutubeLink.Location = new System.Drawing.Point(612, 399);
            this.textBox_YoutubeLink.Name = "textBox_YoutubeLink";
            this.textBox_YoutubeLink.Size = new System.Drawing.Size(235, 22);
            this.textBox_YoutubeLink.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(609, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 14);
            this.label13.TabIndex = 20;
            this.label13.Text = "Youtube Link";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 659);
            this.Controls.Add(this.textBox_YoutubeLink);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox_VideoLocalKayitYol);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_VideoKaynak);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_VideoResim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Tirnak);
            this.Controls.Add(this.listView_VideoListesi);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HaadiCanim.com Video Botu v1.0 | Osman Yavuz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoResim)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView_VideoListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox textBox_Tirnak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_VideoEtiketleri;
        private System.Windows.Forms.TextBox textBox_VideoAciklama;
        private System.Windows.Forms.PictureBox pictureBox_VideoResim;
        private System.Windows.Forms.TextBox textBox_VideoAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox_VideoKaynak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_VideoKategori;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_VideoResim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label_Baslik_Limit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_Aciklama_Limit;
        private System.Windows.Forms.Button button_VideoEkle;
        private System.Windows.Forms.ProgressBar progress_VideoIndirme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_VideoLocalKayitYol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ProgressBar progress_VideoYukleme;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_YoutubeLink;
        private System.Windows.Forms.Label label13;

    }
}

