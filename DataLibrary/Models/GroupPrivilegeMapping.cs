using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class GroupPrivilegeMapping
    {
        #region Members
        public int Id { get; set; }
        public string GroupId { get; set; }
        public string Privileges { get; set; } // Comma separated list of privileges
        #endregion
    }
}
