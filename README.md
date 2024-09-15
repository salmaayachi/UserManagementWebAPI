# User Management Web API with ASP.NET Core and MySQL

This project is a simple User Management system built with ASP.NET Core Web API and MySQL. It includes a front-end interface using HTML and JavaScript for interacting with the API to perform CRUD (Create, Read, Update, Delete) operations on user data.

## Features
- **API**: ASP.NET Core Web API with Entity Framework Core
- **Database**: MySQL hosted on alwaysdata.com
- **CRUD Operations**: Create, read, update, and delete users
- **Front-End**: HTML + JavaScript for interacting with the API
- **Endpoints**: Accessible API endpoints for managing users

## Technologies Used
- ASP.NET Core
- Entity Framework Core
- MySQL
- HTML, JavaScript (Fetch API)
- alwaysdata.com for MySQL hosting

## Getting Started

### Prerequisites
- .NET SDK installed (version 6.0 or higher)
- MySQL database (hosted on alwaysdata.com or locally)
- Visual Studio Code or any code editor of your choice
- Postman (optional, for testing API endpoints)

### Setup

1. **Clone the Repository**:
    ```bash
    git clone https://github.com/your-username/your-repo-name.git
    cd your-repo-name
    ```

2. **Run the API**:
    - Start the ASP.NET Core Web API:
    ```bash
    dotnet run
    ```
    - The API will run at `http://localhost:5089` (or another port if specified).

3. **Open the Front-End**:
    - Open the `index.html` file located in the `wwwroot` folder in your web browser. (http://localhost:5089/index.html)
    - Interact with the API using the forms and buttons provided in the front end.

### API Endpoints
- **GET /api/users**: Retrieve all users
- **GET /api/users/{id}**: Retrieve a user by ID
- **POST /api/users**: Create a new user
- **PUT /api/users/{id}**: Update an existing user
- **DELETE /api/users/{id}**: Delete a user

### Testing the API
- You can use Postman to test the API endpoints. Make sure to start the API (`dotnet run`) before testing.

### Troubleshooting
- **404 Not Found**: Ensure the API is running and the URL is correct.
- **CORS Errors**: Ensure CORS is enabled in `Program.cs` to allow cross-origin requests.
- **Database Connection Issues**: Double-check the connection string in `appsettings.json`.


