using DevTest.Domain.Entities;
using DevTest.Repositories.Interfaces;

namespace DevTest.Services;

public class LocalPollServices : ILocalPollServices
{
    private readonly ILocalPollsRepository _localPollsRepository;
    public LocalPollServices(ILocalPollsRepository localPollsRepository)
    {
        _localPollsRepository = localPollsRepository;
    }

    public IEnumerable<Poll> getAllPolls()
    {
        return _localPollsRepository.GetAllPollsAsync();
    }

    public Poll CreatePoll(string name, List<string> options)
    {
       return _localPollsRepository.AddNewPollAsync(name, options);
    }

    public Poll? GetPollById(int pollId)
    {
        return _localPollsRepository.GetPollByID(pollId);
    }

    public bool Vote(int pollId, int optionId, string email)
    {
        return _localPollsRepository.VoteOption(pollId, optionId, email);

    } 
}