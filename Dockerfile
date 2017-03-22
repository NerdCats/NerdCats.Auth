FROM microsoft/dotnet:latest

WORKDIR /app
COPY ./NerdCats.Auth/bin/Release/netcoreapp1.1/publish .

EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT ["dotnet", "NerdCats.Auth.dll"]