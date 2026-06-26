# UniversityInfoApp

A cross-platform application built with **.NET MAUI** that allows users to search for universities by country. The application retrieves university information from the **Hipolabs Universities API** and displays the results in a user-friendly interface.

## Features

* Search universities by country name.
* Retrieve real-time data from a public REST API.
* Display a list of universities matching the entered country.
* Simple and responsive user interface.
* Cross-platform support with .NET MAUI.
* MVVM architecture for clean separation of concerns.

## Technologies

* .NET MAUI
* C#
* MVVM Pattern
* CommunityToolkit.Mvvm
* HttpClient
* System.Text.Json
* REST API

## API

The application uses the following public API:

```text
http://universities.hipolabs.com/search?country={country}
```

Example:

```text
http://universities.hipolabs.com/search?country=Saudi+Arabia
```

## Project Structure

```text
UniversityInfoApp
│
├── Models
├── Services
├── ViewModels
├── Views
└── Platforms
```

## How It Works

1. Enter a country name in the search box.
2. Click the **Search** button.
3. The application sends an HTTP GET request to the Universities API.
4. The JSON response is deserialized into model objects.
5. The list of universities is displayed on the screen.

## Getting Started

### Prerequisites

* Visual Studio 2022 or later
* .NET 9 SDK (or the version used by the project)
* .NET MAUI workload installed

### Run the Project

```bash
git clone https://github.com/<username>/UniversityInfoApp.git
cd UniversityInfoApp
dotnet build
dotnet maui run
```

## Architecture

The application follows the MVVM design pattern.

```text
View
   │
Binding
   │
ViewModel
   │
Service (HttpClient)
   │
REST API
```

## Future Improvements

* Search suggestions.
* Loading indicator while fetching data.
* Error handling for network failures.
* Offline caching of search results.
* Display university website links.
* Filter and sort search results.

## License

This project was developed for learning purposes and to demonstrate consuming REST APIs in .NET MAUI using the MVVM architecture.
