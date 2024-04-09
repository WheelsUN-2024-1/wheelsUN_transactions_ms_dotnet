# Use a slim .NET 8.0 base image for efficiency
FROM microsoft/dotnet:aspnetcore-runtime-8.0 AS base

# Set working directory within the container
WORKDIR /app

# Copy project files (.sln or .csproj) and restore dependencies
COPY . .
RUN dotnet restore

# Publish the application in Release mode for production (adjust as needed)
COPY . .
RUN dotnet publish -c Release -o out

# Create a new image based on the base image, copying the published output
FROM base AS app

# Copy published application files from the build stage
COPY --from=build out .

# Set the entry point to run your application
ENTRYPOINT ["dotnet", "wheelsUN_transaction_ms.dll"]

# Optional: Expose port if your application listens on a specific port
EXPOSE 7282  # Replace 80 with the actual port your application listens on
