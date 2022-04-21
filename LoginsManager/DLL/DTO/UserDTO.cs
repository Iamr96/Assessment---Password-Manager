using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Active { get; set; }

        public bool? ForceLogin { get; set; }
        public bool? EmailVeryFied { get; set; }
        public int? ProfileId { get; set; }
        public virtual ProfileDTO? Profile { get; set; }
    }
}
