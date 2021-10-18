FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HotstarGen.Hash.Web/HotstarGen.Hash.Web.csproj", "HotstarGen.Hash.Web/"]
RUN dotnet restore "HotstarGen.Hash.Web/HotstarGen.Hash.Web.csproj"
COPY . .
WORKDIR "/src/HotstarGen.Hash.Web"
RUN dotnet build "HotstarGen.Hash.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HotstarGen.Hash.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HotstarGen.Hash.Web.dll"]
