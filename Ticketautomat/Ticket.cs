using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketautomat_Test
{
    class Ticket
    {
        private string description;
        private double price;
        private int ticketNumber;
        private double paid = 0;

        public Ticket(int pTicketNumber, double pPrice, string pDescription)
        {
            this.ticketNumber = pTicketNumber;
            this.price = pPrice;
            this.description = pDescription;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string pDescription)
        {
            this.description = pDescription;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(float price)
        {
            this.price = price;
        }

        public int getTicketNumber()
        {
            return this.ticketNumber;
        }

        public bool pay(double amount)
        {
            this.paid += amount;
            return this.getPaid() >= this.getPrice();
        }

        public double getExchange()
        {
            return this.getPaid() >= this.getPrice() ? this.getPaid() - this.getPrice() : 0;
        }

        public double getPaid()
        {
            return this.paid;
        }
    }
}
