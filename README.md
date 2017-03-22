# NerdCats.Auth [![Build Status](https://travis-ci.org/NerdCats/NerdCats.Auth.svg?branch=master)](https://travis-ci.org/NerdCats/NerdCats.Auth)
A single sign on server implementation powered by IdentityServer4. Uses mongodb for storage and uses Asp.net Identity Core.

## Acknowldegements
 - [IdentityServer4](https://github.com/IdentityServer/IdentityServer4)
 - [aspnet-identity-mongo](https://github.com/g0t4/aspnet-identity-mongo)

## Why another single sign on implementation
Single sign on solutions are pretty much available now a days thanks to auth providers like Auth0. And it is perfectly fine to use them. Same goes for using IdentityServer. Yes, it is indeed jumping a lot of hoops just to get a SSO running but it is worth it. You can essentially have full control on your SSO policies.

## FAQ
### What storage system this is compatible with?
NerdCats.Auth uses mongodb as storage thanks to Wes Higbee and his great work on [aspnet-identity-mongo](https://github.com/g0t4/aspnet-identity-mongo).

### What membership system does this one use?
It is totally Asp.net Identity driven.

### Can I use this for any app that needs a single sign on decoupled server?
Yes

### How much work is done?
Clients and Scopes are still fetched from in memory collection. Would change soon. We don't
have an admin panel to control these yet since this is forked off the samples of IdentityServer4.

### How much has been taken from IdentityServer4?
A lot. You can see all of them under the IdentityServer.Core project.

### What if I want to know more on how this works?
Turn straight to [IdentityServer4 samples](https://github.com/IdentityServer/IdentityServer4.Samples). That is the best place to get yourself started.

### Will there be a docker container to test out in future?
You bet!

### Okay, Im sold, how can I test?
 - Open `NerdCats.Auth\appsettings.json`
 - Modify the `Database Configuration` like below:
 ```json
"Database": {
    "ConnectionString": "mongodb://<mongodb-connection-string>/<your-database-name>",
    "DatabaseName": "<your-database-name>"
    }
 ```
 - run `dotnet restore`
 - run `dotnet run`

Please use same `DatabaseName` in both of the properties, its a known development wart for now. We'd fix it with time of course.
