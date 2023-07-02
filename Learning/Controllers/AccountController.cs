using Learning.Models;
using Learning.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Learning.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository accountRepo;

        public AccountController(IAccountRepository accountRepository) {
            accountRepo = accountRepository;
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            var result = await accountRepo.SignUpAsync(model);
            if (result.Succeeded) {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            var result = await accountRepo.SignInAsync(model);
            if (string.IsNullOrEmpty(result)) return Unauthorized();
            return Ok(result);
        }
    }
}
