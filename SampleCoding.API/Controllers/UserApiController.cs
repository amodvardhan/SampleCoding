using SampleCoding.DAL.Models;
using SampleCoding.DAL.Repositories;
using System.Web.Http;

namespace SampleCoding.API.Controllers
{
    [Route("api/users")]
    public class UserApiController : ApiController
    {
        private readonly IUserRepository _userRepository;

        public UserApiController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET api/users
        public IHttpActionResult Get()
        {
            var userList = _userRepository.GetUserList();
            return Ok(userList);
        }

        // GET api/users/1
        public IHttpActionResult Get(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        // POST api/users/
        public IHttpActionResult Post([FromBody]User user)
        {          
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _userRepository.CreateUser(user);
            return Ok(result);
        }

    }
}
