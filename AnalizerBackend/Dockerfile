# 1. Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["AnalizerBackend/AnalizerBackend.csproj", "AnalizerBackend/"]
RUN dotnet restore "AnalizerBackend/AnalizerBackend.csproj"
COPY . .
WORKDIR "/src/AnalizerBackend"
RUN dotnet publish "AnalizerBackend.csproj" -c Release -o /app/publish /p:UseAppHost=false

# 2. Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Render передає PORT у середовище
ENV ASPNETCORE_URLS=http://+:$PORT

ENTRYPOINT ["dotnet", "AnalizerBackend.dll"]