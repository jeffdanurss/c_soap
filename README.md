# SOAP
This is a project that was developed with java with a Soap architecture.

## Description
This project shows the addition of two integer values ​​through postman.
It is a simple program to show how a program works in the programming language with an architecture style.

## Technologies Used
**Contains the Following**
- Visual Studio C# (most current version)
- Docker
- Webhook
- Postman

## Development Requirements
- **Docker Desktop** (if you want to run it in a container)
- **Visual Studio C#** (optional, but recommended)
- **Soap**(required and recommended)
- **GitHub Desktop** (if you want to clone and use the project)

```bash
https://www.docker.com/products/docker-desktop/
```

- **Docker hub** (if you want to clone and use the project)

```bash
https://hub.docker.com/layers/erickjrm/programsoap/latest/images/sha256-76c3272200d35a863fe9edd0ffeac9bd15438aff617c28a800e5cf646f124c9a?context=repo
```

## Instructions to run the project
## Steps to run
- **Step #1**
**Clone this repository**
If you have not yet cloned the repository, you can do so with the following link:

```bash
https://github.com/JosueRM2001/soap1.git
```
- **Step #2**
**Build the Docker image**

Run the following command, which will generate the image:

```bash
docker pull erickjrm/programsoap:latest
```

**Step #3**
**Run the url in postman:**

Then run the following command, in postman.

```bash
https://localhost:7259/Service.asmx/Sum
```

**Step #4**

Open Docker Desktop to see if the image was built correctly and send it to run to view it.

**Step #5**

**Access the application**: If it is running, you can access the application by navigating to the

following url in your web browser:

```bash
https://localhost:7259/Service.asmx
```
