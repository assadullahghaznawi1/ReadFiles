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
        Txt,
        Xml
    }
    public class ReadFileHandler
    {
        protected string Path { get; set; }
        public Boolean IsEncryptionActive { get; set; }
        public ReadFileHandler(string path)
        {
            Path = path;
        }
        public ReadFileHandler(string path, Boolean isEncryptionActive)
        {
            Path = path;
            IsEncryptionActive = isEncryptionActive;
        }
        protected string ReadFile()
        {
            try
            {
                StreamReader streamReader = new StreamReader(Path);
                string result = streamReader.ReadToEnd();
                streamReader.Close();

                if (IsEncryptionActive)
                {
                    char[] resultChar = result.ToCharArray();
                    Array.Reverse(resultChar);
                    result = new String(resultChar);
                }

                return result;
            }
            catch (Exception e)
            {
                return ("Error " + e.Message);
            }
        }
    }
}
