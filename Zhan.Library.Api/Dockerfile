FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Zhan.Library.Api/Zhan.Library.Api.csproj", "Zhan.Library.Api/"]
RUN dotnet restore "Zhan.Library.Api/Zhan.Library.Api.csproj"
COPY . .
WORKDIR "/src/Zhan.Library.Api"
RUN dotnet build "Zhan.Library.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Zhan.Library.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zhan.Library.Api.dll"]
