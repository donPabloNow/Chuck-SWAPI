# chuckswapi_api - ASP.NET Core 3.0 Server

chucknorris.io is a free JSON API for hand curated Chuck Norris facts.  Chuck Norris facts are satirical factoids about martial artist and actor Chuck Norris that have become an Internet phenomenon and as a result have become widespread in popular culture. The 'facts' are normally absurd hyperbolic claims about Norris' toughness, attitude, virility, sophistication, and masculinity.  Chuck Norris facts have spread around the world, leading not only to translated versions, but also spawning localized versions mentioning country-specific advertisements and other Internet phenomena. Allusions are also sometimes made to his use of roundhouse kicks to perform seemingly any task, his large amount of body hair with specific regard to his beard, and his role in the action television series Walker, Texas Ranger.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/chuckswapi_api
docker build -t chuckswapi_api .
docker run -p 5000:5000 chuckswapi_api
```
