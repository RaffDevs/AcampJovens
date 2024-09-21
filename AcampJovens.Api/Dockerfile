FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AcampJovens.Api/AcampJovens.Api.csproj", "AcampJovens.Api/"]
COPY ["AcampJovens.Application/AcampJovens.Application.csproj", "AcampJovens.Application/"]
COPY ["AcampJovens.CrossCutting/AcampJovens.CrossCutting.csproj", "AcampJovens.CrossCutting/"]
COPY ["AcampJovens.Infrastructure/AcampJovens.Infrastructure.csproj", "AcampJovens.Infrastructure/"]
COPY ["AcampJovens.Core/AcampJovens.Core.csproj", "AcampJovens.Core/"]
RUN dotnet restore "AcampJovens.Api/AcampJovens.Api.csproj"
COPY . .
WORKDIR "/src/AcampJovens.Api"
RUN dotnet build "AcampJovens.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "AcampJovens.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AcampJovens.Api.dll"]
