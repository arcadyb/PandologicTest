# PandologicTest
 REST WEB Api server built on Net 5.0 EF 5.0.17 as required

 Frontend built on Vite + Vue 3.2 

 Application uses SQLite DB built from model classes

 using code Code First based approach :

 dotnet ef migrations add initial -o Data

 dotnet ef database update 
 
![image](https://user-images.githubusercontent.com/16181086/200172929-dd822bf5-a86d-4e8b-b93b-0d35fb5a8a9e.png)

Data seeded from code in JobsDbContext

![image](https://user-images.githubusercontent.com/16181086/200174288-c2bc3c8f-2b2a-4ce2-8f36-4da25cb9da58.png)



Debug/Run application

1. Open workspace in Visual Studio 2019/2022 
2. ![image](https://user-images.githubusercontent.com/16181086/200173455-4f66aabf-7b33-4de1-aac7-74a791f36196.png)


Result:



![image](https://user-images.githubusercontent.com/16181086/200173708-6fb68d28-4c69-4ce0-90f5-50db95e93ee9.png)


![image](https://user-images.githubusercontent.com/16181086/200173757-7e5d1cbe-a3e0-45ed-9b8b-78b85e1cd7b7.png)

Known issues:

 1.Data points for predicted views on chart cannot be make hollow

 2.Custom html tooltip not implemented
 
 3.Mocked xUnite Test on JobsController failed to create DBContext from DB file 
   due to relative path to DB in DBContext



