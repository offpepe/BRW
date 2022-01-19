using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace BRW.API.Entities;

public class User : Basis
{
    [EmailAddress]
    [StringLength(50)]
    public string Email { get; set; }
    [PasswordPropertyText]
    public string Password { get; set; }
    
}
