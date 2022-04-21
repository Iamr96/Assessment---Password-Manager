using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DLL.Models
{
    public partial class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.Password, ErrorMessage = "The {0} must be at least {2} characters long.")]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Active { get; set; }
        public bool? ForceLogin { get; set; }
        public bool? EmailVeryFied { get; set; }
        public Guid UserGuid { get; set; }

        public int? ProfileId { get; set; }

        public virtual Profile? Profile { get; set; }
    }
}
