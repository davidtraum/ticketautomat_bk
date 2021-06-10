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
    public partial class Mietpreis : Form
    {
        private MietpreisRechner rechner = new MietpreisRechner();
        public Mietpreis()
        {
            InitializeComponent();
        }

        private void berechne()
        {
            this.output.Text = "Preis: " + rechner.berechnePreis() + "€";
        }

        private void inputKm_ValueChanged(object sender, EventArgs e)
        {
            this.rechner.setzeKm((double)this.inputKm.Value);
            this.berechne();
        }

        private void inputPriceKm_ValueChanged(object sender, EventArgs e)
        {
            this.rechner.setzePreisProKm((double)this.inputPriceKm.Value);
            this.berechne();
        }

        private void inputDays_ValueChanged(object sender, EventArgs e)
        {
            this.rechner.setzeTage((double)this.inputDays.Value);
            this.berechne();
        }

        private void inputPriceDay_ValueChanged(object sender, EventArgs e)
        {
            this.rechner.setzePreisProTag((double)this.inputPriceDay.Value);
            this.berechne();
        }
    }
}
