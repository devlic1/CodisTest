using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.DAL
{
    public interface IDataLogic
    {
        List<User> GetAllUsers();

        User GetUserInfo(Guid primaryKey);

        bool SaveUsers(List<User> users);

        bool RemoveUser(Guid primaryKey);
    }
}
