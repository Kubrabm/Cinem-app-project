using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Models
{
    internal class Cinema : Entity
    {
        internal string? Name { get; set; }
        public override string ToString()
        {
            return $"Cinem Id: {Id}\n Cinem Nanme: {Name}\n";
        }
    }
}
