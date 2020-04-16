using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFilesCases
{
    class EasyJsonReader : ReadFileHandler
    {
        public FileType FileType { get; set; }

        public EasyJsonReader(string path) : base(path)
        {
            FileType = FileType.Json;
        }
        public EasyJsonReader(string path, Boolean IsEncryptionActive) : base(path, IsEncryptionActive)
        {
            FileType = FileType.Json;
        }
        public new string ReadFile()
        {
            return base.ReadFile();
        }
    }
}
