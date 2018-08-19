# docker-compose -f docker-compose-api.yml up
docker-compose up -d \
  && clear \
  && echo "Starting then docker successfully ..." \
  && echo "[SERVER:API] Hosting on http://localhost:5000" \
  && echo "[CLIENT:SPA] Hosting on http://localhost:8080"