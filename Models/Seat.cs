using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Models
{
    internal class Seat : Entity
    {
        internal int Row { get; set; }
        internal int Column { get; set; }
        public override string ToString()
        {
            return $" Row: {Row}\n Column: {Column}\n";
        }
    }

}
