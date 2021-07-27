using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using webui.Identity;

namespace webui.Models
{
    public class RoleDetailModel
    {
        public string roleId { get; set; }

        public string roleName { get; set; }

        public IEnumerable<User> Members { get; set; }

        public IEnumerable<User>  NonMembers { get; set; }
    }
}