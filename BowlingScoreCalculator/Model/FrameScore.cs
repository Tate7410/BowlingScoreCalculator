using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreCalculator.Model
{
    public class FrameScore
    {
        public string? Score { get; set; }
        public bool FrameComplete { get; set; }
        public bool FirstRollCompleted { get; set; }
        public bool SecondRollCompleted { get; set; }
        public bool ThirdRollCompleted { get; set; }
        public bool UseThirdRoll { get; set; }
        public int RollOne { get; set; }
        public int RollTwo { get; set; }
        public int RollThree { get; set; }
        public int FrameTotal { get; set; }

    }
}
