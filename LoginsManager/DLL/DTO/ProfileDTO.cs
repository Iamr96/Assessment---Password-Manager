using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DTO
{
    public class ProfileDTO
    {
        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
        public bool? IsActive { get; set; }
        public virtual ICollection<ProfilePrivilegeDTO>? ProfilePrivileges { get; set; }


    }
}
