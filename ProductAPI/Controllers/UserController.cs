using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository; // Inject your user repository
        private readonly IAuthService _authService; // Inject your authentication service

        // POST: api/users/changepassword
        [HttpPost("changepassword")]
        public IActionResult ChangePassword([FromBody] ChangePasswordRequest request)
        {
            // Validate request (current password, new password, etc.)
            var userId = GetCurrentUserId(); // Implement this method to get the current user's ID
            var user = _userRepository.GetUserById(userId);

            // Verify current password (compare hashed passwords)
            if (!VerifyPasswordHash(request.CurrentPassword, user.PasswordHash))
            {
                return BadRequest("Invalid current password.");
            }

            // Update password (hash the new password)
            user.PasswordHash = HashPassword(request.NewPassword);
            _userRepository.UpdateUser(user);

            return Ok("Password changed successfully.");
        }
    }

}
