using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketautomat_Test
{
    public partial class Form1 : Form
    {
        private Ticket[] tickets =
        {
            new Ticket(0, 10, "Billiges Ticket"),
            new Ticket(1, 20, "Mittleres Ticket"),
            new Ticket(2, 50, "Super Ticket")
        };

        public Form1()
        {
            InitializeComponent();
            foreach(Ticket ticket in tickets)
            {
                ticketSelect.Items.Add(ticket.getDescription());
            }
        }

        private void onSelectTicket(Ticket pTicket)
        {
            ticketTitle.Text = "Beschreibung: " + pTicket.getDescription();
            ticketPrice.Text = "Preis: " + pTicket.getPrice() + "€";
        }

        private void ticketSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.onSelectTicket(this.tickets[this.ticketSelect.SelectedIndex]);
        }
    }
}
