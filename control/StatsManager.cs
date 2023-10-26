using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons
{
    public class StatsManager
    {
        public static string LoadedFile = File.ReadAllText(Constant.FILE_PATH);

        public static string GetStat(string stat) {
            string[]lines = LoadedFile.Split("\n");
            foreach (string line in lines)
            {
                if (line.Contains(stat)) {
                    return line.Split(":")[1];
                }
            }
            return "ERROR";
        }
    }
}
