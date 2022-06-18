using AutoMapper;
using BudgetManager.Data.Interfaces;
using BudgetManager.Models;
using BudgetManager.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        private readonly IUserData _userData;
        private readonly IMapper _mapper;

        public UsersController(IUserData userData, IMapper mapper)
        {
            _userData = userData;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userData.GetUsers());
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(Guid id)
        {
            return Ok(_userData.GetUser(id));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, UpdateUserViewModel userViewModel)
        {
            if (_userData.GetUser(id) == null)
                return NotFound($"User with id: {id} was not found");

            User user = _mapper.Map<UpdateUserViewModel, User>(userViewModel);
            user.Id = id;           
            return Ok(_userData.UpdateUser(user));
        }

        [HttpPost]
        public IActionResult AddUser(CreateUserViewModel userViewModel)
        {
            User user = _mapper.Map<CreateUserViewModel, User>(userViewModel);
            user.Id = new Guid();
            _userData.AddUser(user);
            return Created(HttpContext.Request.Scheme
                + "://"
                + HttpContext.Request.Host
                + HttpContext.Request.Path
                + "/" 
                + user.Id, user);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            User user = _userData.DeleteUser(id);
            if (user == null)
                return NotFound($"User with id: {id} was not found");

            return Ok(user);
        }
    } 
}
