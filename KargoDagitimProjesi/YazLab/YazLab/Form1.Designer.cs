
namespace YazLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullanıcı = new System.Windows.Forms.TextBox();
            this.kullanıcılabel = new System.Windows.Forms.Label();
            this.giris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.sifrelabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uyesifre = new System.Windows.Forms.TextBox();
            this.uyekullanici = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.updatesifre = new System.Windows.Forms.TextBox();
            this.upadatekullanici = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.müsteriAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.müsteriID = new System.Windows.Forms.TextBox();
            this.kargoID = new System.Windows.Forms.TextBox();
            this.müsteriEnlem = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.müsteriBoylam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kargoSil = new System.Windows.Forms.Button();
            this.kargoEkle = new System.Windows.Forms.Button();
            this.map2 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullanıcı
            // 
            this.kullanıcı.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kullanıcı.Location = new System.Drawing.Point(39, 161);
            this.kullanıcı.Name = "kullanıcı";
            this.kullanıcı.Size = new System.Drawing.Size(142, 27);
            this.kullanıcı.TabIndex = 0;
            // 
            // kullanıcılabel
            // 
            this.kullanıcılabel.AutoSize = true;
            this.kullanıcılabel.Location = new System.Drawing.Point(54, 123);
            this.kullanıcılabel.Name = "kullanıcılabel";
            this.kullanıcılabel.Size = new System.Drawing.Size(124, 25);
            this.kullanıcılabel.TabIndex = 1;
            this.kullanıcılabel.Text = "Kullanıcı Adı:";
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(54, 252);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(110, 34);
            this.giris.TabIndex = 2;
            this.giris.Text = "GİRİŞ";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.sifre);
            this.groupBox1.Controls.Add(this.kullanıcı);
            this.groupBox1.Controls.Add(this.sifrelabel);
            this.groupBox1.Controls.Add(this.kullanıcılabel);
            this.groupBox1.Controls.Add(this.giris);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 352);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YazLab.Properties.Resources.Ekran_Alıntısı;
            this.pictureBox1.Location = new System.Drawing.Point(56, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // sifre
            // 
            this.sifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sifre.Location = new System.Drawing.Point(39, 219);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(142, 27);
            this.sifre.TabIndex = 5;
            // 
            // sifrelabel
            // 
            this.sifrelabel.AutoSize = true;
            this.sifrelabel.Location = new System.Drawing.Point(77, 191);
            this.sifrelabel.Name = "sifrelabel";
            this.sifrelabel.Size = new System.Drawing.Size(56, 25);
            this.sifrelabel.TabIndex = 4;
            this.sifrelabel.Text = "Şifre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.uyesifre);
            this.groupBox2.Controls.Add(this.uyekullanici);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(329, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 352);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜYE OL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YazLab.Properties.Resources.Ekran_Alıntısı1;
            this.pictureBox2.Location = new System.Drawing.Point(37, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // uyesifre
            // 
            this.uyesifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uyesifre.Location = new System.Drawing.Point(121, 192);
            this.uyesifre.Name = "uyesifre";
            this.uyesifre.Size = new System.Drawing.Size(136, 27);
            this.uyesifre.TabIndex = 5;
            // 
            // uyekullanici
            // 
            this.uyekullanici.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uyekullanici.Location = new System.Drawing.Point(121, 159);
            this.uyekullanici.Name = "uyekullanici";
            this.uyekullanici.Size = new System.Drawing.Size(136, 27);
            this.uyekullanici.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "ÜYE OL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.updatesifre);
            this.groupBox3.Controls.Add(this.upadatekullanici);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(23, 391);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 296);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ŞİFRE YENİLEME";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::YazLab.Properties.Resources.Ekran_Alıntısı2;
            this.pictureBox3.Location = new System.Drawing.Point(39, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 189);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // updatesifre
            // 
            this.updatesifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatesifre.Location = new System.Drawing.Point(285, 175);
            this.updatesifre.Name = "updatesifre";
            this.updatesifre.Size = new System.Drawing.Size(229, 27);
            this.updatesifre.TabIndex = 5;
            // 
            // upadatekullanici
            // 
            this.upadatekullanici.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.upadatekullanici.Location = new System.Drawing.Point(285, 104);
            this.upadatekullanici.Name = "upadatekullanici";
            this.upadatekullanici.Size = new System.Drawing.Size(229, 27);
            this.upadatekullanici.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yeni Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "ŞİFRE GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(776, 549);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(744, 454);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Müşteri No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Enlem";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Boylam";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kargo ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Müşteri Adı:";
            // 
            // müsteriAd
            // 
            this.müsteriAd.Location = new System.Drawing.Point(166, 30);
            this.müsteriAd.Name = "müsteriAd";
            this.müsteriAd.Size = new System.Drawing.Size(189, 31);
            this.müsteriAd.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Müşteri No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(8, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kargo No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Müşteri Enlem:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // müsteriID
            // 
            this.müsteriID.Location = new System.Drawing.Point(166, 67);
            this.müsteriID.Name = "müsteriID";
            this.müsteriID.Size = new System.Drawing.Size(189, 31);
            this.müsteriID.TabIndex = 12;
            // 
            // kargoID
            // 
            this.kargoID.Location = new System.Drawing.Point(166, 104);
            this.kargoID.Name = "kargoID";
            this.kargoID.Size = new System.Drawing.Size(189, 31);
            this.kargoID.TabIndex = 13;
            // 
            // müsteriEnlem
            // 
            this.müsteriEnlem.Location = new System.Drawing.Point(166, 146);
            this.müsteriEnlem.Name = "müsteriEnlem";
            this.müsteriEnlem.Size = new System.Drawing.Size(189, 31);
            this.müsteriEnlem.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.müsteriBoylam);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.kargoSil);
            this.groupBox4.Controls.Add(this.kargoEkle);
            this.groupBox4.Controls.Add(this.müsteriAd);
            this.groupBox4.Controls.Add(this.müsteriEnlem);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.kargoID);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.müsteriID);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(23, 693);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(651, 244);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Teslimat Durum";
            // 
            // müsteriBoylam
            // 
            this.müsteriBoylam.Location = new System.Drawing.Point(166, 186);
            this.müsteriBoylam.Name = "müsteriBoylam";
            this.müsteriBoylam.Size = new System.Drawing.Size(189, 31);
            this.müsteriBoylam.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(8, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Müşteri Boylam:";
            // 
            // kargoSil
            // 
            this.kargoSil.Location = new System.Drawing.Point(380, 135);
            this.kargoSil.Name = "kargoSil";
            this.kargoSil.Size = new System.Drawing.Size(204, 42);
            this.kargoSil.TabIndex = 16;
            this.kargoSil.Text = "SİL";
            this.kargoSil.UseVisualStyleBackColor = true;
            this.kargoSil.Click += new System.EventHandler(this.kargoSil_Click);
            // 
            // kargoEkle
            // 
            this.kargoEkle.Location = new System.Drawing.Point(380, 61);
            this.kargoEkle.Name = "kargoEkle";
            this.kargoEkle.Size = new System.Drawing.Size(204, 42);
            this.kargoEkle.TabIndex = 15;
            this.kargoEkle.Text = "EKLE";
            this.kargoEkle.UseVisualStyleBackColor = true;
            this.kargoEkle.Click += new System.EventHandler(this.kargoEkle_Click);
            // 
            // map2
            // 
            this.map2.Bearing = 0F;
            this.map2.CanDragMap = true;
            this.map2.EmptyTileColor = System.Drawing.Color.Navy;
            this.map2.GrayScaleMode = false;
            this.map2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map2.LevelsKeepInMemory = 5;
            this.map2.Location = new System.Drawing.Point(699, 33);
            this.map2.MarkersEnabled = true;
            this.map2.MaxZoom = 2;
            this.map2.MinZoom = 2;
            this.map2.MouseWheelZoomEnabled = true;
            this.map2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map2.Name = "map2";
            this.map2.NegativeMode = false;
            this.map2.PolygonsEnabled = true;
            this.map2.RetryLoadTile = 0;
            this.map2.RoutesEnabled = true;
            this.map2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map2.ShowTileGridLines = false;
            this.map2.Size = new System.Drawing.Size(842, 468);
            this.map2.TabIndex = 17;
            this.map2.Zoom = 0D;
            this.map2.Load += new System.EventHandler(this.map2_Load);
            this.map2.Click += new System.EventHandler(this.map2_Load);
            this.map2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map2_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1553, 1047);
            this.Controls.Add(this.map2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox kullanıcı;
        private System.Windows.Forms.Label kullanıcılabel;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label sifrelabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox uyesifre;
        private System.Windows.Forms.TextBox uyekullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox updatesifre;
        private System.Windows.Forms.TextBox upadatekullanici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox müsteriAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox müsteriID;
        private System.Windows.Forms.TextBox kargoID;
        private System.Windows.Forms.TextBox müsteriEnlem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button kargoSil;
        private System.Windows.Forms.Button kargoEkle;
        private GMap.NET.WindowsForms.GMapControl map2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox müsteriBoylam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

