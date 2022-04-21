using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
    public partial class ProfilePrivilege
    {
        public int ProfilePrivilegeId { get; set; }
        public int? ProfileId { get; set; }
        public int? PrivilegeId { get; set; }

        public virtual Privilege? Privilege { get; set; }
        public virtual Profile? Profile { get; set; }
    }
}
