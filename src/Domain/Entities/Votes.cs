namespace DevTest.Domain.Entities;

public class Votes
{
    public int Id { get; set; }
    public int PollId { get; set; }
    public int OptionId { get; set; }
    public required string voterEmail { get; set; }
}