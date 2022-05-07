# BungieApiHelper
## Current State [In Dev]

## About
This project is a lib, that allow developer to acces the API of bungie for the game destiny 2

## How does it work ?
There is three main part of this project
### 1: Auth
For the bungie Authentication process, there is 4 endpoint :
1. Auth => Endpoint use to init the bungie Auth Process
2. Auth/Logged => This is the Redirect Url you need to register in your API settings on the Bungie Dev portal (the info like the token will be stored in the web browser cookie)
3. Auth/Refresh => Use to refresh to Auth token provided by bungie
4. Auth/loggout => Use to loggout
### 2: Helper
For each services provided by bungie there is a matching helper, they'll contain one methode for each endpoint.
### 3: Controller
Each Helper will have a associated Api Controller
There is two type of controller:
1. Default => No user authentication needed
2. Auth => User authentication needed
## How to use ?
1. Download the repo
2. Add the csproj to your Web Api
3. Register the lib by using the Locator.AddServiceRequierment();
4. Use Any EndPointHelper or any Controller

## Using Nuget
See : https://www.nuget.org/packages/BungieApiHelper/

