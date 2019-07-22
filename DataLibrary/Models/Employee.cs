using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResourceLibrary.Resources.ResourceKeys;

namespace DataLibrary.Models
{
    public class Employee
    {
        #region Members
        public int Id { get; set; }

        [Display(Name = DisplayName.EmployeeID)]
        public int EmployeeId { get; set; }

        [Display(Name = DisplayName.FirstName)]
        public string FirstName { get; set; }

        [Display(Name = DisplayName.SecondName)]
        public string SecondName { get; set; }

        [Display(Name = DisplayName.EmailAddress)]
        public string EmailAddress { get; set; }

        [Display(Name = DisplayName.Salary)]
        public decimal Salary { get; set; }

        [Display(Name = DisplayName.VacationBalance)]
        public decimal VacationBalance { get; set; }

        [Display(Name = DisplayName.AnnualBonus)]
        public decimal AnnualBonus { get; set; }

        [Display(Name = DisplayName.Department)]
        public string Department { get; set; }
        #endregion
    }
}
