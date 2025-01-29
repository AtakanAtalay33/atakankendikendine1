namespace atakankendikendine1
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
            groupBox1 = new GroupBox();
            dgvlicensePlate = new DataGridView();
            btnPlakaSil = new Button();
            btnPlakaGuncelle = new Button();
            btnPlakaEkle = new Button();
            SecilenPlakaAd = new Label();
            label = new Label();
            txtLicensePlate = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlicensePlate).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvlicensePlate);
            groupBox1.Controls.Add(btnPlakaSil);
            groupBox1.Controls.Add(btnPlakaGuncelle);
            groupBox1.Controls.Add(btnPlakaEkle);
            groupBox1.Controls.Add(SecilenPlakaAd);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(txtLicensePlate);
            groupBox1.Location = new Point(379, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 470);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dgvlicensePlate
            // 
            dgvlicensePlate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlicensePlate.Location = new Point(6, 156);
            dgvlicensePlate.Name = "dgvlicensePlate";
            dgvlicensePlate.RowHeadersWidth = 51;
            dgvlicensePlate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlicensePlate.Size = new Size(300, 188);
            dgvlicensePlate.TabIndex = 3;
            dgvlicensePlate.CellClick += dgvlicensePlate_CellClick;
            // 
            // btnPlakaSil
            // 
            btnPlakaSil.Location = new Point(221, 396);
            btnPlakaSil.Name = "btnPlakaSil";
            btnPlakaSil.Size = new Size(94, 29);
            btnPlakaSil.TabIndex = 2;
            btnPlakaSil.Text = "Sil";
            btnPlakaSil.UseVisualStyleBackColor = true;
            btnPlakaSil.Click += btnPlakaSil_Click;
            // 
            // btnPlakaGuncelle
            // 
            btnPlakaGuncelle.Location = new Point(125, 396);
            btnPlakaGuncelle.Name = "btnPlakaGuncelle";
            btnPlakaGuncelle.Size = new Size(94, 29);
            btnPlakaGuncelle.TabIndex = 2;
            btnPlakaGuncelle.Text = "Guncelle";
            btnPlakaGuncelle.UseVisualStyleBackColor = true;
            btnPlakaGuncelle.Click += btnGuncelle_Click;
            // 
            // btnPlakaEkle
            // 
            btnPlakaEkle.Location = new Point(25, 396);
            btnPlakaEkle.Name = "btnPlakaEkle";
            btnPlakaEkle.Size = new Size(94, 29);
            btnPlakaEkle.TabIndex = 2;
            btnPlakaEkle.Text = "Ekle";
            btnPlakaEkle.UseVisualStyleBackColor = true;
            btnPlakaEkle.Click += btnPlakaEkle_Click;
            // 
            // SecilenPlakaAd
            // 
            SecilenPlakaAd.AutoSize = true;
            SecilenPlakaAd.Location = new Point(69, 113);
            SecilenPlakaAd.Name = "SecilenPlakaAd";
            SecilenPlakaAd.Size = new Size(50, 20);
            SecilenPlakaAd.TabIndex = 1;
            SecilenPlakaAd.Text = "label1";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(69, 62);
            label.Name = "label";
            label.Size = new Size(67, 20);
            label.TabIndex = 1;
            label.Text = "Plaka Ad";
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.Location = new Point(160, 55);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(144, 27);
            txtLicensePlate.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 631);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlicensePlate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvlicensePlate;
        private Button btnPlakaEkle;
        private Label SecilenPlakaAd;
        private Label label;
        private TextBox txtLicensePlate;
        private Button btnPlakaSil;
        private Button btnPlakaGuncelle;
    }
}
