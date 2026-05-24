# Shiko Popular Courses Service

Microservice for tracking and displaying the most popular courses in the Shiko LMS platform.

## Features

- Track course clicks
- Fetch most popular courses
- REST API with ASP.NET Core Web API
- PostgreSQL database with Entity Framework Core
- Swagger/OpenAPI documentation
- Integration with Next.js frontend

---

# Tech Stack

- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- Swagger / OpenAPI
- Next.js frontend integration

---

# Endpoints

## GET /api/popular-courses

Returns the most popular courses based on click count.

### Example Response

```json
[
  {
    "id": "1e2908cf-e81c-4a29-84f6-c9f3f3ffe72b",
    "courseId": "1",
    "title": "Graphic Design",
    "description": "Creating Visual Content",
    "iconUrl": "/icons/popular-this-week/graphic-design.svg",
    "clickCount": 1,
    "lastClickedAt": "2026-05-24T17:22:43.10873Z"
  }
]
```

---

## POST /api/popular-courses/click

Tracks a course click.

### Example Request

```json
{
  "courseId": "1",
  "title": "Graphic Design",
  "description": "Creating Visual Content",
  "iconUrl": "/icons/popular-this-week/graphic-design.svg"
}
```

---

# Running Locally

## 1. Clone repository

```bash
git clone <repo-url>
```

---

## 2. Navigate to API project

```bash
cd Shiko.PopularCourses.Api
```

---

## 3. Configure database connection

Update `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=shiko_popular_courses_db;Username=YOUR_USERNAME;Password="
}
```

---

## 4. Run migrations

```bash
dotnet ef database update
```

---

## 5. Start API

```bash
dotnet run
```

---

# Swagger

Swagger UI is available at:

```txt
http://localhost:5287/swagger
```

---

# Frontend Integration

The frontend fetches popular courses from:

```txt
GET /api/popular-courses
```

Course clicks are tracked through:

```txt
POST /api/popular-courses/click
```

---

# Author

Developed as part of the EC Utbildning LMS group project.