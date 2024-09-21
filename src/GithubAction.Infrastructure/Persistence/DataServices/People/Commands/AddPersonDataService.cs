using GithubAction.Application.Interfaces.Persistence.DataServices.People.Commands;
using GithubAction.Domain.Entities;

namespace GithubAction.Infrastructure.Persistence.DataServices.People.Commands;

public class AddPersonDataService : IAddPersonDataService
{

    public async Task<Person> ExecuteAsync(Person person, CancellationToken cancellationToken = default)
    {
        // TODO: Create add code.
        return await Task.Run(() =>
        {
            person.Id = 1;

            return person;
        });
    }
}
