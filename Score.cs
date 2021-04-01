using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace SnakeBelov1._04
{
    class Score
    {
        private Parametrs settings = new Parametrs();
        private static string pathToRecordFile;
        private static string pathToResultsFile;
        private int currentPoints = 0;

        public Score(string _pathToResources)
        {
            pathToRecordFile = _pathToResources + "record.txt";
            pathToResultsFile = _pathToResources + "results.txt";
            Console.ForegroundColor = ConsoleColor.DarkGray;

            WriteText("|YOUR SCORE", 1, 26);

            ShowCurrentPoints();

            WriteText("|RESULTS:", 1, 29);

            WriteText(GetBestResult(), 1, 30);

            WriteText("==========", 1, 28);

            ShowLastFiveResults();
        }
        public string GetBestResult()
        {

            StreamReader streamReader = new StreamReader("results.txt", true);
            string record = streamReader.ReadToEnd();
            streamReader.Close();
            if (record == "")
            {
                record = "0";
            }

            return record;
        }

        public void WriteBestResult()

        {
            StreamWriter streamWriter = new StreamWriter("results.txt", true);
            Console.WriteLine("|    Your name");
            string Name = Console.ReadLine();
            streamWriter.WriteLine(Name + " " + "-" + " " + currentPoints);

            streamWriter.Close();

        }

        public void UpCurrentPoints()
        {
            currentPoints += 10;
        }
        public void UpPoinS()
        {
            currentPoints += 20;
        }
        public void DownPointB()
        {
            currentPoints -= 5;
        }
        public int ShowPoint()
        {
            return currentPoints;
        }
        public void ShowCurrentPoints()
        {

            if (currentPoints == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(1, 27);
            }
            else if (currentPoints < 50)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, 27);
            }
            else if (currentPoints < 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(1, 27);
            }
            else if (currentPoints < 150)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(1, 27);
            }
            else if (currentPoints > 150)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(1, 27);
            }

            Console.WriteLine(currentPoints.ToString());
        }
        public void ShowLastFiveResults()
        {
            List<int> res = new List<int>();
            string line;

            StreamReader streamReader = new StreamReader(pathToResultsFile);
            while ((line = streamReader.ReadLine()) != null)
            {
                res.Add(Convert.ToInt32(line));
            }

            streamReader.Close();

        }

        public void WriteGameOver()
        {

            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("=======mak$im=======", xOffset, yOffset++);
            WriteText("======GAMEOVER======", xOffset + 1, yOffset++);
            yOffset++;
            WriteText("========2021========", xOffset, yOffset++);
            WriteBestResult();
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
