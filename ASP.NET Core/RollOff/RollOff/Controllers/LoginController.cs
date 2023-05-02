using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollOff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        //[HttpGet]
        //public ActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Login([Bind(Include = "Email, Password")]
        //        LoginViewModel login)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            UserViewModel newUser = new UserViewModel();
        //            var service = new ServiceRepository();
        //            {
        //                using (var response = service.PostResponse("accounts/login", login))
        //                {
        //                    string apiResponse = await response.Content.ReadAsStringAsync();
        //                    newUser = JsonConvert.DeserializeObject<UserViewModel>(apiResponse);
        //                }
        //            }
        //            if (newUser != null)
        //            {
        //                FormsAuthentication.SetAuthCookie(login.Email, false);
        //                return RedirectToAction("Index", "User");
        //            }
        //            else
        //            {
        //                ViewBag.ErrorMessage = "The Email or Password provided is incorrect";
        //            }
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    return View();

        //}

        //public ActionResult LogOff()
        //{

        //    //Session.Remove("UserID");

        //    FormsAuthentication.SignOut();
        //    return RedirectToAction("Login");

        //}
    }
}
