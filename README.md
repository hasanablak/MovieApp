# MovieApp
 NetCore5  MVC
 



docker build -t moviapp-image -f Dockerfile .

docker run --rm -it -p 8080:8080 moviapp-image

a: dışarı port
b: docker iç port
docker run --rm -it -p a:b moviapp-image