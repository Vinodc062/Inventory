using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProTracker_TO
{
   public class RoleMaster
    {
        public int rm_RoleId { get; set; }
        [Required]
        public String rm_RoleName { get; set; }
        public Boolean rm_Status { get; set; }
        public int rm_User { get; set; }
    }
}
