using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketautomat
{
    public partial class Provision : Form
    {
        private ProvisionRechner provisionRechner = new ProvisionRechner();
        public Provision()
        {
            InitializeComponent();
        }

        private void numberInput_ValueChanged(object sender, EventArgs e) { 
            this.provisionOutput.Text = "Provision: " + 
                                                Math.Round(
                                                    provisionRechner.berechneProvision(
                                                        Decimal.ToDouble(this.numberInput.Value)), 2).ToString() 
                                        + "€";
        }
    }
}
