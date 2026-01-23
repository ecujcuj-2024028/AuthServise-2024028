using System.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BM.Domain.Entities;
public class User
{
    [Key]
    [MaxLength(16)]
    public string Id{get; set;} = string.Empty;

    [Required (ErrorMessage = "El nombre es obligatorio.")]
    [MaxLength(25, ErrorMessage = "El nombre no puede tener mas de 25 caracteres.")]
    public string Name {get; set;} = string.Empty;

    [Required (ErrorMessage = "El apellido es obligatorio.")]
    [MaxLength(25, ErrorMessage = "El apellido no puede tener mas de 25 caracteres.")]
    public string Surname {get; set;} = string.Empty;

    [Required (ErrorMessage = "El nombre de usuario es obligatorio.")]
    [MaxLength(25, ErrorMessage = "El nombre de usuario no puede tener mas de 25 caracteres.")]
    public string Username {get; set;} = string.Empty;

    [Required (ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress( ErrorMessage = "El correo no tiene un formato valido.")]
    [MaxLength(150, ErrorMessage ="El Correo no puede tener mas de 150 caracteres")]
    public string Email {get; set;} = string.Empty;

    [Required (ErrorMessage = "La contraseña es obligatorio.")]
    [MinLength (8, ErrorMessage = "La contraseña no puede tener menos de 8 Caracteres.")]
    [MaxLength(255, ErrorMessage ="La contraseña no puede tener mas de 255 caracteres")]
    public string Password{get; set;} = string.Empty;

    public bool Status {get; set;} = false;

    public DateTime CreateAt{get;set;}
    public DateTime UpdateAt{get;set;}
    public UserProfile UserProfile {get; set;} = null!;
    public ICollection<UserRole> UserRoles {get;set;}= [];
    public UserEmail UserEmail {get; set;} = null!;

    public UserPasswordReset UserPasswordReset {get; set;} = null!;
}