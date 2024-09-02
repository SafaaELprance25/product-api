using Microsoft.AspNetCore.Mvc;

namespace ProductAPI
{
    public interface IAuthService
    {
        string GenerateJwtToken(User user);
        bool ValidateJwtToken(string token);
    }

    // Implementation (simplified)
    public class AuthService : IAuthService
    {
        private readonly string _secretKey = "your-secret-key"; // Replace with a secure key
                                                                // Other dependencies (e.g., user repository)

        public string GenerateJwtToken(User user)
        {
            // Create and sign a JWT token
            // Include user claims (e.g., username, role)
            // Return the token
        }

        public bool ValidateJwtToken(string token)
        {
            // Validate the token signature and expiration
            // Extract user claims
            // Return true if valid, false otherwise
        }
    }


}
