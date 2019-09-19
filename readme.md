https://www.youtube.com/watch?v=SOtC1VLZKm4

57:30
1:02:24: start AZURE configuration
Pipeline 1

```YAML
# ASP.NET Core
# Build and test ASP.NET Core projects targeting .NET Core.
# Add steps that run tests, create a NuGet package, deploy, and more:
# https://docs.microsoft.com/azure/devops/pipelines/languages/dotnet-core

trigger:
- master

pool:
  vmImage: 'ubuntu-latest'

variables:
  buildConfiguration: 'Release'

steps:
- script: dotnet build --configuration $(buildConfiguration)
  displayName: 'dotnet build $(buildConfiguration)'
```

Added test

```YAML
- task: DotNetCoreCLI@2
  inputs:
    command: test
    projects: '**/*test/*.csproj'
    arguments: '--configuration $(buildConfiguration)'
```

https://dev.azure.com/pegaba/Vidtutorial/_apis/build/status/pegaba.VidTutorial?branchName=master
