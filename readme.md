La branch master est protégé (sans le require approval car je ne peux pas m'auto approve)

docker build -t mon-app-blazor-wasm .

docker run -d -p 8080:80 mon-app-blazor-wasm

http://localhost:8080/

se rendre sur l'onglet weather
ouvrir les dev tools et constater que l'une requete est parti vers l'api d'openweather

note, le token d'api est en dur dans le appsettings.json, comme echang� lors du cours
il n'est pas possible de le cacher �tant donn� que le code est execut� cot� client (cela n'a donc plus rien de secret)
si on voulais le rendre dynamique il faudrait dans la ci injecter le token dans le fichier appsettings.json
mais vous m'avez dit de ne pas le faire.

https://hub.docker.com/repository/docker/duffscs/myapp/tags