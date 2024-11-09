
using DevTest.Domain.Entities;

namespace DevTest.Services;

public interface ILocalPollServices
{
    IEnumerable<Poll> getAllPolls();
    Poll CreatePoll(string name, List<string> options);
    Poll? GetPollById(int pollId);
    bool Vote(int pollId, int optionId, string email);
}