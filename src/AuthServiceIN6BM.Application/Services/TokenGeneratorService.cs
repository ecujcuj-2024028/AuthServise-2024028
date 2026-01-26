using System.Security.Cryptography;

namespace AuthServiceIN6BM.Application.Services;

public static class TokenGeneratorService
{
    public static string GenerateEmailVerificationToken()
    {
        return GenerateSecureToken(32);
    }

    public static string GeneratePasswordResetToken()
    {
        return GenerateSecureToken(32);
    }

    private static string GenerateSecureToken(int length)
    {
        using var rng = RandomNumberGenerator.Create();
        var Bytes = new byte[length];
        rng.GetBytes(Bytes);
        return Convert.ToBase64String(Bytes).Replace("+", "-").Replace("/","_").Replace("=","");
    }
}