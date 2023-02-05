using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Models
{
    internal class Film : Entity
    {
        public string? Name { get; set; }
        public string? OnScreen { get; set; }
        public string? Director { get; set; }
        public string? Duration { get; set; }
        public string? AgeRestriction { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"Film Name: {Name}\n Film on screen: {OnScreen}\n Film Director: {Director}\n Film Duration: {Duration}\n Film age restriction: {AgeRestriction}\n Film Description: {Description}\n";
        }
    }
}
