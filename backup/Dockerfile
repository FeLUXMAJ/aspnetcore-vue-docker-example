FROM microsoft/dotnet:sdk AS build
WORKDIR /app/server

# copy csproj and restore as distinct layers
COPY server/*.sln ./
COPY server/MineApi/*.csproj ./MineApi/
RUN dotnet restore

# copy everything else
WORKDIR /app
COPY . ./

#  build app
WORKDIR /app/server
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/server/MineApi/out ./
ENTRYPOINT ["dotnet", "MineApi.dll"]
