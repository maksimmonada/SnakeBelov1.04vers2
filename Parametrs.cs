using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeBelov1._04
{
    class Parametrs
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
