using System.ComponentModel.DataAnnotations;
using DevTest.Domain.Entities;

namespace DevTest.Domain.Dto;

public class CreatePoll 
{
    [Required(ErrorMessage ="Poll name must not be empty")]
    public required string name { get; set; }

    [Required(ErrorMessage ="Poll Options must not be empty")]
    [MinLength(2, ErrorMessage ="Poll must have at least two options")]
    public required List<string> options { get; set; }
}