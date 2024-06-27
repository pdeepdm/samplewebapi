# Use the official .NET SDK image to build and publish the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build


# Expose the port on which the app will run
EXPOSE 5000

USER root

# Set the working directory inside the container
WORKDIR /app

# set the host
ENV HOST=0.0.0.0

COPY Publish ./

ENTRYPOINT ["dotnet", "SampleWebApi.dll"]

