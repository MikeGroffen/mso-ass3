using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    class Printer
    {
        public bool PrinterStatus = true;

        public void print(UIInfo info)
        {
            sales sale = new sales();
            MessageBox.Show(sale.betalinginfo(info, sale.CalcTotal(info)));

            Ticket ticket = new Ticket();
            MessageBox.Show(ticket.GetTicketInfo(info));
        }
    }
}
