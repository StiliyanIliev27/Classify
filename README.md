# Classical Music Library 🎻

The Classical Music Library is a web application built with ASP.NET MVC and SQL Server, designed to provide a platform for users to explore and contribute to a curated collection of classical music composers and their renowned pieces. Whether you're passionate about classical music or interested in expanding your knowledge, our application offers a seamless experience to discover and contribute to the rich history of classical compositions.

![Library Preview](./assets/screenshots/home.png)

## 💡 Features

- **Browse Composers and Pieces**: Explore a curated collection of classical music composers and their famous pieces.
- **Upload New Pieces**: Users can contribute by uploading new pieces of classical music along with their audio files.
- **Search Functionality**: Easily search for composers or pieces using the search bar.
- **Responsive Design**: The application is designed to be responsive and accessible across different devices.

## 🛠 Technologies Used

- **Frontend**: HTML, CSS, JavaScript
- **Backend**: ASP.NET MVC
- **Database**: SQL Server (Entity Framework for data access)
- **File Uploads**: ASP.NET MVC handling with EF

## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites

- Visual Studio (with ASP.NET MVC support)
- SQL Server (Local instance or connection string for a remote database)

## ⚙️ Installation

1. Clone the repository: `git clone https://github.com/yourusername/Classify.git`
2. Navigate to the project directory: `cd Classify`
3. Open the solution file in Visual Studio.
4. Build the solution.
5. Configure the database connection in `appsettings.json`.
6. Database Setup
  Ensure your SQL Server instance is set up with the necessary database and tables. Use Entity Framework migrations to update the database schema as needed.
  Migration Commands:
      - `PM> Enable-Migrations`
      - `PM> Update-Database`
7. Run the application.

 ## ✏️ Contributing

Contributions are welcome! Please follow these guidelines:
- Fork the repository.
- Create a new branch: `git checkout -b feature-name`.
- Make your changes and commit them: `git commit -m 'Add feature'`.
- Push to the branch: `git push origin feature-name`.
- Submit a pull request.

## 📄 License

This project is licensed under the [MIT License](LICENSE).

## 💎 I hope you like it! 
