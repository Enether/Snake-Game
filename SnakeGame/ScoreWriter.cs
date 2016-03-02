using System;
using System.IO;

namespace SnakeGame
{
    class ScoreWriter
    {
        // ScoreReader sr = new ScoreReader(); 

        public static void WriteEasyScore(int score)
        {
            int mediumScore = ScoreReader.ReadScore()["mediumScore"];
            int hardScore = ScoreReader.ReadScore()["hardScore"];
            string path = Environment.CurrentDirectory + @"\Score.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write("{0} {1} {2}", score, mediumScore, hardScore);
            }
        }
        public static void WriteMediumScore(int score)
        {
            int easyScore = ScoreReader.ReadScore()["easyScore"];
            int hardScore = ScoreReader.ReadScore()["hardScore"];
            string path = Environment.CurrentDirectory + @"\Score.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write("{0} {1} {2}", easyScore, score, hardScore);
            }
        }
        public static void WriteHardScore(int score)
        {
            int easyScore = ScoreReader.ReadScore()["easyScore"];
            int mediumScore = ScoreReader.ReadScore()["mediumScore"];
            string path = Environment.CurrentDirectory + @"\Score.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write("{0} {1} {2}", easyScore, mediumScore, score);
            }
        }
    }
}
