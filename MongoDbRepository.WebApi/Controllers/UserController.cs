using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDbRepository.Business.Abstract;
using MongoDbRepository.Entities.Concrete;

namespace MongoDbRepository.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public async Task<List<User>> Get()
        {
            return await _userService.GetList();
        }

        [HttpGet("{id}")]
        public async Task<List<User>> Get(Guid id)
        {
            return await _userService.GetList(u => u.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userService.Add(user);
        }

        public void Put([FromBody] User user)
        {
            _userService.Update(user);
        }

        
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _userService.Delete(id);
        }
    }
}