using System.ComponentModel.DataAnnotations.Schema;

namespace BRW.API.Entities;

public class Team: Basis
{
    public int GroupId { get; set; }
}