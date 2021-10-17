FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HotstarGen/HotstarGen.csproj", "HotstarGen/"]
RUN dotnet restore "HotstarGen/HotstarGen.csproj"
COPY . .
WORKDIR "/src/HotstarGen"
RUN dotnet build "HotstarGen.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HotstarGen.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HotstarGen.dll"]
