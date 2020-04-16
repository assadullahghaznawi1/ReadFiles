using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFilesCases
{
    public enum FileType
    {
        Txt
    }
    public class ReadFileHandler
    {
        protected string Path { get; set; }
        public ReadFileHandler(string path)
        {
            Path = path;
        }
        protected string ReadFile()
        {
            try
            {
                StreamReader streamReader = new StreamReader(Path);
                string result = streamReader.ReadToEnd();
                streamReader.Close();

                return result;
            }
            catch (Exception e)
            {
                return ("Error " + e.Message);
            }
        }
    }
}
