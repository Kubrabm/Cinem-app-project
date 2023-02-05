using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Models
{
    internal class Hall : Entity
    {

        internal string Name { get; set; }

        internal Cinema Cinema { get; set; }

        internal int RowCount { get; set; }

        internal int ColumnCount { get; set; }

        public override string ToString()
        {
            return $"Hall ID: {Id}\n Hall Name: {Name}\n RowCount: {RowCount}\n ColumnCount: {ColumnCount}\n{Cinema}";
        }
    }
}
