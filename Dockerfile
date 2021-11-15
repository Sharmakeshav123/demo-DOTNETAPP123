FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["InventoryManagement.csproj", "./"]
RUN dotnet restore "InventoryManagement.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "InventoryManagement.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InventoryManagement.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InventoryManagement.dll"]
