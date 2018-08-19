FROM node:alpine AS build
WORKDIR /app/vuespa

COPY src/frontend/vuespa/package*.json ./
RUN npm install

COPY src/frontend/vuespa/ ./
RUN npm run build

FROM nginx:alpine AS runtime
WORKDIR /usr/share/nginx/html/

RUN mv index.html index.html.default
COPY --from=build /app/vuespa/index.html ./
COPY --from=build /app/vuespa/dist/ ./dist
