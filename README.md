# Dotnet.Configuration

This is a simple ASP.NET Core project to demostrate the asp.net core [configuration hierarchy and fallbacks](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-5.0).

As far as I understand : 

1. Variables / settings declared in appsettings.json is overridden by appsettings.development.json or appsettings.Pooduction.json.
2. Env variables set in ```system environment variables``` override those set in appsettings.json / appsettings.development.json / appsettings.Pooduction.json
3. Environment variables set in launchSettings.json override those set in the system environment

# Running the project 

``` DOTNET Run ``` will start off the project in https:\\localhost:5001

All available endpoints will be listed via Swagger -> ```https:\\localhost:5001\swagger```

The endpoint : ```TestResult``` returns the value related to ClientSecret based on the configuration source hierarchy.

#  Setting the environment variable from command prompt

```setx ClientSecret__Id TestClient /M```

```setx ClientSecret__Value testclientSecretFRomEnv /M```
