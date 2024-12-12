🚀 Dockerization and Deployment of c_soap
This repository contains the steps to Dockerize the c_soap application and instructions on how to push changes to GitHub.

📜 Contents
🔧 Prerequisites
🐳 Dockerization
🔗 Pushing Changes to GitHub
🛠️ Running the Application
🔧 Prerequisites
Before starting, ensure you have the following tools installed on your system:

Docker (to build and run containers)
Git (for version control)
Access to your GitHub repository.
🐳 Dockerization
Dockerization involves creating a containerized image to run the application.

1. Clone the Repository
First, clone the c_soap repository:

bash
Copiar código
git clone https://github.com/jeffdanurss/c_soap.git
cd c_soap
2. Create a Dockerfile
Create a Dockerfile in the root directory of the repository with the following content:

dockerfile
Copiar código
# Base image
FROM gcc:latest

# Set working directory
WORKDIR /app

# Copy source code into the container
COPY . .

# Compile the application
RUN make

# Command to run by default
CMD ["./c_soap"]
3. Build the Docker Image
Build the image with this command:

bash
Copiar código
docker build -t c_soap .
4. Run the Container
After building the image, run the container:

bash
Copiar código
docker run -it --rm c_soap
🔗 Pushing Changes to GitHub
If you make changes to the application or the Dockerfile, you can push them to GitHub using the following steps:

1. Configure Your Repository
Ensure your remote repository is configured:

bash
Copiar código
git remote add origin https://github.com/jeffdanurss/c_soap.git
2. Commit Your Changes
Stage and commit your changes:

bash
Copiar código
git add .
git commit -m "Dockerization of the application and Dockerfile configuration"
3. Push Changes
Push the changes to the remote repository:

bash
Copiar código
git push origin main
🛠️ Running the Application
Once Dockerized, you can run the application using Docker as shown earlier. If you need to expose ports or pass environment variables, you can do so with the following docker run command:

bash
Copiar código
docker run -it --rm -p <LOCAL_PORT>:<CONTAINER_PORT> c_soap
🛑 Important Notes
Common Errors:
Ensure you have the proper permissions in your environment to run Docker.

Optimizing the Dockerfile:
You can optimize the build process by removing unnecessary layers or using lighter base images.
