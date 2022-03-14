#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Vendor1/Vendor1.csproj", "Vendor1/"]
RUN dotnet restore "Vendor1/Vendor1.csproj"
COPY . .
WORKDIR "/src/Vendor1"
RUN dotnet build "Vendor1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vendor1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vendor1.dll"]