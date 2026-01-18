using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Responder : User
    {
        private int roleId; // firefighter, medic, etc.. - id
        private string roleName;

        public int RoleId { get =>  roleId; set => roleId = value;}
        public string RoleName { get => roleName; set => roleName = value; }
    }
}
