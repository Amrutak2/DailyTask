using DotNetCoreWebApiFrontEnd.Models;
using DotNetCoreWebApiFrontEnd.Repository;
using DotNetCoreWebApiFrontEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreWebApiFrontEnd.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserDetailsController : Controller
    {
        private UserDetailsService _userDetailsService;
        public UserDetailsController(UserDetailsService userDetailsService)
        {
            _userDetailsService = userDetailsService;
        }
        [HttpGet("GetAllUserDetails")]
        public List<UserDetails> GetAllUserDetails()
        {
            return _userDetailsService.GetAllUserDetails();
        }
        //[HttpGet]
        //public List<string> Arr()
        //{
        //    List<string> arr = new List<string>();
        //    arr.Add("Amruta");

        //    return arr;
        //}
        [HttpPost]
        public IActionResult AddUser(UserDetails users)
        {
            var usr = _userDetailsService.AddUsers(users);
            return Ok(usr);
        }
        [HttpPut]
        public IActionResult UpdateUser(double id, UserDetails users)
        {
            var usr = _userDetailsService.UpdateUsers(id, users);
            if(usr == null)
            {
                return NoContent();
            }
            return Ok(usr);
        }
        [HttpDelete]
        public IActionResult DeleteUsers(double id, UserDetails users)
        {
            var usr = _userDetailsService.DeleteUsers(id, users);
            if (usr == null)
            {
                return NoContent();
            }
            return Ok(usr);
        }
    }
}
