# Car Advisor

Car Advisor is a full-stack web application that helps users confidently shortlist cars based on their budget and preferences. Instead of manually comparing numerous vehicles, users provide a few simple preferences, and the application recommends the most suitable cars along with a match score and the reasons behind each recommendation.

---

## Problem Statement

Buying a car can be overwhelming because of the large number of makes, models, variants, and specifications available. This project simplifies the decision-making process by recommending the most suitable cars based on user preferences.

---

## Features

- Budget-based car recommendations
- Fuel type preference
- Transmission preference
- Body type preference
- Minimum safety rating filter
- Family size consideration
- Match score for every recommendation
- Recommendation reasons for every suggested car
- Clean and responsive user interface
- Docker support for one-command project setup

---

# Tech Stack

## Frontend

- Angular 18
- TypeScript
- SCSS
- Angular Forms
- HttpClient

## Backend

- ASP.NET Core 8 Web API
- Entity Framework Core
- SQLite

## Tools

- Docker
- Docker Compose
- Git
- GitHub
- GitHub Copilot
- ChatGPT

---

# Project Structure

```
CarAdvisor
│
├── backend
│   └── CarAdvisor.API
│       ├── Controllers
│       ├── DTOs
│       ├── Models
│       ├── Services
│       ├── Data
│       ├── Seed
│       └── Dockerfile
│
├── frontend
│   └── car-advisor-ui
│       ├── src
│       └── Dockerfile
│
├── docker-compose.yml
└── README.md
```

---

# Recommendation Logic

Each car is evaluated against the user's preferences.

The recommendation score is calculated using:

- Budget
- Fuel Type
- Transmission
- Body Type
- Minimum Safety Rating
- Family Size
- User Rating

The application ranks the cars based on the calculated score and returns the top recommendations along with explanations describing why each car matches the user's preferences.

---

# Running the Project

## Recommended (Docker)

Clone the repository.

```bash
git clone <repository-url>
cd CarAdvisor
```

Run the complete application using Docker Compose.

```bash
docker compose up --build
```

Frontend

```
http://localhost:4200
```

Backend API

```
http://localhost:5005
```

Swagger (Development Mode)

```
http://localhost:5005/swagger
```

---

## Manual Setup

### Backend

```bash
cd backend/CarAdvisor/CarAdvisor.API

dotnet restore

dotnet ef database update

dotnet run
```

### Frontend

```bash
cd frontend/car-advisor-ui

npm install

ng serve
```

Open

```
http://localhost:4200
```

---

# What I Built

I built a focused MVP that helps users move from uncertainty to a shortlist of recommended cars.

Users provide their preferences through a simple form, and the application evaluates the available cars using a rule-based recommendation algorithm. The highest matching cars are returned together with a match score and an explanation describing why each recommendation was made.

The emphasis was on solving the core user problem instead of building a large feature-rich automotive marketplace.

---

# What I Deliberately Cut

To stay within the assignment's time limit, I intentionally chose not to implement:

- User authentication
- Admin dashboard
- Car comparison feature
- Favorites or saved recommendations
- Detailed specification pages
- Advanced search and filtering
- Machine Learning recommendation engine
- Cloud deployment
- CI/CD pipeline

Instead, I focused on delivering a complete end-to-end recommendation experience.

---

# AI Tool Usage

GitHub Copilot and ChatGPT were actively used throughout the development process.

AI tools helped with:

- Angular component scaffolding
- UI improvements
- Boilerplate code generation
- Docker configuration
- General debugging
- Architecture discussions
- Development guidance

All AI-generated code was reviewed, modified, integrated, and tested before being committed.

---

# Challenges Faced

Some of the challenges encountered during development included:

- Designing a recommendation algorithm that remained simple yet useful
- Connecting Angular and ASP.NET Core through CORS
- Configuring Docker for both frontend and backend
- Seeding the SQLite database automatically
- Balancing development speed with maintainable code

---

# If I Had Another Four Hours

Given additional time, I would add:

- Smarter weighted recommendation algorithm
- Side-by-side car comparison
- Search and advanced filtering
- Pagination
- Better analytics and recommendation insights
- Real vehicle images
- Unit and integration tests
- Cloud deployment (Azure, Render or AWS)
- User authentication

---

# Future Improvements

- AI-generated recommendation summaries
- Recommendation history
- Review sentiment analysis
- Personalized recommendations
- Brand-wise filtering
- Performance optimizations
- Improved mobile responsiveness

# Author

Developed as part of a Full-Stack Engineering Assessment using Angular 18, ASP.NET Core 8 Web API, Entity Framework Core, SQLite, Docker, and Docker Compose.
