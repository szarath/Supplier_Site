# Supplier_Site
This is a 3 tier soluion. The front end is made using angular, Middle-tier is made using Asp.net Core Web API and the Databae is made using MS SQL.  

    Prerequisites
        Open project using Visual Studio
        Edit appsettings.json file where SupplierDB is edit the string to match your database connection string
        Run add-migration "your_initial_migraiton" in package manage console in visual studio
        Run update-database in package manage console in visual studio
        Next navigate to the Supplier_Site folder and using the command line run "Dotnet Run".
        
Running the "Dotnet Run" command will spin up the swagger on https://localhost:7257/swagger/index.html 
and at the same time spin up the angular app on https://localhost:7257/

Mentions There is no data present and you need to run the update-database for all the defualt values to be populated.

# Main page
![Main](https://user-images.githubusercontent.com/9131084/233798989-342ed115-be14-40b6-b570-cfb1410dc4a9.PNG)

# Get by ID
![Get by ID](https://user-images.githubusercontent.com/9131084/233799048-5c9a7bd1-9f87-4f09-ab40-b098965653a2.PNG)

# Get by Name
![Get by Name](https://user-images.githubusercontent.com/9131084/233799065-03c01fcb-8a13-4539-b4dc-96bf9d83c6db.PNG)

# Add 
![Add](https://user-images.githubusercontent.com/9131084/233799076-a5d89eb3-7dd4-428e-afb5-e5b7213ab1dd.PNG)

# Swagger
![Swagger](https://user-images.githubusercontent.com/9131084/233799087-2358c39d-3735-43fb-932a-2d2ea40be739.PNG)



