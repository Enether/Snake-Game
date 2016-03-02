using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SnakeGame
{
    class ScoreReader
    {
        public ScoreReader()
        {
            string path = Environment.CurrentDirectory + @"\Score.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("{0} {0} {0}", 0);
                }
            }
        }

        public static Dictionary<string, int> ReadScore()
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();
            string path = Environment.CurrentDirectory + @"\Score.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                string[] scoresArray = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                scores["easyScore"] = int.Parse(scoresArray[0]);
                scores["mediumScore"] = int.Parse(scoresArray[1]);
                scores["hardScore"] = int.Parse(scoresArray[2]);

            }

            return scores;
        }
    }
}
