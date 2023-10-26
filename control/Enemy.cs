using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons
{
    public class Enemy
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int Strength { get; set; }
        public int Life { get; set;  }
        public Enemy(string Name, string Image, int Strength, int Life) {
            this.Name = Name;
            this.Image = Image;
            this.Strength = Strength;
            this.Life = Life;
        }
    }
}
