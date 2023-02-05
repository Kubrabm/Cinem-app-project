using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Models
{
    internal class Session : Entity
    {
        internal Hall Hall { get; set; }

        internal DateTime SeansTime { get; set; }

        internal Film Film { get; set; }

        internal int Price { get; set; }

        public override string ToString()
        {
            return $"Seans ID: {Id}\nSeans: {SeansTime}\n{Film}\n{Hall}\nPrice: {Price} AZN\n";
        }
    }
}
