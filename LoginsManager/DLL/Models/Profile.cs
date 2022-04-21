using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
    public partial class Profile
    {
        public Profile()
        {
            ProfilePrivileges = new HashSet<ProfilePrivilege>();
            Users = new HashSet<User>();
        }

        public int ProfileId { get; set; }
        public string? ProfileName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<ProfilePrivilege>? ProfilePrivileges { get; set; }
        public virtual ICollection<User>? Users { get; set; }
    }
}
