using GithubAction.Application.Models;
using MediatR;

namespace GithubAction.Application.Endpoints.People.Commands;

public class AddPersonCommand : IRequest<EndpointResult<PersonViewModel>>
{
    public int? Id { get; init; }
    public string FirstName { get; init; } = "";
    public string LastName { get; init; } = "";
}
