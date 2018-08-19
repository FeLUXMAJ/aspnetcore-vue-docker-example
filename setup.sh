# docker image rm $(docker image ls -q aspnetapi-demo)
# sleep 3

docker build -t aspnetapi-demo .

sleep 3
docker image prune -f

sleep 3
docker run --rm -d -p 8080:80 --name myapi aspnetapi-demo

clear
echo "Run this app at http://localhost:8080 ..."