using GithubAction.Application.Models;
using MediatR;

namespace GithubAction.Application.Endpoints.People.Queries;

public class PeopleQuery : IRequest<EndpointResult<IEnumerable<PersonViewModel>>>
{
    public bool IncludeInactive { get; init; } = false;
}

