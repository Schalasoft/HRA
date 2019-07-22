using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class ReportsToMapping
    {
        #region Members
        public int Id { get; set; }
        public int superordinateId { get; set; }
        public int subordinateId { get; set; }
        #endregion
    }
}
