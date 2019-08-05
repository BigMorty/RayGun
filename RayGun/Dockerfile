FROM microsoft/dotnet:2.1-runtime-stretch-slim AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk-stretch AS build
WORKDIR /src
COPY ["RayGun/RayGun.csproj", "RayGun/"]
RUN dotnet restore "RayGun/RayGun.csproj"
COPY . .
WORKDIR "/src/RayGun"
RUN dotnet build "RayGun.csproj" -c Release -o /app

FROM build AS test
WORKDIR /src
RUN dotnet test --logger "trx;LogFileName=/mytests/testresults.trx"

FROM build AS publish
RUN dotnet publish "RayGun.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RayGun.dll"]