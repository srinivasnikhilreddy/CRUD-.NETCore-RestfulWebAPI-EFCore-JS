# CRUD API Project - ASP.NET Core with SQL Server

## 📌 Project Overview
This project demonstrates a simple yet powerful ***CRUD (Create, Read, Update, Delete)*** API built with ***ASP.NET Core*** and connected to a ***SQL Server*** database. It exposes a ***RESTful API*** to manage student data and performs basic CRUD operations. The API uses ***Entity Framework Core (EF Core)*** for ORM (Object Relational Mapping) to interact with the database and supports robust querying capabilities.

The API follows modern development practices and is designed to scale effectively in a production environment, providing a strong foundation for more complex applications. Additionally, it features a JavaScript front-end to consume the API, making it a full-stack solution.


## ✨ Features
* ***Create***: Adds a new student record to the database.
* ***Read***: Retrieve all students or specific student by ID.
* ***Update***: Modify existing student records.
* ***Delete***: Remove a student record from the database.


 ## 🏗 Technologies Used

✅ ***ASP.NET Core***: A modern, high-performance framework used for building RESTful APIs with scalable and maintainable architecture.

✅ ***Entity Framework Core (EF Core)***: An ORM for data access that enables a smooth integration with SQL Server.

✅ ***SQL Server***: The relational database management system used for storing student data.

✅ ***Swagger/OpenAPI***: Used for generating API documentation and testing endpoints in an interactive interface.

✅ ***CORS***: Configured to handle cross-origin requests, enabling communication between the front-end and back-end, especially in separated development environments.

✅ ***JavaScript Front-End***: A simple JavaScript application (or integration) to interact with the API, demonstrating the client-side interaction with the API. data is being deisplayed in tabulator a powerful library in javascript.


## 🎯 Future Usecase and Enhancements
***1. Microservices Architecture:***
* Key for scalability, flexibility, and managing complex applications by breaking them into smaller, independent services. This is crucial for large-scale applications.
  
***2. CI/CD (Continuous Integration/Continuous Deployment):***
* Essential for automating testing and deployment, ensuring fast, reliable, and consistent releases, which is critical in modern development pipelines.
  
***3. Cloud-Native Development & Deployment:***
* Hosting on cloud platforms like AWS or Azure ensures high availability, scalability, and global accessibility, which is crucial for enterprise-level applications.
  
***4. Containerization with Docker & Kubernetes:***
* Docker ensures consistent deployment across environments, while Kubernetes allows seamless scaling and management, which is a standard practice in modern application development.
  
***5. GraphQL Integration:***
* Provides flexible, efficient data querying by allowing clients to request only the data they need, improving performance and user experience, which is becoming a preferred approach in modern APIs.

***6 Machine Learning & AI Integration:***
* Add AI features like student recommendations based on data, using ML.NET to integrate machine learning into the CRUD system.
  

## API Endpoints
### GET /api/Students/GetAllStudents
* Retrieves a list of all students in the database.
* Method: GET
* Response: A list of student objects.
  
![Image](https://github.com/user-attachments/assets/13ed5af6-6423-41b5-b0e9-97c195b6b2ec)


## POST /api/Students/SaveStudent
* Adds a new student record to the database.
* Method: POST
* Request Body:
* json:
  {
    "name": "John Doe",
    "dob": "1995-05-15T00:00:00",
    "gender": "Male",
    "progress": "Excellent",
    "rating": 5,
    "col": "Science",
    "car": "Tesla"
 }
* Response: 200 OK (indicating the student was successfully added).

![Image](https://github.com/user-attachments/assets/c0632e8c-0a88-4c25-80db-b4ad16c58a37)


### PUT /api/Students/UpdateStudent/{id}
* Updates an existing student's data.
* Method: PUT
* Parameters: id (path parameter, the unique student ID)
* Request Body: Same structure as the POST request.
* Response: 204 No Content (indicating the student was successfully updated).

![Image](https://github.com/user-attachments/assets/c0cd7892-95dd-4857-ac5d-7e89cee5e195)


### DELETE /api/Students/DeleteStudent/{id}
* Deletes a specific student by ID.
* Method: DELETE
* Parameters: id (path parameter, the unique student ID)
* Response: 204 No Content (indicating the student was successfully deleted).

![Image](https://github.com/user-attachments/assets/faa87191-2f4e-462a-9e3b-7a198b60dbfb)



### Finally

![Image](https://github.com/user-attachments/assets/ee346335-1d37-4f0c-b928-4fee401d7731)


### DATABASE (students table)

![Image](https://github.com/user-attachments/assets/8c72b90e-7b5f-4e04-abc7-afb157a43191)




