using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFilesCases
{
    class EasyTextReader : ReadFileHandler
    {
        public FileType FileType { get; set; }
        public EasyTextReader(string path) : base(path)
        {
            FileType = FileType.Txt;
        }

        public new string ReadFile()
        {
            return base.ReadFile();
        }
    }
}
