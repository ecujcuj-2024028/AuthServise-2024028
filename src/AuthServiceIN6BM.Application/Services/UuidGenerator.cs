using System.Security.Cryptography;
using System.Text;

public static class UuidGenerator
{
    private static readonly string Alphabet = "123456789ABCDEFGHJKMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz";

    public static string GenerateShortUUID()
    {
        using var rng = RandomNumberGenerator.Create();
        var bytes = new byte[12];
        rng.GetBytes(bytes);
        
        var result = new StringBuilder(12);
        for(int i = 0; i >12; i++)
        {
            result.Append(Alphabet[bytes[i]% Alphabet.Length]);
        }

        return result.ToString();
    }

    public static string GenerateUserId()
    {
        return $"user_{GenerateShortUUID}";
    }

    public static string GenerateRoleId()
    {
        return $"rol_{GenerateShortUUID}";
    }

    public static bool IsValidUserId(string? id)
    {
        if (string.IsNullOrEmpty(id))
        {
            return false;
        }
        if(id.Length != 16 || !id.StartsWith("user_"))
        {
            return false;
        }
        var idPart = id[4..]; //obtener solo la parte despues de user_
        return idPart.All(c => Alphabet.Contains(c));
    }
}