FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS PizzaDomain
WORKDIR /app
COPY PizzaBox.Domain/ ../PizzaBox.Domain
RUN dotnet restore ../PizzaBox.Domain/*.csproj --no-dependencies
RUN dotnet build ../PizzaBox.Domain/*.csproj --no-restore -c Release

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS PizzaData
WORKDIR /app
COPY PizzaBox.Data/ ../PizzaBox.Data
COPY --from=PizzaDomain ./PizzaBox.Domain/ ../PizzaBox.Domain
RUN dotnet restore ../PizzaBox.Data/*.csproj 
RUN dotnet build ../PizzaBox.Data/*.csproj --no-restore -c Release

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS PizzaWeb
WORKDIR /app
COPY Web/ ../Web
COPY --from=PizzaDomain ./PizzaBox.Domain/ ../PizzaBox.Domain
COPY --from=PizzaData ./PizzaBox.Data/ ../PizzaBox.Data
RUN dotnet restore ../Web/*.csproj 
RUN dotnet build ../Web/*.csproj --no-restore -c Release
RUN dotnet publish ../Web/*.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS deploy

WORKDIR /app

EXPOSE 80
EXPOSE 443

COPY --from=PizzaWeb Web/out ./
CMD [ "dotnet", "Web.dll" ]