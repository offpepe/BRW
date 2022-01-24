FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY ["BRW.WebApi/BRW.WebApi.csproj", "BRW.WebApi/"]
COPY ["BRW.Application/BRW.Application.csproj", "BRW.Application/"]
COPY ["BRW.Domain/BRW.Domain.csproj", "BRW.Domain/"]
COPY ["BRW.Infrastructure/BRW.Infrastructure.csproj", "BRW.Infrastructure/"]
RUN dotnet restore "BRW.WebApi/BRW.WebApi.csproj"

COPY . ./
WORKDIR "/src/BRW.WebApi"
RUN dotnet publish -c Release -o /app


FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
EXPOSE 80
COPY --from=build /app .
ENTRYPOINT ["dotnet", "BRW.WebApi.dll", "--environment=Development"]
