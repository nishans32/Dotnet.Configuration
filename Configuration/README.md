# Dotnet.Configuration

This is a simple ASP.NET Core project to demostrate the asp.net core configuration hierarchy and fallbacks.

# Running the project 

``` DOTNET Run ``` will start off the project in https:\\localhost:5001

All available endpoints will be listed via Swagger -> ```https:\\localhost:5001\swagger```

The endpoint : ```TestResult``` returns the value related to ClientSecret based on the hierarchy.

#  Setting the environment variable from command prompt

```setx ClientSecret__Id TestClient /M```
```setx ClientSecret__Value testclientSecretFRomEnv /M```