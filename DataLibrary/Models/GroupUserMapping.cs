using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class GroupUserMapping
    {
        #region Members
        public int Id { get; set; }
        public string GroupId { get; set; }
        public string UserId { get; set; }
        #endregion
    }
}
