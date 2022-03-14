# The Kentico Xperience 13 training website (My Working Version)

This is my working version of the [Kentico Xperience 13 Training](https://github.com/Kentico/xperience-training-13)

The CMS Administrator has no password.
The SQL login should be restored with the bacpac, but you might have to edit the login to map to the db user.
You need to make an IIS website at localhost and an application pointing to /src/CMS with an alias of medioclinic-cms.

To build, run ./etc/formatAndBuild.ps1 with .NET SDK 3.1, then use Visual Studio to build the src/CMS/CMSApp.sln.
For development of the live site, use ./etc/watchWeb.ps1.

Everything below is from the README of that repository.

## About the repo

The repo contains the Medio Clinic sample website developed throughout the [Kentico Xperience 13 for Developers](https://xperience.io/services/training) course. The [codebase](https://github.com/Kentico/xperience-training-13) represents the final state of development.

The repo currently contains code of the following modules of the course:

* Essentials
* Builders
* Identity

The code of the modules does not exist in separate git branches or is otherwise split. It lives together as one working Visual Studio solution, internally separated using standard conventions (separate projects, MVC areas). Therefore, when taking the course, bear in mind that the code snippets in the course might slightly differ from what you see here in GitHub.

See [Kentico Xperience sample sites](https://devnet.kentico.com/articles/kentico-xperience-sample-sites-and-their-differences) for a detailed description of this and other Xperience sample sites.

## Requirements

Administration application prerequisites:

* Operating systems
  * Windows 8.1 and newer
  * Windows Server 2012 and newer
* IIS features
  * ASP.NET
  * .NET extensibility
  * ISAPI extensions
  * ISAPI filters
  * Static content
* .NET
  * .NET Framework 4.8 or newer

Live site application prerequisites:

* .NET
  * [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1) with ASP.NET Core runtime (included in [Visual Studio 2019 16.4](https://visualstudio.com/vs) or newer)

Common prerequisites:

* Visual Studio 2019 Community or higher
  * ASP.NET and web development workload
  * .NET Core cross-platform development workload
  * Git for Windows
  * GitHub Extension for Visual Studio
* [SQL Server 2012 Express or higher](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
  * Case-insensitive collation

For a complete list of system requirements, refer to our [documentation](https://docs.xperience.io/installation/system-requirements).

## How to run the code

> Please find the instructions [in the course](https://xperience.training.kentico.com/).

## Enabling external authentication

Prior to enabling external authentication for your development instance, make sure you've set the `ASPNETCORE_ENVIRONMENT` [environment variable](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-3.1) to `Development`.

### Google

Create a new [Google Console](https://console.developers.google.com/) project for your website. Create the OAuth Consent Screen and generate the [OAuth Client ID](https://support.google.com/cloud/answer/6158849). Set the __Authorized redirect URIs__ to `https://localhost:44324/signin-google`.

Add the generated __Client ID__ to your `appsettings.json`:

```json
"GoogleAuthenticationOptions": {
  "UseGoogleAuth": true,
  "ClientId": "<your-client-id>",
  "ClientSecret": "<your-client-secret>"
},
```

Store the __Client Secret__ value using the [Secret Manager](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows) feature.

### Microsoft

In the Azure Portal, create a new __App registration__ following [Microsoft's documentation](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/microsoft-logins?view=aspnetcore-3.1#create-the-app-in-microsoft-developer-portal). Ensure that the __Redirect URI__ is set to `https://localhost:44324/signin-microsoft`.

Add the __Application (client) ID__ from the _Overview tab_ you generated to the `appsettings.json`:

```json
"MicrosoftAuthenticationOptions": {
  "UseMicrosoftAuth": true,
  "ClientId": "<your-client-id>",
  "ClientSecret": "<your-client-secret>"
},
```

Store the __Client secret__ value using the [Secret Manager](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows) feature.

### Facebook

Create a [Facebook application](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/facebook-logins?view=aspnetcore-3.1#create-the-app-in-facebook) with the __OAuth Redirect URL__ of `https://localhost:44324/signin-facebook`. Add the following to your `appsettings.json` with the __App ID__ from the _Settings > Basic_ tab:

```json
"FacebookAuthenticationOptions": {
  "UseFacebookAuth": true,
  "AppId": "<your-app-id>",
  "AppSecret": "<your-app-secret>"
},
```

Store the __App secret__ value using the [Secret Manager](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows) feature.

### Twitter

Create a [Twitter application](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/twitter-logins?view=aspnetcore-3.1#create-the-app-in-twitter) with the __Callback URL__ of `https://localhost:44324/signin-twitter`. On the _Keys and Tokens_ tab, copy the __API key__ into your `appsettings.json`:

```json
"TwitterAuthenticationOptions": {
  "UseTwitterAuth": true,
  "ConsumerKey": "<your-api-key>",
  "ConsumerSecret": "<your-api-secret-key>"
},
```

Store the __API secret key__ value using the [Secret Manager](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows) feature.

## Coding conventions

The code in this repo follows the standard [C# coding conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions) documented in the [C# programming guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/), and the [coding guidelines](https://github.com/dotnet/aspnetcore/wiki/Engineering-guidelines#coding-guidelines) held by the ASP.NET Core product team at Microsoft.

## Troubleshooting

If you encounter a problem while going through the course, please let us know either through the course survey or by [filing an issue](https://github.com/Kentico/training-xperience-13/issues/new) here in GitHub.
