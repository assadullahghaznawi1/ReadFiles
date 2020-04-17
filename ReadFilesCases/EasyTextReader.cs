using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFilesCases
{
    public class EasyTextReader : ReadFileHandler, EasyFileReader
    {
        public FileType FileType { get; set; }
        public bool IsRoleBased { get; set; }
        public Role UserRole { get; set; }

        public EasyTextReader(string path) : base(path)
        {
            FileType = FileType.Txt;
        }
        public EasyTextReader(string path, Boolean IsEncryptionActive) : base(path, IsEncryptionActive)
        {
            FileType = FileType.Txt;
        }
        public EasyTextReader(string path, Boolean isRoleBased, Role userRole) : this(path)
        {
            IsRoleBased = isRoleBased;
            UserRole = userRole;
        }

        public new string ReadFile()
        {
            if (IsRoleBased)
            {
                return base.ReadFileBySecurityrRole(UserRole);
            }
            return base.ReadFile();
        }
    }
}
