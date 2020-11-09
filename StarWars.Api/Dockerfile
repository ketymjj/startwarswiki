#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["StarWars.Api/StarWars.Api.csproj", "StarWars.Api/"]
COPY ["StarWars.Ioc/StarWars.Ioc.csproj", "StarWars.Ioc/"]
COPY ["StarWarsWiki.Data/StarWarsWiki.Data.csproj", "StarWarsWiki.Data/"]
COPY ["StarWarsWiki.Domain/StarWarsWiki.Domain.csproj", "StarWarsWiki.Domain/"]
COPY ["StarWarsWikiApplication/StarWarsWikiApplication.csproj", "StarWarsWikiApplication/"]
RUN dotnet restore "StarWars.Api/StarWars.Api.csproj"
COPY . .
WORKDIR "/src/StarWars.Api"
RUN dotnet build "StarWars.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StarWars.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StarWars.Api.dll"]