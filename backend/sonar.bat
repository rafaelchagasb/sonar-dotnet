dotnet test utils.test/utils.test.csproj  --collect:"XPlat Code Coverage" /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
dotnet test domain.test/domain.test.csproj  --collect:"XPlat Code Coverage" /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
dotnet sonarscanner begin /k:"sonar-dotnet" /d:sonar.login="<SONAR TOKEN>" /d:sonar.cs.opencover.reportsPaths="**\coverage.opencover.xml" /d:sonar.coverage.exclusions="**Tests*.cs"
dotnet build backend.sln
dotnet sonarscanner end /d:sonar.login="<SONAR TOKEN>"
