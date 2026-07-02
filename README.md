# Car Advisor

Car Advisor is a full-stack web application that helps users discover the most suitable car based on their budget and preferences. Instead of browsing through hundreds of vehicles, users answer a few simple questions, and the application recommends the best matching cars along with the reasons for each recommendation.

## Problem Statement

Car buyers often struggle to compare numerous makes, models, variants, and specifications. This project simplifies the decision-making process by providing personalized recommendations based on user preferences.

## Features

* Budget-based car recommendations
* Fuel type selection
* Transmission preference
* Body type preference
* Minimum safety rating filter
* Family size consideration
* Match score for every recommendation
* Explanation of why each car was recommended
* Clean and responsive user interface

## Tech Stack

### Frontend

* Angular 18
* TypeScript
* SCSS
* Angular Forms
* HttpClient

### Backend

* .NET 8 Web API
* Entity Framework Core
* SQLite

## Project Structure

```
CarAdvisor/
│
├── backend/
│   ├── Controllers/
│   ├── Models/
│   ├── DTOs/
│   ├── Services/
│   ├── Data/
│   └── Seed/
│
├── frontend/
│   ├── components/
│   ├── models/
│   ├── services/
│   └── assets/
│
└── README.md
```

## Recommendation Logic

Each car is evaluated against the user's preferences and assigned a match score based on factors such as:

* Budget
* Fuel type
* Transmission
* Body type
* Safety rating
* Family size
* User rating

The highest-scoring cars are returned as recommendations, along with the reasons they were selected.

## Running the Project

### Backend

1. Navigate to the backend project.

```
cd backend
```

2. Restore packages.

```
dotnet restore
```

3. Apply migrations.

```
Update-Database
```

or

```
dotnet ef database update
```

4. Run the API.

```
dotnet run
```

Swagger will be available after the application starts.

---

### Frontend

1. Navigate to the frontend project.

```
cd frontend/car-advisor-ui
```

2. Install dependencies.

```
npm install
```

3. Start the Angular application.

```
ng serve
```

Open:

```
http://localhost:4200
```

> Ensure the backend API is running before using the application.

## What I Built

I built a focused MVP that helps users move from uncertainty to a shortlist of recommended cars. The application collects a user's preferences, evaluates the available cars using a scoring algorithm, and returns the best matches together with an explanation of why they were recommended.

## What I Deliberately Cut

To stay within the time constraint, I intentionally did not implement:

* User authentication
* Advanced filtering and sorting
* Car comparison page
* Favorites or saved recommendations
* Detailed car specification pages
* AI-powered natural language recommendations
* Production deployment and CI/CD

The focus was on delivering a complete end-to-end recommendation experience.

## AI Tool Usage

AI tools were used throughout the development process to accelerate implementation and improve productivity.

They were particularly helpful for:

* Angular component scaffolding
* UI refinement
* Boilerplate code generation
* General development guidance

All generated code was reviewed, modified, integrated, and tested before being committed.

## Challenges

* Designing a recommendation algorithm that balances simplicity and usefulness.
* Connecting Angular and .NET with proper CORS configuration.
* Creating a reusable component structure while staying within the project time limit.

## If I Had Four More Hours

I would add:

* Smarter recommendation scoring with weighted preferences
* Side-by-side car comparison
* Search and filtering
* Pagination
* Better analytics and insights
* Improved visuals with real vehicle images
* Unit and integration tests
* Docker support and cloud deployment

## Future Improvements

* AI-generated recommendation summaries
* Personalized recommendation history
* Advanced filtering by brand, mileage, and price
* Review sentiment analysis
* Performance optimizations
* Responsive improvements for mobile devices

## Author

Developed as part of a full-stack engineering assessment using Angular 20, .NET 8, Entity Framework Core, and SQLite.
