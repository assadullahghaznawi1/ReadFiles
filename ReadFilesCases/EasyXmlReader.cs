using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFilesCases
{
    class EasyXmlReader : ReadFileHandler , EasyFileReader
    {
        public FileType FileType { get; set; }
        public Boolean IsRoleBased { get; set; }
        public Role UserRole { get; set; }

        public EasyXmlReader(string path) : base(path)
        {
            FileType = FileType.Xml;
        }
        public EasyXmlReader(string path, Boolean isRoleBased, Role userRole) : this(path)
        {
            IsRoleBased = isRoleBased;
            UserRole = userRole;
        }

        public EasyXmlReader(string path, Boolean IsEncryptionActive) : base(path, IsEncryptionActive)
        {

        }

        public new string ReadFile()
        {
            if (IsRoleBased)
            {
                return ReadFileBySecurityrRole(UserRole);
            }
            else
            {
                return base.ReadFile();
            }
        }
    }
}
