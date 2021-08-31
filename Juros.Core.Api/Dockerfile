#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 3001

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Juros.Core.Api/Juros.Core.Api.csproj", "Juros.Core.Api/"]
COPY ["Juros.Core.IoC/Juros.Core.IoC.csproj", "Juros.Core.IoC/"]
COPY ["Juros.Core.Application/Juros.Core.Application.csproj", "Juros.Core.Application/"]
COPY ["Juros.Core.Domain/Juros.Core.Domain.csproj", "Juros.Core.Domain/"]
COPY ["Juros.Core.Data/Juros.Core.Data.csproj", "Juros.Core.Data/"]
COPY ["Juros.Core.ExceptionManager/Juros.Core.ExceptionManager.csproj", "Juros.Core.ExceptionManager/"]
RUN dotnet restore "Juros.Core.Api/Juros.Core.Api.csproj"
COPY . .
WORKDIR "/src/Juros.Core.Api"
RUN dotnet build "Juros.Core.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Juros.Core.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Juros.Core.Api.dll"]