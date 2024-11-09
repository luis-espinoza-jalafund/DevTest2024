using DevTest.Domain.Entities;
using DevTest.Repositories.Interfaces;
namespace DevTest.Repositories;

public class LocalPollRepository : ILocalPollsRepository
{
    private List<Poll> polls = new List<Poll>();
    private List<Votes> votes = new List<Votes>();
    private int pollIdCont = 1;
    private int optionsIdCont = 1;
    public Poll AddNewPollAsync(string name, List<string> optionsNames)
    {
        List<PollOptions> options = new List<PollOptions>();
        foreach( var optionName in optionsNames)
        {
            options.Add(new PollOptions {
                Id = optionsIdCont++,
                Name = optionName,
                Votes  = 0
            });
        }
        var poll = new Poll 
        {
            Id = pollIdCont++,
            Name = name,
            Options = options
        };
        polls.Add(poll);
        return poll;
    }

    public List<Poll> GetAllPollsAsync()
    {
        return polls;
    }

    public Poll? GetPollByID(int id)
    {
        return polls.FirstOrDefault(p => p.Id == id);
    }

    public bool VoteOption(int pollId, int optionId, string voterEmail)
    {
        if (votes.Any(v => v.PollId == pollId && v.voterEmail == voterEmail))
        {
            return false;
        }
        var poll = GetPollByID(pollId);
        if(poll == null )
        {
            return false;
        }

        var option = poll.Options.FirstOrDefault(o => o.Id == optionId);
        if(option == null )
        {
            return false;
        }

        option.Votes++;
        votes.Add(new Votes {
            PollId = pollId,
            OptionId = optionId,
            voterEmail = voterEmail
        });
        
        return true;
    }
}