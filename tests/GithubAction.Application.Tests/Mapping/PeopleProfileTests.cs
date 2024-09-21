using AutoMapper;
using GithubAction.Application.Mapping;
using Xunit;

namespace GithubAction.Application.Tests.Mapping;

public class PeopleProfileTests
{
    [Fact]
    public void VerifyConfiguration()
    {
        var configuration = new MapperConfiguration(cfg => cfg.AddProfile<PeopleProfile>());

        configuration.AssertConfigurationIsValid();
    }
}
