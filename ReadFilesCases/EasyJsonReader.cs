using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFilesCases
{
    class EasyJsonReader : ReadFileHandler, EasyFileReader
    {
        public FileType FileType { get; set; }
        public Boolean IsRoleBased { get; set; }
        public Role UserRole { get; set; }
        public EasyJsonReader(string path) : base(path)
        {
            FileType = FileType.Json;
        }
        public EasyJsonReader(string path, Boolean isRoleBased, Role userRole) : this(path)
        {
            IsRoleBased = isRoleBased;
            UserRole = userRole;
        }
        public EasyJsonReader(string path, Boolean IsEncryptionActive) : base(path, IsEncryptionActive)
        {
            FileType = FileType.Json;
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
