# 1. Use the .NET 10 SDK to build the app
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# 2. Copy the csproj and restore dependencies
# 
COPY ["CVProject.csproj", "./"]
RUN dotnet restore "CVProject.csproj"

# 3. Copy everything else and build the release
COPY . .
RUN dotnet publish "CVProject.csproj" -c Release -o /app/publish

# 4. Use the ASP.NET 10 runtime to run the app
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# 5. listen on Render's required port
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000


ENTRYPOINT ["dotnet", "CVProject.dll"]