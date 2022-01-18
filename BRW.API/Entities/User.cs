using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BRW.API.Entities.Interfaces;

namespace BRW.API.Entities;

public class User : Basis
{
    [StringLength(50)]
    public string Email { get; set; }
    [StringLength(16)]
    public string Password { get; set; }
    
}
