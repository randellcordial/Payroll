using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Interface
{
    public interface IUserEntity
    {
        Guid UserID { get; set; }
        byte PositionType { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
    }
}
