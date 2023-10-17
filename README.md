# 🌾Cropometer <sup><sub><sub>PROG 7312 ICE Task 3
A basic demonstration of ASP.NET Core (MVC) using crops.

>[!Note]
>This project relies on an online SQL database hosted on Azure and will not function correctly if taken offline.

>[!Important]
>A connection string for the database is included within the app and should work while valid.

## 👨‍💻Team
|Jishen Harilal|Cayde Brummer|Evan Teague|
|:-:|:-:|:-:|
|ST10083511|ST10083661|ST10083451|

## 💁About
Cropometer provides a simple, easy to use platform for logging crop data, whilst providing basic real-time statistics.  
All data is saved to the cloud in an online SQL database hosted on Azure.

## 💻Compilation
Clone this repo in Visual Studio and invoke the .sln
```
https://github.com/MrMatrix2108/Cropometer.git
```
## 🧰Advanced
If the database is no longer hosted, you can create you own using the following SQL scripts.
>You will also need to change the connection string in `appsettings.json` and `Models/CropDatabaseContext.cs` when using your own database. 
```sql
-- Create a new database
CREATE DATABASE CropDatabase;

-- Use the newly created database
USE CropDatabase;

-- Create a table to store crop information
CREATE TABLE Crops (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CropName NVARCHAR(255),
    CropYield INT,
    CropExpenses FLOAT,
    CropIncome FLOAT
);
```
