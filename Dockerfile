FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY src/GithubAction.Domain/GithubAction.Domain.csproj ./src/GithubAction.Domain/
COPY src/GithubAction.Application/GithubAction.Application.csproj ./src/GithubAction.Application/
COPY src/GithubAction.Infrastructure/GithubAction.Infrastructure.csproj ./src/GithubAction.Infrastructure/
COPY src/GithubAction.Api/GithubAction.Api.csproj ./src/GithubAction.Api/
RUN dotnet restore ./src/GithubAction.Api/GithubAction.Api.csproj

COPY . ./
RUN dotnet publish ./src/GithubAction.Api -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
EXPOSE 5432
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "GithubAction.Api.dll"]
