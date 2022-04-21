using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DTO
{
    public class ProfilePrivilegeDTO
    {
        public virtual PrivilegeDTO? Privilege { get; set; }
        public virtual ProfileDTO? Profile { get; set; }
    }
}
