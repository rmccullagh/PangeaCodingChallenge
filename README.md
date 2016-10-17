# Requirements
- SQL Sever Local DB, which may or may not be shipped with .NET Core, 
- .NET Core

# Windows
- https://www.microsoft.com/net/core#windows

# Mac
- https://www.microsoft.com/net/core#macos

# Build & Run
```
git clone https://github.com/rmccullagh/PangeaCodingChallenge.git
cd PangeaCodingChallenge/src/Pangea.Coding.Challenge
dotnet restore
dotnet ef migrations add MyMigration
dotnet ef database update
dotnet run
```
Navigation to http://localhost:5000

# Features Implemented
The Load Data feature will read and write data from the Github API and
save it a local database.

The Purge Data feature will delete all rows in the database, so the user
can see the table without any data, and invoke the first feature implemented.

# TODO
Unit tests with NUnit
