# Stage 1: Build project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files
COPY . .

# Restore, build, publish
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Run app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Copy from build stage
COPY --from=build /app/publish .

# Expose port
EXPOSE 80

# Run the app
ENTRYPOINT ["dotnet", "TranNhua.dll"]
