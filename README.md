# hellodocker
Dumb little test project creating a Nancy hello world that can run in a .net core docker container.

## Build and run in docker
`docker build -t hellodocker .` <br>
`docker run -d -p 5000:5000 --name runhellodocker hellodocker`

## Test
Go to http://localhost:5000/hello
