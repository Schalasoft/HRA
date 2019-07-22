using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class RolePrivilegeMapping
    {
        #region Members
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string PrivilegeId { get; set; }
        #endregion
    }
}
