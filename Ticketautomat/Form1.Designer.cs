
namespace Ticketautomat
{
    partial class Ticketautomat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticketautomat));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paidLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.ticketComboBox = new System.Windows.Forms.ComboBox();
            this.pay10ct = new System.Windows.Forms.Button();
            this.pay20ct = new System.Windows.Forms.Button();
            this.pay50ct = new System.Windows.Forms.Button();
            this.pay1euro = new System.Windows.Forms.Button();
            this.pay2euro = new System.Windows.Forms.Button();
            this.pay10euro = new System.Windows.Forms.Button();
            this.pay20euro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paidLabel);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.ticketComboBox);
            this.groupBox1.Location = new System.Drawing.Point(29, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket auswählen";
            // 
            // paidLabel
            // 
            this.paidLabel.AutoSize = true;
            this.paidLabel.Location = new System.Drawing.Point(7, 71);
            this.paidLabel.Name = "paidLabel";
            this.paidLabel.Size = new System.Drawing.Size(57, 15);
            this.paidLabel.TabIndex = 2;
            this.paidLabel.Text = "Bezahlt: 0";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(7, 52);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(12, 15);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "-";
            // 
            // ticketComboBox
            // 
            this.ticketComboBox.FormattingEnabled = true;
            this.ticketComboBox.Location = new System.Drawing.Point(6, 22);
            this.ticketComboBox.Name = "ticketComboBox";
            this.ticketComboBox.Size = new System.Drawing.Size(121, 23);
            this.ticketComboBox.TabIndex = 0;
            this.ticketComboBox.SelectedIndexChanged += new System.EventHandler(this.ticketComboBox_SelectedIndexChanged);
            // 
            // pay10ct
            // 
            this.pay10ct.BackColor = System.Drawing.Color.Transparent;
            this.pay10ct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pay10ct.BackgroundImage")));
            this.pay10ct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pay10ct.Location = new System.Drawing.Point(276, 359);
            this.pay10ct.Name = "pay10ct";
            this.pay10ct.Size = new System.Drawing.Size(60, 60);
            this.pay10ct.TabIndex = 2;
            this.pay10ct.UseVisualStyleBackColor = false;
            this.pay10ct.Click += new System.EventHandler(this.pay10ct_Click);
            // 
            // pay20ct
            // 
            this.pay20ct.BackColor = System.Drawing.Color.Transparent;
            this.pay20ct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pay20ct.BackgroundImage")));
            this.pay20ct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pay20ct.Location = new System.Drawing.Point(342, 359);
            this.pay20ct.Name = "pay20ct";
            this.pay20ct.Size = new System.Drawing.Size(60, 60);
            this.pay20ct.TabIndex = 3;
            this.pay20ct.UseVisualStyleBackColor = false;
            this.pay20ct.Click += new System.EventHandler(this.pay20ct_Click);
            // 
            // pay50ct
            // 
            this.pay50ct.BackColor = System.Drawing.Color.Transparent;
            this.pay50ct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pay50ct.BackgroundImage")));
            this.pay50ct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pay50ct.Location = new System.Drawing.Point(408, 359);
            this.pay50ct.Name = "pay50ct";
            this.pay50ct.Size = new System.Drawing.Size(60, 60);
            this.pay50ct.TabIndex = 4;
            this.pay50ct.UseVisualStyleBackColor = false;
            this.pay50ct.Click += new System.EventHandler(this.pay50ct_Click);
            // 
            // pay1euro
            // 
            this.pay1euro.BackColor = System.Drawing.Color.Transparent;
            this.pay1euro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pay1euro.BackgroundImage")));
            this.pay1euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pay1euro.Location = new System.Drawing.Point(474, 359);
            this.pay1euro.Name = "pay1euro";
            this.pay1euro.Size = new System.Drawing.Size(60, 60);
            this.pay1euro.TabIndex = 5;
            this.pay1euro.UseVisualStyleBackColor = false;
            this.pay1euro.Click += new System.EventHandler(this.pay1euro_Click);
            // 
            // pay2euro
            // 
            this.pay2euro.BackColor = System.Drawing.Color.Transparent;
            this.pay2euro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pay2euro.BackgroundImage")));
            this.pay2euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pay2euro.Location = new System.Drawing.Point(540, 359);
            this.pay2euro.Name = "pay2euro";
            this.pay2euro.Size = new System.Drawing.Size(60, 60);
            this.pay2euro.TabIndex = 6;
            this.pay2euro.UseVisualStyleBackColor = false;
            this.pay2euro.Click += new System.EventHandler(this.pay2euro_Click);
            // 
            // pay10euro
            // 
            this.pay10euro.BackColor = System.Drawing.Color.Transparent;
            this.pay10euro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pay10euro.BackgroundImage")));
            this.pay10euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pay10euro.Location = new System.Drawing.Point(606, 293);
            this.pay10euro.Name = "pay10euro";
            this.pay10euro.Size = new System.Drawing.Size(117, 60);
            this.pay10euro.TabIndex = 7;
            this.pay10euro.UseVisualStyleBackColor = false;
            this.pay10euro.Click += new System.EventHandler(this.pay10euro_Click);
            // 
            // pay20euro
            // 
            this.pay20euro.BackColor = System.Drawing.Color.Transparent;
            this.pay20euro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pay20euro.BackgroundImage")));
            this.pay20euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pay20euro.Location = new System.Drawing.Point(606, 359);
            this.pay20euro.Name = "pay20euro";
            this.pay20euro.Size = new System.Drawing.Size(117, 60);
            this.pay20euro.TabIndex = 8;
            this.pay20euro.UseVisualStyleBackColor = false;
            this.pay20euro.Click += new System.EventHandler(this.pay20euro_Click);
            // 
            // Ticketautomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pay20euro);
            this.Controls.Add(this.pay10euro);
            this.Controls.Add(this.pay2euro);
            this.Controls.Add(this.pay1euro);
            this.Controls.Add(this.pay50ct);
            this.Controls.Add(this.pay20ct);
            this.Controls.Add(this.pay10ct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Ticketautomat";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ticketComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label paidLabel;
        private System.Windows.Forms.Button pay10ct;
        private System.Windows.Forms.Button pay20ct;
        private System.Windows.Forms.Button pay50ct;
        private System.Windows.Forms.Button pay1euro;
        private System.Windows.Forms.Button pay2euro;
        private System.Windows.Forms.Button pay10euro;
        private System.Windows.Forms.Button pay20euro;
    }
}

