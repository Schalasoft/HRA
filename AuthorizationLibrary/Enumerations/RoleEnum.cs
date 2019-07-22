using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationLibrary.Enumerations
{
    // Defines the role of a user, for limiting the employees the user has access to
    public enum RoleEnum
    {
        Employee,
        Manager,
        HumanResourcesPersonnel,
        Administrator
    }
}
