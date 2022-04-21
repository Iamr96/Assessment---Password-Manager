using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
    public partial class Privilege
    {
        public Privilege()
        {
            ProfilePrivileges = new HashSet<ProfilePrivilege>();
        }

        public int PrivilegeId { get; set; }
        public string PrivilegeName { get; set; }
        public bool? IsActive { get; set; }
        public string PrivilegeFriendlyName { get; set; }

        public virtual ICollection<ProfilePrivilege>? ProfilePrivileges { get; set; }
    }
}
