using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticketautomat_Test;

namespace Ticketautomat
{
    public partial class Ticketautomat : Form
    {
        private Form2 paymentForm = new Form2();

        private Ticket[] tickets = {
            new Ticket(0, 10, "Kurzstrecke"),
            new Ticket(1, 20, "Innerorts"),
            new Ticket(2, 100, "Fernreise")
        };

        private Ticket selectedTicket;

        public Ticketautomat()
        {
            InitializeComponent();
            foreach (Ticket t in tickets)
            {
                ticketComboBox.Items.Add(t.getDescription());
            }
            setSelectedTicket(tickets[0].getDescription());
            this.ticketComboBox.SelectedItem = tickets[0].getDescription();
        }

        private void setSelectedTicket(String name)
        {
            foreach(Ticket t in tickets)
            {
                if(t.getDescription().Equals(name))
                {
                    this.selectedTicket = t;
                    this.updateTicketInfo();
                }
            }
        }

        private void updateTicketInfo()
        {
            this.priceLabel.Text = "Preis: " + this.selectedTicket.getPrice().ToString() + '€';
            if(this.selectedTicket.isPaid())
            {
                this.paidLabel.Text = "Wechselgeld: " + this.roundPrice(this.selectedTicket.getExchange()).ToString() + "€";
            } else
            {
                this.paidLabel.Text = "Bezahlt: " + this.roundPrice(this.selectedTicket.getPaid()).ToString() + "€";
            }
        }

        private void ticketComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.setSelectedTicket((String)this.ticketComboBox.SelectedItem);
        }

        private double roundPrice(double price)
        {
            return Math.Round(price, 2);
        } 

        private void payAmount(double amount)
        {
            if(this.selectedTicket.pay(amount))
            {
                MessageBox.Show("Ticket \"" + this.selectedTicket.getDescription() + "\" gekauft!");
            }
            this.updateTicketInfo();
        }

        private void pay10ct_Click(object sender, EventArgs e)
        {
            this.payAmount(0.1);
        }

        private void pay20ct_Click(object sender, EventArgs e)
        {
            this.payAmount(0.2);
        }

        private void pay50ct_Click(object sender, EventArgs e)
        {
            this.payAmount(0.5);
        }

        private void pay1euro_Click(object sender, EventArgs e)
        {
            this.payAmount(1);
        }

        private void pay2euro_Click(object sender, EventArgs e)
        {
            this.payAmount(2);
        }

        private void pay10euro_Click(object sender, EventArgs e)
        {
            this.payAmount(10);
        }

        private void pay20euro_Click(object sender, EventArgs e)
        {
            this.payAmount(20);
        }
    }
}
