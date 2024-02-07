dotnet new sln -n hour-of-code
dotnet new classlib -o design-patterns
dotnet sln add ./design-patterns/design-patterns.csproj
dotnet new xunit -o design-patterns.tests
dotnet sln add ./design-patterns.tests/design-patterns.tests.csproj