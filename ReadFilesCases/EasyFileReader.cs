using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFilesCases
{
    public interface EasyFileReader
    {
        FileType FileType { get; set; }
        Boolean IsRoleBased { get; set; }
        Role UserRole { get; set; }
        string ReadFile();
    }
}
