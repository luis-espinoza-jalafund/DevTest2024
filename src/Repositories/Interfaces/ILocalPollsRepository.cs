using DevTest.Domain.Entities;

namespace DevTest.Repositories.Interfaces;

public interface ILocalPollsRepository {
    Poll AddNewPollAsync(string name, List<string> optionsNames);
    List<Poll> GetAllPollsAsync();
    Poll? GetPollByID(int id);
    bool VoteOption(int pollId, int optionId, string voterEmail);
}