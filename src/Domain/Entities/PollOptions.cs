namespace DevTest.Domain.Entities;

public class PollOptions
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int Votes { get; set; }


}