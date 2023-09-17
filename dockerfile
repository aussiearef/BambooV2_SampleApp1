FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App
COPY . ./
EXPOSE 80

ENTRYPOINT ["dotnet","SearchApi.dll"]


