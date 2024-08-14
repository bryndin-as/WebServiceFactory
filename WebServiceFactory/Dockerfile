#FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
#WORKDIR /app
#EXPOSE 8080
#
#FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#COPY ["WebServiceFactory.csproj", "."]
#RUN dotnet restore "./WebServiceFactory.csproj"
#COPY . .
#WORKDIR "/src/."
#RUN dotnet build "./WebServiceFactory.csproj" -c $BUILD_CONFIGURATION -o /app/build
#
#FROM build AS publish
#ARG BUILD_CONFIGURATION=Release
#RUN dotnet publish "./WebServiceFactory.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "WebServiceFactory.dll"]
#
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["WebServiceFactory/WebServiceFactory.csproj", "WebServiceFactory/"]
COPY ["WebServiceFactoryContracts/WebServiceFactoryContracts.csproj", "WebServiceFactoryContracts/"]
COPY ["WebServiceFactoryInfrastructure/WebServiceFactoryInfrastructure.csproj", "WebServiceFactoryInfrastructure/"]
RUN dotnet restore "WebServiceFactory/WebServiceFactory.csproj"
COPY . .
WORKDIR "/src/WebServiceFactory"
RUN dotnet build "WebServiceFactory.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "WebServiceFactory.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebServiceFactory.dll"]
