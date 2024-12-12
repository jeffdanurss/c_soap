# 🚀 Dockerization and Deployment of c_soap

This repository contains the steps to **Dockerize the c_soap application** and instructions on how to push changes to GitHub.

---

## 📜 Contents

1. [🔧 Prerequisites](#-prerequisites)  
2. [🐳 Dockerization](#-dockerization)  
3. [🔗 Pushing Changes to GitHub](#-pushing-changes-to-github)  
4. [🛠️ Running the Application](#-running-the-application)  

---

## 🔧 Prerequisites

Before starting, ensure you have the following tools installed on your system:

- **Docker** (to build and run containers)  
- **Git** (for version control)  
- Access to your GitHub repository.

---

## 🐳 Dockerization

Dockerization involves creating a containerized image to run the application.

### 1. Clone the Repository

First, clone the `c_soap` repository:

```bash
git clone https://github.com/jeffdanurss/c_soap.git
cd c_soap
```
## 2. Create a Dockerfile
Create a Dockerfile in the root directory of the repository with the following content:

dockerfile

```bash
# Consulte https://aka.ms/customizecontainer para aprender a personalizar su contenedor de depuración y cómo Visual Studio usa este Dockerfile para compilar sus imágenes para una depuración más rápida.

# Esta fase se usa cuando se ejecuta desde VS en modo rápido (valor predeterminado para la configuración de depuración)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# Esta fase se usa para compilar el proyecto de servicio
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["soap.csproj", "."]
RUN dotnet restore "./soap.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./soap.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Esta fase se usa para publicar el proyecto de servicio que se copiará en la fase final.
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./soap.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Esta fase se usa en producción o cuando se ejecuta desde VS en modo normal (valor predeterminado cuando no se usa la configuración de depuración)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "soap.dll"]
```

## 3. Build the Docker Image
Build the image with this command:

bash
Copiar código
```
docker build -t jeffdanurss/c_soap .
```
##4. Run the Container
After building the image, run the container:
```
docker run -it --rm c_soap
```
##🔗 Pushing Changes to GitHub
If you make changes to the application or the Dockerfile, you can push them to GitHub using the following steps:

1. Configure Your Repository
Ensure your remote repository is configured:
```
git remote add origin https://github.com/jeffdanurss/c_soap.git
```
2. Commit Your Changes
Stage and commit your changes:
```
git add .
git commit -m "Dockerization of the application and Dockerfile configuration"
```
3. Push Changes
Push the changes to the remote repository:
```
git push origin main
```
##🛠️ Running the Application
Once Dockerized, you can run the application using Docker as shown earlier. If you need to expose ports or pass environment variables, you can do so with the following docker run command:
```
docker run -it --rm -p <LOCAL_PORT>:<CONTAINER_PORT> c_soap
```
##🛑 Important Notes
Common Errors:
Ensure you have the proper permissions in your environment to run Docker.
