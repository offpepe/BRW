FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BRW.API/BRW.API.csproj", "BRW.API/"]
RUN dotnet restore "BRW.API/BRW.API.csproj"
COPY . .
WORKDIR "/src/BRW.API"
RUN dotnet build "BRW.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BRW.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BRW.API.dll"]
