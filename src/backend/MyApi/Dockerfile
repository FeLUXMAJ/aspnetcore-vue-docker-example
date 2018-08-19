FROM microsoft/dotnet:sdk AS build
WORKDIR /app/myapi

COPY src/backend/MyApi/*.csproj ./
RUN dotnet restore

COPY src/backend/MyApi/ ./
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/myapi/out/ ./
ENTRYPOINT [ "dotnet", "MyApi.dll" ]