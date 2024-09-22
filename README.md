# ASP.NET Core 8 Web API using JWT

## Overview

**NETWebApiUsingJWT** is an ASP.NET Core 8 Web API that implements JWT (JSON Web Tokens) for secure user authentication and authorization. The API allows users to log in, validate their credentials, and retrieve a personalized book alertment list.

### Additional Project

This repository also includes an ASP.NET Core MVC project named **ConsumeJWTTokenFromWebAPI**, which provides a user interface to interact with the above API.

## Features

- **Web API**
  - User login
  - JWT-based authentication
  - Secure API endpoints for fetching user-specific book alertment list
- **MVC Project**
  - User-friendly UI for login
  - Display of the user's book alertment list
  - Integration with the JWT API

## Default User Credentials for Login

- **User ID**: `alpha`
- **Password**: `alpha@123`

## Technologies Used

- ASP.NET Core 8
- JWT for authentication
- Swagger for API documentation
- ASP.NET Core MVC for the user interface


### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/BhaktaRout038/NETWebApiUsingJWT.git
   cd NETWebApiUsingJWT
