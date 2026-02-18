# ASP.NET Core Web API – User Management CRUD

This repository contains a simple and clean **ASP.NET Core Web API** that provides CRUD operations for managing users. It uses **Entity Framework Core**, **MySQL**, and includes Swagger for API testing. CORS is enabled for an Angular frontend running on `http://localhost:4200`.

---

## 🚀 Features

- Get all users  
- Get a user by ID  
- Create a new user  
- Update an existing user  
- Delete a user  
- MySQL database integration  
- Swagger UI for API testing  
- CORS enabled for Angular  

---

## 🛠️ Tech Stack

| Component | Technology |
|----------|------------|
| Backend Framework | ASP.NET Core Web API |
| ORM | Entity Framework Core |
| Database | MySQL |
| API Docs | Swagger / Swashbuckle |
| Frontend (allowed origin) | Angular (`localhost:4200`) |

---

## 📂 Project Structure
```
WebApplication1/
│
├── Controllers/
│   └── UsersController.cs
│
├── Models/
│   ├── Entities/
│   │   └── User.cs
│   ├── AddUserDto.cs
│   └── UpdateUserDto.cs
│
├── Data/
│   └── ApplicationDBContext.cs
│
├── Program.cs
└── appsettings.json
```

## API Endpoints

GET /api/users
Returns all users.

GET /api/users/{id}
Returns a single user by GUID.

POST /api/users
Creates a new user.
Body example:
```
{
  "firstName": "John",
  "lastName": "Doe",
  "email": "john@example.com",
  "password": "123456",
  "photoFileName": "profile.jpg"
}
```

PUT /api/users/{id}
Updates an existing user.

DELETE /api/users/{id}
Deletes a user by GUID.

## 🗄️ Database Configuration
Update your appsettings.json:
```
{
  "ConnectionStrings": {
	"DefaultConnection": "Server=localhost;Database=UserManagementDB;User=root;Password=yourpassword;"
  },
}	
```
## Swagger API
<img width="1829" height="451" alt="image" src="https://github.com/user-attachments/assets/c22720db-0389-44f1-b863-680d294f46e7" />


