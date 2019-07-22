using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("SalaryHistory")]
    public class SalaryHistory
    {
        #region Members
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        #endregion
    }
}
