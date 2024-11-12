﻿FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["EtyTool.csproj", "./"]
RUN dotnet restore "EtyTool.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "EtyTool.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "EtyTool.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ARG ASPNETCORE_HTTP_PORTS=80;8080
ARG ASPNETCORE_HTTPS_PORTS=443;8081
ENTRYPOINT ["dotnet", "EtyTool.dll"]
