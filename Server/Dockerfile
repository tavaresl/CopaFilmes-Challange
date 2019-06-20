FROM microsoft/dotnet:2.2-sdk  AS build-env

WORKDIR /app

COPY ./API ./API
COPY ./Domain ./Domain
COPY ./Infrastructure ./Infrastructure

RUN dotnet publish -c Release -o ../bin ./API/API.csproj

FROM microsoft/dotnet:2.2-aspnetcore-runtime

ENV ASPNETCORE_URLS http://+:5000

WORKDIR /app
COPY --from=build-env /app/bin .

EXPOSE 5000
EXPOSE 5001

ENTRYPOINT ["dotnet", "API.dll"]
