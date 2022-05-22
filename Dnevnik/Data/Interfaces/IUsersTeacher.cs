using System;
using System.Collections;
using System.Collections.Generic;
using Dnevnik.Data.Models;
namespace Dnevnik.Data.Interfaces
{
    public interface IUsersTeacher
    {
        IEnumerable<Teachers> AllTeachers { get; }
    }

}
