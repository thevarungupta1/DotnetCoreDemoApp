using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotnetCoreDemoApp.Models;

namespace DotnetCoreDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UsersController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _repository.GetUsers();

        }

        [HttpPost]
        public User Post([FromBody]User user)
        {
            _repository.AddUser(user);
            return user;
        }
    }
}