namespace GithubAction.Application.Interfaces;

public interface IRequestValidator<TRequest>
{
    IEnumerable<string> ValidateRequest(TRequest request);
}
