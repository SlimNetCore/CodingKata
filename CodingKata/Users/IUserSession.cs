using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata.Users
{
    public interface IUserSession
    {
        public User GetLoggedUser();
    }
}
