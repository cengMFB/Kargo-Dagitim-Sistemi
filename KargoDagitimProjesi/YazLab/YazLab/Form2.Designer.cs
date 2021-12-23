
namespace YazLab
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textEnlem = new System.Windows.Forms.TextBox();
            this.textBoylam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnRemoveOverlay = new System.Windows.Forms.Button();
            this.btnTeslimat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(833, 659);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(8, 8);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(809, 651);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(856, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enlem";
            // 
            // textEnlem
            // 
            this.textEnlem.Location = new System.Drawing.Point(943, 56);
            this.textEnlem.Name = "textEnlem";
            this.textEnlem.Size = new System.Drawing.Size(125, 27);
            this.textEnlem.TabIndex = 3;
            // 
            // textBoylam
            // 
            this.textBoylam.Location = new System.Drawing.Point(943, 118);
            this.textBoylam.Name = "textBoylam";
            this.textBoylam.Size = new System.Drawing.Size(125, 27);
            this.textBoylam.TabIndex = 4;
            this.textBoylam.TextChanged += new System.EventHandler(this.textBoylam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Boylam";
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(943, 172);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(125, 42);
            this.btnAddPoint.TabIndex = 8;
            this.btnAddPoint.Text = "Kuryeciyi Ekle";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click_1);
            // 
            // btnRemoveOverlay
            // 
            this.btnRemoveOverlay.Location = new System.Drawing.Point(943, 304);
            this.btnRemoveOverlay.Name = "btnRemoveOverlay";
            this.btnRemoveOverlay.Size = new System.Drawing.Size(125, 43);
            this.btnRemoveOverlay.TabIndex = 11;
            this.btnRemoveOverlay.Text = "Sil";
            this.btnRemoveOverlay.UseVisualStyleBackColor = true;
            this.btnRemoveOverlay.Click += new System.EventHandler(this.btnRemoveOverlay_Click_1);
            // 
            // btnTeslimat
            // 
            this.btnTeslimat.Location = new System.Drawing.Point(943, 244);
            this.btnTeslimat.Name = "btnTeslimat";
            this.btnTeslimat.Size = new System.Drawing.Size(125, 40);
            this.btnTeslimat.TabIndex = 12;
            this.btnTeslimat.Text = "Teslimatı Başlat";
            this.btnTeslimat.UseVisualStyleBackColor = true;
            this.btnTeslimat.Click += new System.EventHandler(this.btnTeslimat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 659);
            this.Controls.Add(this.btnTeslimat);
            this.Controls.Add(this.btnRemoveOverlay);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoylam);
            this.Controls.Add(this.textEnlem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEnlem;
        private System.Windows.Forms.TextBox textBoylam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button btnRemoveOverlay;
        private System.Windows.Forms.Button btnLoadIntoMap;
        private System.Windows.Forms.Button btnTeslimat;
    }
}