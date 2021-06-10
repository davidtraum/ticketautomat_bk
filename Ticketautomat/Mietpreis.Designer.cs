
namespace Ticketautomat
{
    partial class Mietpreis
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
            this.inputKm = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPriceKm = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputDays = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPriceDay = new System.Windows.Forms.NumericUpDown();
            this.output = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPriceKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPriceDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mietpreis Rechner";
            // 
            // inputKm
            // 
            this.inputKm.Location = new System.Drawing.Point(12, 72);
            this.inputKm.Name = "inputKm";
            this.inputKm.Size = new System.Drawing.Size(120, 23);
            this.inputKm.TabIndex = 1;
            this.inputKm.ValueChanged += new System.EventHandler(this.inputKm_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gefahrene Kilometer";
            // 
            // inputPriceKm
            // 
            this.inputPriceKm.Location = new System.Drawing.Point(12, 114);
            this.inputPriceKm.Name = "inputPriceKm";
            this.inputPriceKm.Size = new System.Drawing.Size(120, 23);
            this.inputPriceKm.TabIndex = 3;
            this.inputPriceKm.ValueChanged += new System.EventHandler(this.inputPriceKm_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preis pro Kilometer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gemietete Tage";
            // 
            // inputDays
            // 
            this.inputDays.Location = new System.Drawing.Point(190, 73);
            this.inputDays.Name = "inputDays";
            this.inputDays.Size = new System.Drawing.Size(120, 23);
            this.inputDays.TabIndex = 6;
            this.inputDays.ValueChanged += new System.EventHandler(this.inputDays_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Preis pro Tag";
            // 
            // inputPriceDay
            // 
            this.inputPriceDay.Location = new System.Drawing.Point(190, 114);
            this.inputPriceDay.Name = "inputPriceDay";
            this.inputPriceDay.Size = new System.Drawing.Size(120, 23);
            this.inputPriceDay.TabIndex = 8;
            this.inputPriceDay.ValueChanged += new System.EventHandler(this.inputPriceDay_ValueChanged);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(148, 150);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(38, 15);
            this.output.TabIndex = 9;
            this.output.Text = "Preis: ";
            // 
            // Mietpreis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 166);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputPriceDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputPriceKm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputKm);
            this.Controls.Add(this.label1);
            this.Name = "Mietpreis";
            this.Text = "Auto-Mietpreis";
            ((System.ComponentModel.ISupportInitialize)(this.inputKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPriceKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPriceDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputKm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputPriceKm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inputDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown inputPriceDay;
        private System.Windows.Forms.Label output;
    }
}