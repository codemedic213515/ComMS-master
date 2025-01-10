using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using ComMS.DTOs;
using ComMS.Models;
using System.ComponentModel.DataAnnotations;
namespace ComMS.Components.Pages
{
    
    public class LoginModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginModel(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [BindProperty]
        public InputModel Input { get; set; } = new InputModel();
        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            public bool LoginFailed { get; set; }
        }

        public void OnGet()
        {
            // Render login page
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(Input.UserName, Input.Password, false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return Redirect("/home");  // Redirect to home or any other page
                }
                else
                {
                    Input.LoginFailed = true;
                }
            }

            return Page();  // Redisplay the page in case of error
        }
    }

}
