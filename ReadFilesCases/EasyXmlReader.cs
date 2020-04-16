using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFilesCases
{
    class EasyXmlReader : ReadFileHandler
    {
        public FileType FileType { get; set; }
        public EasyXmlReader(string path) : base(path)
        {
            FileType = FileType.Xml;
        }

        public new string ReadFile()
        {
            return base.ReadFile();
        }
    }
}
