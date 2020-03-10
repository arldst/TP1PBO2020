namespace TP1_1805152_ArielJusuf
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.logoText = new System.Windows.Forms.Label();
            this.linkToMenuBeli = new System.Windows.Forms.LinkLabel();
            this.linkToKatalog = new System.Windows.Forms.LinkLabel();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.priceRangeBox = new System.Windows.Forms.ComboBox();
            this.priceRangeLabel = new System.Windows.Forms.Label();
            this.jenisBarangBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nimLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 480);
            this.label1.TabIndex = 0;
            // 
            // logoText
            // 
            this.logoText.AutoSize = true;
            this.logoText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.logoText.Location = new System.Drawing.Point(20, 21);
            this.logoText.Name = "logoText";
            this.logoText.Size = new System.Drawing.Size(140, 55);
            this.logoText.TabIndex = 1;
            this.logoText.Text = "Toko";
            // 
            // linkToMenuBeli
            // 
            this.linkToMenuBeli.AutoSize = true;
            this.linkToMenuBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToMenuBeli.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkToMenuBeli.LinkColor = System.Drawing.Color.Black;
            this.linkToMenuBeli.Location = new System.Drawing.Point(26, 120);
            this.linkToMenuBeli.Name = "linkToMenuBeli";
            this.linkToMenuBeli.Size = new System.Drawing.Size(79, 20);
            this.linkToMenuBeli.TabIndex = 2;
            this.linkToMenuBeli.TabStop = true;
            this.linkToMenuBeli.Text = "Menu Beli";
            this.linkToMenuBeli.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // linkToKatalog
            // 
            this.linkToKatalog.AutoSize = true;
            this.linkToKatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToKatalog.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkToKatalog.LinkColor = System.Drawing.Color.Black;
            this.linkToKatalog.Location = new System.Drawing.Point(26, 159);
            this.linkToKatalog.Name = "linkToKatalog";
            this.linkToKatalog.Size = new System.Drawing.Size(107, 20);
            this.linkToKatalog.TabIndex = 3;
            this.linkToKatalog.TabStop = true;
            this.linkToKatalog.Text = "Menu Katalog";
            this.linkToKatalog.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkToKatalog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToKatalog_LinkClicked);
            // 
            // logoutLink
            // 
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.logoutLink.LinkColor = System.Drawing.Color.DodgerBlue;
            this.logoutLink.Location = new System.Drawing.Point(26, 442);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(59, 20);
            this.logoutLink.TabIndex = 4;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Logout";
            this.logoutLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLink_LinkClicked);
            // 
            // priceRangeBox
            // 
            this.priceRangeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priceRangeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceRangeBox.FormattingEnabled = true;
            this.priceRangeBox.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt"});
            this.priceRangeBox.Location = new System.Drawing.Point(525, 21);
            this.priceRangeBox.Name = "priceRangeBox";
            this.priceRangeBox.Size = new System.Drawing.Size(120, 21);
            this.priceRangeBox.TabIndex = 5;
            // 
            // priceRangeLabel
            // 
            this.priceRangeLabel.AutoSize = true;
            this.priceRangeLabel.Location = new System.Drawing.Point(433, 24);
            this.priceRangeLabel.Name = "priceRangeLabel";
            this.priceRangeLabel.Size = new System.Drawing.Size(86, 13);
            this.priceRangeLabel.TabIndex = 6;
            this.priceRangeLabel.Text = "Rentang Harga :";
            // 
            // jenisBarangBox
            // 
            this.jenisBarangBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jenisBarangBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenisBarangBox.FormattingEnabled = true;
            this.jenisBarangBox.Items.AddRange(new object[] {
            "Baju",
            "Elektronik",
            "Makanan"});
            this.jenisBarangBox.Location = new System.Drawing.Point(731, 21);
            this.jenisBarangBox.Name = "jenisBarangBox";
            this.jenisBarangBox.Size = new System.Drawing.Size(120, 21);
            this.jenisBarangBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jenis Barang :";
            // 
            // nimLabel
            // 
            this.nimLabel.AutoSize = true;
            this.nimLabel.Location = new System.Drawing.Point(776, 479);
            this.nimLabel.Name = "nimLabel";
            this.nimLabel.Size = new System.Drawing.Size(156, 13);
            this.nimLabel.TabIndex = 9;
            this.nimLabel.Text = "1805152 - Ariel Jusuf Indrastata";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(857, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Cari";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.nimLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jenisBarangBox);
            this.Controls.Add(this.priceRangeLabel);
            this.Controls.Add(this.priceRangeBox);
            this.Controls.Add(this.logoutLink);
            this.Controls.Add(this.linkToKatalog);
            this.Controls.Add(this.linkToMenuBeli);
            this.Controls.Add(this.logoText);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Toko";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logoText;
        private System.Windows.Forms.LinkLabel linkToMenuBeli;
        private System.Windows.Forms.LinkLabel linkToKatalog;
        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.ComboBox priceRangeBox;
        private System.Windows.Forms.Label priceRangeLabel;
        private System.Windows.Forms.ComboBox jenisBarangBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nimLabel;
        private System.Windows.Forms.Button searchButton;
    }
}