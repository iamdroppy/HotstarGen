FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Hotstar.HashFetch/Hotstar.HashFetch.csproj", "Hotstar.HashFetch/"]
RUN dotnet restore "Hotstar.HashFetch/Hotstar.HashFetch.csproj"
COPY . .
WORKDIR "/src/Hotstar.HashFetch"
RUN dotnet build "Hotstar.HashFetch.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hotstar.HashFetch.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hotstar.HashFetch.dll"]
