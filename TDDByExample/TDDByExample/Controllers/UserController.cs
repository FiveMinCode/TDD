using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDDByExample.Model;
using TDDByExample.Service;

namespace TDDByExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserService user { get; set; }
        public UserController(IUserService _user)
        {
            user = _user;
        }
        public bool Add(User userDetails)
        {
            // service call to save the user
            return user.Add(userDetails);
        }
    }
}
