using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ResourceLibrary.Resources.ResourceKeys;
using DataLibrary.Enumerations;

namespace HRA.Models
{
    public class EmployeeViewModel
    {
        #region Public Members
        [Display(Name = DisplayName.EmployeeID)]
        [Range(100000, 999999, ErrorMessage = DisplayName.EmployeeID + ErrorMessage.FieldEmployeeIDLength)]
        public int EmployeeId { get; set; }

        [Display(Name = DisplayName.FirstName)]
        [Required(ErrorMessage = DisplayName.FirstName + ErrorMessage.CannotBeEmpty)]
        public string FirstName { get; set; }

        [Display(Name = DisplayName.SecondName)]
        [Required(ErrorMessage = DisplayName.SecondName + ErrorMessage.CannotBeEmpty)]
        public string SecondName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = DisplayName.EmailAddress)]
        [Required(ErrorMessage = DisplayName.EmailAddress + ErrorMessage.CannotBeEmpty)]
        public string EmailAddress { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = DisplayName.ConfirmEmailAddress)]
        [Compare("EmailAddress", ErrorMessage = DisplayName.EmailAddress + ErrorMessage.And + DisplayName.ConfirmEmailAddress + ErrorMessage.FieldMustMatch)]
        public string ConfirmEmailAddress { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = DisplayName.Password)]
        [Required(ErrorMessage = DisplayName.Password + ErrorMessage.CannotBeEmpty)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = DisplayName.Password + ErrorMessage.FieldPasswordLength)] // CDG Would like the 8 not to be repeated here, also needs to match rule in sign up form for password length
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = DisplayName.ConfirmPassword)]
        [Required(ErrorMessage = DisplayName.ConfirmPassword + ErrorMessage.CannotBeEmpty)]
        [Compare("Password", ErrorMessage = DisplayName.Password + ErrorMessage.And + DisplayName.ConfirmPassword + ErrorMessage.FieldMustMatch)]
        public string ConfirmPassword { get; set; }

        [Display(Name = DisplayName.Salary)]
        [Required(ErrorMessage = DisplayName.Salary + ErrorMessage.CannotBeEmpty)]
        public decimal Salary { get; set; }

        [Display(Name = DisplayName.VacationBalance)]
        [Required(ErrorMessage = DisplayName.VacationBalance + ErrorMessage.CannotBeEmpty)]
        public decimal VacationBalance { get; set; }

        [Display(Name = DisplayName.AnnualBonus)]
        [Required(ErrorMessage = DisplayName.AnnualBonus + ErrorMessage.CannotBeEmpty)]
        public decimal AnnualBonus { get; set; }

        [Display(Name = DisplayName.Department)]
        [Required(ErrorMessage = DisplayName.Department + ErrorMessage.CannotBeEmpty)]
        public DepartmentEnum Department { get; set; }

        [Display(Name = DisplayName.Role)]
        [Required(ErrorMessage = DisplayName.Role + ErrorMessage.CannotBeEmpty)]
        public string Role { get; set; }
        #endregion
    }
}