using Cinem_app_project.Models;
using Cinem_app_project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Managers
{
    internal class TicketManager : IPrintService
    {
        public Ticket[] _ticket = new Ticket[10];
        private int _currentIndex = 0;

        public void CreateTicket(Session seans, int row, int column)
        {
            _ticket[_currentIndex] = new Ticket
            {
                Session = seans,
                Row = row,
                Column = column
            };

            _currentIndex++;
        }

        public void Print()
        {
            foreach (var item in _ticket)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }
    }
}
