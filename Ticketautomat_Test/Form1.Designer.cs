
namespace Ticketautomat_Test
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ticketSelect = new System.Windows.Forms.ComboBox();
            this.ticketTitle = new System.Windows.Forms.Label();
            this.ticketPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticketautomat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kaufen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ticketSelect
            // 
            this.ticketSelect.FormattingEnabled = true;
            this.ticketSelect.Location = new System.Drawing.Point(26, 63);
            this.ticketSelect.Name = "ticketSelect";
            this.ticketSelect.Size = new System.Drawing.Size(121, 21);
            this.ticketSelect.TabIndex = 2;
            this.ticketSelect.SelectedIndexChanged += new System.EventHandler(this.ticketSelect_SelectedIndexChanged);
            // 
            // ticketTitle
            // 
            this.ticketTitle.AutoSize = true;
            this.ticketTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketTitle.Location = new System.Drawing.Point(464, 71);
            this.ticketTitle.Name = "ticketTitle";
            this.ticketTitle.Size = new System.Drawing.Size(164, 20);
            this.ticketTitle.TabIndex = 3;
            this.ticketTitle.Text = "Kein Ticket gewählt";
            // 
            // ticketPrice
            // 
            this.ticketPrice.AutoSize = true;
            this.ticketPrice.Location = new System.Drawing.Point(464, 116);
            this.ticketPrice.Name = "ticketPrice";
            this.ticketPrice.Size = new System.Drawing.Size(10, 13);
            this.ticketPrice.TabIndex = 4;
            this.ticketPrice.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ticketPrice);
            this.Controls.Add(this.ticketTitle);
            this.Controls.Add(this.ticketSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Ticketautomat";
            this.Text = "Ticketautomat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ticketSelect;
        private System.Windows.Forms.Label ticketTitle;
        private System.Windows.Forms.Label ticketPrice;
    }
}

