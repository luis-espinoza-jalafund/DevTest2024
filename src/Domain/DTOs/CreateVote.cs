using System.ComponentModel.DataAnnotations;

namespace DevTest.Domain.Dto;

public class CreateVote
{
    [Required(ErrorMessage ="OptionId must exist")]
    public int OptionId { get; set; }

    [Required(ErrorMessage ="Email must exist")]
    [RegularExpression(@"^[a-zA-Z0-9.-]+@[a-zA-Z0-9.-]+\.[a-zA-Z0-9_-]+$", ErrorMessage ="Invalid Email")]
    public required string voterEmail { get; set; }
}