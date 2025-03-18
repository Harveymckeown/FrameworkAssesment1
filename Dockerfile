#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FrameworkAssesment1.csproj", "."]
RUN dotnet restore "./FrameworkAssesment1.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "FrameworkAssesment1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FrameworkAssesment1.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Install Chrome
RUN apt-get update && apt-get install -y wget gnupg
RUN wget -q -O - https://dl.google.com/linux/linux_signing_key.pub | apt-key add -
RUN sh -c 'echo "deb [arch=amd64] https://dl.google.com/linux/chrome/deb/ stable main" >> /etc/apt/sources.list.d/google-chrome.list'
RUN apt-get update && apt-get install -y google-chrome-stable

# Install Firefox
RUN apt-get update && apt-get install -y firefox

# Install Edge
RUN wget https://packages.microsoft.com/keys/microsoft.asc -O- | apt-key add -
RUN sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/repos/edge stable main" > /etc/apt/sources.list.d/microsoft-edge.list'
RUN apt-get update && apt-get install -y microsoft-edge-stable

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FrameworkAssesment1.dll"]