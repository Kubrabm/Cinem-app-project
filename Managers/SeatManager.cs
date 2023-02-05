using Cinem_app_project.Models;
using Cinem_app_project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem_app_project.Managers
{
    internal class SeatsManager : IPrintService
    {
        private Seat[,] _seats = new Seat[10, 12];
        private int _currentIndexRow = 0;
        private int _currentIndexColumn = 0;
        public void Print()
        {
            int[,] Seat = new int[10, 12];
            Console.WriteLine($"      1      2      3      4      5      6      7      8      9      10     11     12   ");
            Console.WriteLine($"   |------|------|------|------|------|------|------|------|------|------|------|------|");
            for (int row = 0; row < Seat.GetLength(0); row++)
            {
                Console.Write($"{row + 1,-3}|");
                for (int column = 0; column < Seat.GetLength(1); column++)
                {
                    Console.Write("Empty |");
                }
                Console.WriteLine();
                Console.WriteLine($"   |------|------|------|------|------|------|------|------|------|------|------|------|");

            }
        }

    }
}
