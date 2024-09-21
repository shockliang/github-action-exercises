using System.Diagnostics.CodeAnalysis;
using GithubAction.Application.Interfaces.Services;

namespace GithubAction.Infrastructure.Services;

[ExcludeFromCodeCoverage]
public class DateTimeService : IDateTimeService
{
    public DateTime UtcNow => DateTime.UtcNow;
}
