using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons
{
    public class GameStats
    {
        public DateTime StartTime { get; set; }
        public bool Win { get; set; }
        public int MaxDealt { get; set; }
        public int MinDealt { get; set; }
        public int MaxGot { get; set; }
        public int MinGot { get; set; } 
        public GameStats(DateTime StartTime) { 
            this.StartTime = StartTime;
            this.MaxDealt = int.MinValue;
            this.MinDealt = int.MaxValue;
            this.MaxGot = int.MinValue;
            this.MinGot = int.MaxValue;
        }
    }
}
