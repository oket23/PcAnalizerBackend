# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# копіюємо csproj
COPY ["AnalizerBackend/AnalizerBackend.csproj", "AnalizerBackend/"]

# restore
RUN dotnet restore "AnalizerBackend/AnalizerBackend.csproj"

# копіюємо решту коду
COPY . .

# збірка
WORKDIR "/src/AnalizerBackend"
RUN dotnet publish "AnalizerBackend.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Render передає PORT у середовище
ENV ASPNETCORE_URLS=http://+:$PORT

ENTRYPOINT ["dotnet", "AnalizerBackend.dll"]