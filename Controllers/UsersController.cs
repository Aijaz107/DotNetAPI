using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDBContext dBContext;

        public UsersController(ApplicationDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var allUsers = dBContext.Users.ToList();
            return Ok(allUsers);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetUserById(Guid id) {
            var user = dBContext.Users.Find(id);

            if (user is null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser(AddUserDto addUserDto)
        {
            var userEntity = new User()
            {
                Email = addUserDto.Email,
                FirstName = addUserDto.FirstName,
                LastName = addUserDto.LastName,
                Password = addUserDto.Password,
                PhotoFileName = addUserDto.PhotoFileName,
            };

            dBContext.Users.Add(userEntity);
            dBContext.SaveChanges();

            return Ok(userEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateUser(Guid id, UpdateUserDto updateUserDto)
        {
            var user = dBContext.Users.Find(id);

            if (user is null)
            {
                return NotFound();
            }

            user.FirstName = updateUserDto.FirstName;
            user.LastName = updateUserDto.LastName;
            user.Password = updateUserDto.Password;
            user.Email = updateUserDto.Email;
            user.PhotoFileName = updateUserDto.PhotoFileName;

            dBContext.SaveChanges();

            return Ok(user);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteUser(Guid id)
        {
            var user = dBContext.Users.Find(id);
            if (user is null)
            {
                return NotFound();
            }
            dBContext.Users.Remove(user);
            dBContext.SaveChanges();

            return Ok();

        }
    }
}
