FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["AdministrationServerCore/AdministrationServerCore.csproj", "AdministrationServerCore/"]
RUN dotnet restore "AdministrationServerCore/AdministrationServerCore.csproj"
COPY . .
WORKDIR "/src/AdministrationServerCore"
RUN dotnet build "AdministrationServerCore.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AdministrationServerCore.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AdministrationServerCore.dll"]