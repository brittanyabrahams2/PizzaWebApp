using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace pizza_API_.Controllers
{
    //internal class to store user registation info
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }   
    
    //internal class for user login 
    public class LoginModel
    {
        
        public string Email { get; set; }
        public string Password { get; set; }
    }




    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]

    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public CustomerController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;

            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }




        [HttpPost]
        [Route("register")]
        //post : api/customer/register
        public async Task<object> Post(UserModel model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
            };
            try
            {
                var result = await _userManager.CreateAsync(user, model.Password);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        // user login method
        [HttpPost]
        [Route("login")]
        //post:api/customer/login

        public async Task<IActionResult> Login(LoginModel model)
        {

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user!=null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                return Ok(user);
            }
            else
            {
                return BadRequest(new { message ="email or password is incoorect !" });
            }
        }

    }


}