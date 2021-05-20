
namespace Ticketautomat
{
    partial class Provision
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
            this.numberInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.provisionOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(76, 75);
            this.numberInput.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(120, 23);
            this.numberInput.TabIndex = 0;
            this.numberInput.ValueChanged += new System.EventHandler(this.numberInput_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Betrag: (€)";
            // 
            // provisionOutput
            // 
            this.provisionOutput.AutoSize = true;
            this.provisionOutput.Location = new System.Drawing.Point(13, 101);
            this.provisionOutput.Name = "provisionOutput";
            this.provisionOutput.Size = new System.Drawing.Size(74, 15);
            this.provisionOutput.TabIndex = 2;
            this.provisionOutput.Text = "Provision: 0€";
            // 
            // Provision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 187);
            this.Controls.Add(this.provisionOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberInput);
            this.Name = "Provision";
            this.Text = "Provisions-Rechner";
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label provisionOutput;
    }
}