Project Name:
MetaHeroes

Description:
MetaHeroes is a web application focused on managing hero information through a user-friendly interface. It incorporates a secure login system that restricts form access to authenticated users only. This security measure employs JWT (JSON Web Tokens).

Once logged in, users can submit hero data. This data is then sent to a custom API, which has been developed using ASP.NET Core. The API not only integrates the JWT system for enhanced security but also contains two xUnit tests to ensure the application's reliability and functionality.

The hero data entered in the form is transmitted and stored in a MySQL database. This database, along with the server, is set up and managed using WAMP (Windows, Apache, MySQL, PHP), providing a stable and secure environment for data handling.

Technologies Used:
Angular: For creating the interactive user interface.
ASP.NET Core: To construct a backend API.
JWT (JSON Web Tokens): Implemented for user authentication.
xUnit: Applied for unit testing.
MySQL: As the database system for storing hero information.
WAMP Server: Utilized for the local development environment, integrating Apache, MySQL, and PHP.
