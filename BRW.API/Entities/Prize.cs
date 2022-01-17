using System.ComponentModel.DataAnnotations.Schema;

namespace BRW.API.Entities;

public class Prize: Basis
{
    public int TeamId { get; set; }
    public int GroupId { get; set; }
}