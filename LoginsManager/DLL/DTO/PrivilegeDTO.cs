using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DTO
{
    public class PrivilegeDTO
    {
        public int PrivilegeId { get; set; }
        public string? PrivilegeName { get; set; }
        public bool? IsActive { get; set; }
        public string? ProfileName { get; set; }
        public string? PrivilegeFriendlyName { get; set; }

    }
}
