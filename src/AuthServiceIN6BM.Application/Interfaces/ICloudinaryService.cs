namespace AuthServiceIN6BM.Application.Interfaces;

public interface ICloudinaryService
{
    Task<string> UploadImageAsync(IFileData imageFile, string filename);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDefaulAvatarUrl();
    string GetFullImageUrl(string imagePath);
}