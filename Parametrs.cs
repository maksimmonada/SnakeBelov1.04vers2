using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Snake
{
    public class Parametrs
    {
        private string ResorcesFolder;
        public Parametrs()
        {
            var ind = Directory.GetCurrentDirectory().ToString().IndexOf("bin", StringComparison.Ordinal);
            string binFolder = Directory.GetCurrentDirectory().ToString().Substring(0, ind).ToString();
            ResorcesFolder = binFolder + "resources\\";
        }
        public string GetResourceFolder()
        {
            return ResorcesFolder;
        }

    }
}
