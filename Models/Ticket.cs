using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Models
{
    internal class Ticket : Entity
    {
        internal Session Session { get; set; }

        internal int Row { get; set; }

        internal int Column { get; set; }

        public override string ToString()
        {
            return $"Session: {Session}\n Row: {Row}\n Column: {Column}";
        }
    }
}
