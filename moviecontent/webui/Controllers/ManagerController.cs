using System.Threading.Tasks;
using data.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using webui.Identity;
using webui.Models;
using webui.EmailService;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace webui.Controllers
{

    
    public class ManagerController:BaseController
    {
        private UserManager<User> userManager;

        private SignInManager<User> signInManager;

        private IEmailSender mailsender;

        private RoleManager<IdentityRole> roleManager; 

        public ManagerController(ICategoryRepository categoryRep,SignInManager<User> signInManager,UserManager<User> userManager,IEmailSender mailsender,RoleManager<IdentityRole> roleManager):base(categoryRep){

            this.userManager = userManager;
            this.signInManager = signInManager;
            this.mailsender = mailsender;
            this.roleManager = roleManager;



        }

        public IActionResult Register(){



            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model){


            if(!ModelState.IsValid){
                return View(model);
            }

            var user = new User(){
                FirstName = model.firstName,
                LastName = model.lastName,
                UserName = model.userName,
                Email = model.email
            };


            var result = await userManager.CreateAsync(user,model.password);

            if(result.Succeeded){

                var code = await userManager.GenerateEmailConfirmationTokenAsync(user);

                var url = Url.Action("ConfirmEmail","Manager",new{
                    userId = user.Id,
                    token = code
                });


                await mailsender.sendEmailAsync(user.Email,"Hesabınızı Onaylayınız",$"<a href='http://localhost:5000{url}'>Linke</a> tıklayarak Email adresinizi onaylayın");
                

                TempData["EmailRemainder"] = "Giriş yapmadan önce mailinize gelen linke giriniz.";
                return RedirectToAction("Login","Manager");
            }

            foreach (var errors in result.Errors)
            {
                ModelState.AddModelError("",errors.Description);
            }


            return View(model);
        }

          public IActionResult Login(){



            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
          public  async Task<IActionResult> Login(LoginModel model){


              if(!ModelState.IsValid){
                  return View(model);
              }

              var user = await userManager.FindByEmailAsync(model.email);

              if(user == null){
                  ModelState.AddModelError("","Bu email adresine sahip bir kullanıcı bulunamadı!");
                  return View(model);
              }

            if(!await userManager.IsEmailConfirmedAsync(user)){

                  ModelState.AddModelError("","Önce emailinize gelen dogrulama adresine gidiniz.!");

                  return View(model);

              }

              

              var result = await signInManager.PasswordSignInAsync(user,model.password,false,true);

              if(result.Succeeded){
                  TempData["Login"] = "Başarılı bir giriş yaptınız. Tebrikler!";
                  return RedirectToAction("Main","Home");
              }




            return View(model);
        }

        public async Task<IActionResult> Logout(){


            await signInManager.SignOutAsync();

            return RedirectToAction("Login","Manager");
        }


        public async Task<IActionResult> confirmEmail(string userId,string token){

            if(userId == null || token == null){
                ViewData["EmailMessage"] = "Kullanıcı oluşturma sırasında bir hata oluştu! Lütfen tekrardan deneyin";
                return View();
            }

            var user = await userManager.FindByIdAsync(userId);

            if(user == null){
                ViewData["EmailMessage"] = "Kullanıcı oluşturma sırasında bir hata oluştu! Lütfen tekrardan deneyin";
                return View();

            }

            var result = await userManager.ConfirmEmailAsync(user,token);

            if(result.Succeeded){
                
                ViewData["EmailMessage"] = "Başarılı bir şekilde kayıt oldunuz. Tebrikler!";
                return View();

            }

            ViewData["EmailMessage"] = "Beklenmedik bir hata oluştu";
            return View();




        }

        public IActionResult forgetPassword(){

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> forgetPassword(string email){
            if(string.IsNullOrEmpty(email)){
                ModelState.AddModelError("","Bir hata oluştu");
                return View();
            }

            var user = await userManager.FindByEmailAsync(email);

            if(user == null){
                 ModelState.AddModelError("","Bu email adresine sahip bir kullanıcı yok");
                return View();
            }

            

             var code = await userManager.GeneratePasswordResetTokenAsync(user);

                var url = Url.Action("resetPassword","Manager",new{
                    userEmail = user.Email,
                    token = code
                });


                await mailsender.sendEmailAsync(user.Email,"Şifre Değiştirme",$"<a href='http://localhost:5000{url}'>Linke</a> tıklayarak şifrenizi değiştirin.");

                return View();
                

        } 

        public IActionResult resetPassword(string userEmail,string token){

            if(userEmail==null || token == null){
               
                return RedirectToAction("forgetPassword");
            }

            var model = new ForgetPasswordModel(){
                email = userEmail,
                token = token
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> resetPassword(ForgetPasswordModel model)
        
        {
            if(!ModelState.IsValid){
                ModelState.AddModelError("","Bir hata oluştu");
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.email);


            var result = await userManager.ResetPasswordAsync(user,model.token,model.password);

            if(result.Succeeded){
                TempData["PasswordChange"] = "Şifre değiştirme talebiniz başarılı bir şekilde gerçekleşti.";
                return RedirectToAction("login","Manager");
            }

            return View(model);

        }

        [Authorize(Roles = "Admin")]
        public IActionResult addRole(){

            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]

        public async Task<IActionResult> addRole(AddRoleModel model){

            if(ModelState.IsValid){
                var result = await roleManager.CreateAsync(new IdentityRole(model.RoleName));
                

                if(result.Succeeded){
                    TempData["RoleAdded"] = "Rol başarılı bir şekilde eklendi.";

                    return RedirectToAction("roleList");
                }else{
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                    
                }
                }

            }

            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult roleList(){
                var roles = roleManager.Roles;
            return View(roleManager.Roles);
        }

        public async Task<IActionResult> deleteRole(string id){

            var role = await roleManager.FindByIdAsync(id);

            if(role == null){
                TempData["RoleDeleteMessage"] = "Boyle bir rol bulunmadı.";
                return RedirectToAction("roleList");
            }else{
                var result = await roleManager.DeleteAsync(role);

                if(result.Succeeded){
                    TempData["RoleDeleteMessage"] = "Rol başarılı bir şekilde silindi.";
                    return RedirectToAction("roleList");


                }
            }

            return RedirectToAction("roleList");

            
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> roleDetails(string id){

             var role = await roleManager.FindByIdAsync(id);

            List<User> members = new List<User>();

            List<User> nonMembers = new List<User>();

            if(role == null){
                TempData["RoleDeleteMessage"] = "Boyle bir rol bulunmadı.";
                return RedirectToAction("roleList");
            }else{
               

                foreach (var user in userManager.Users.Where(i => i.EmailConfirmed == true).ToList()){
                   var list = await userManager.IsInRoleAsync(user,role.Name)?members:nonMembers;

                   list.Add(user);
                }
                 var model = new RoleDetailModel(){
                    roleId = id,
                    roleName = role.Name,  
                    Members = members,
                    NonMembers = nonMembers
                };
               
                {
                    
                }

                return View(model);
            }

            

    }
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> roleDetails(string roleId,string roleName,string[] IdsToDelete,string[] IdsToAdded){
        
           var role = await roleManager.FindByIdAsync(roleId);

            if(role == null){
                TempData["RoleDeleteMessage"] = "Boyle bir rol bulunmadı.";
                return RedirectToAction("roleList");
            }

            foreach (var deleted in IdsToDelete){
                var user =await userManager.FindByIdAsync(deleted);

                var result = await userManager.RemoveFromRoleAsync(user,roleName);
            }

              foreach (var added in IdsToAdded){
                var user =await userManager.FindByIdAsync(added);

                var result = await userManager.AddToRoleAsync(user,roleName);
            }
            TempData["RoleDeleteMessage"] = "İşlem başarılı bir şekilde gerçekleşti.";

            return RedirectToAction("roleList");

            {
                
            }
    }


    public IActionResult AccessDenied(){
        return View();
    }
}

}