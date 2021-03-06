# BungieApiHelper
## Current State [In Dev]
See https://bungie-net.github.io/multi/index.html for the full list of Bungie API Endpoints
## Implemented Endpoint
1. App => fully implmented
2. User => fully implmented
3. Content => fully implmented
4. Forum => fully implmented
5. GroupV2 => fully implmented
6. Tokens => fully implmented
7. Destin2 => partially implmented
8. CommunityContent => not implmented
9. Trending => not implmented
10. Fireteam => not implemted
11. Social => not implmented

## About
This project is a lib, that allow developer to acces the API of bungie for the game destiny 2

## How does it work ?
There is three main part of this project
### 1: Auth
This part need and API or a web server in order to work
For the bungie Authentication process, there is 4 endpoint :
1. Auth => Endpoint use to init the bungie Auth Process
2. Auth/Logged => This is the Redirect Url you need to register in your API settings on the Bungie Dev portal (the info like the token will be stored in the web browser cookie)
3. Auth/Refresh => Use to refresh to Auth token provided by bungie
4. Auth/loggout => Use to loggout
### 2: Helper/App Mode
For each services provided by bungie there is a matching helper, they'll contain one methode for each endpoint.
### 3: Controller/Api Mode
Each Helper will have a associated Api Controller
There is two type of controller:
1. Default => No user authentication needed
2. Auth => User authentication needed
### Config
In order for the helper or the controller to work you'll need to set the config object in the Locator class. In addition to that you'll need to set some info to allow the solution to work see picture bellow.

![Config configuration](https://user-images.githubusercontent.com/44467071/167275107-551423b2-7ee3-45b4-814f-e2293c75daec.png)


## How to use ?
### Download and modify
1. Download the repo
2. Add the csproj to your Web Api
3. Register the lib by using the Locator.AddServiceRequierment();
4. Use Any EndPointHelper or any Controller

### NuGet
install the NuGet package from : https://www.nuget.org/packages/BungieApiHelper/
