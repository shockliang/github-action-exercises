using GithubAction.Domain.Entities;

namespace GithubAction.Application.Interfaces.Persistence.DataServices.People.Queries;

public interface IGetPeopleDataService
{
    Task<IEnumerable<Person>> ExecuteAsync(bool includeInactive, CancellationToken cancellationToken = default);
}
