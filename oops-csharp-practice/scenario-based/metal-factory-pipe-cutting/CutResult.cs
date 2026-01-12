using System;
using System.Collections.Generic;
using System.Text;

namespace metal_factory_pipe_cutting
{
    internal class CutResult
    {
        public int Part1 { get; private set; }
        public int Part2 { get; private set; }
        public int Revenue { get; private set; }
        public CutResult(int part1, int part2, int revenue)
        {
            Part1 = part1;
            Part2 = part2;
            Revenue = revenue;
        }

        public void Display()
        {
            Console.WriteLine($"Best Cut: {Part1} + {Part2} → Revenue = {Revenue}");
        }

    }
}
