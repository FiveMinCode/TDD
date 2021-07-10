using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDDByExample.Model;

namespace TDDByExample.Service
{
    public class UserService
    {
        public bool Add(User user)
        {
            // DB call to save the user
            return true;
        }
    }
}
