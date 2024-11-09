using DevTest.Domain.Entities;

namespace DevTest.Repositories.Interfaces;

public interface IPollsRepository {
    Task<IEnumerable<Poll>> GetAllPollsAsync();
    Task<IEnumerable<Poll>> AddNewPollAsync(Poll entity, List<PollOptions> pollOptions);
    Task<IEnumerable<Poll>> VoteOption(Votes entity);
}