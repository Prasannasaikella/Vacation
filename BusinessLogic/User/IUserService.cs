using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vacation.BusinessLogic.User
{
    public interface IUserService
    {
        Task<User> Authenticate(string email, string password);
        Task<User> Add(string name, string email, string password);

        Task<User> AuthenticateExternal(string id);
        Task<User> AddExternal(string id, string name, string email);
    }
}
