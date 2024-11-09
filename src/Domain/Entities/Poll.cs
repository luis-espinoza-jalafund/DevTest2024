namespace DevTest.Domain.Entities;

public class Poll
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required List<PollOptions> Options { get; set; } = new List<PollOptions>();

}