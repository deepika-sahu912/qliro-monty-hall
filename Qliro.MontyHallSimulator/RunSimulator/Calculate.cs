using System;
using System.Collections.Generic;
using System.Text;

namespace RunSimulator
{
    public class Calculate
    {
        public int WinCount { get; set; }
        public int LossCount { get; set; }
        public double PercentWins { get; set; }
        public int TotalGames { get; set; }

        public void ComputePercentage()
        {
            TotalGames = WinCount + LossCount;
            PercentWins = ((double)WinCount / TotalGames) * 100.0;
            WinCount = 0;
            LossCount = 0;
        }
    }
}


