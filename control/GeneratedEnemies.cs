using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons
{
    public class GeneratedEnemies
    {
        public List<Enemy> Enemies { get; set; }
        public GeneratedEnemies() { 
            Enemies = new List<Enemy>();
            AddEnemy(EnemyGenerator("VLADIMIR",$"{Constant.IMAGES_PATH}puton.png"));
            AddEnemy(EnemyGenerator("DONALD", $"{Constant.IMAGES_PATH}trump.png"));
            AddEnemy(EnemyGenerator("ELON", $"{Constant.IMAGES_PATH}elon.png"));
        }
        private void AddEnemy(Enemy enemy)
        {
            Enemies.Add(enemy);
        }
        private Enemy EnemyGenerator(string name, string image) {
            return new Enemy(name, image, RandomGenerator(3,7), RandomGenerator(15, 26));
        }
        private int RandomGenerator(int min, int max) {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
    }
}
