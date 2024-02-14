# CS-EntityFramework-SimpleAPI
This project is a simple CRUD to learn how <b>Entity Framework<b> works

## This project allows performing CRUD actions through an API using the Entity Framework
![image](https://github.com/OscarChavez99/CS-EntityFramework-SimpleAPI/assets/80979314/448e95b0-a74f-420c-970e-4146bfb22d9c)

## 1-To run the project pt.1
1. Open a database management tool and create a database (I named it as: "cs_simple_apis") <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/5cd0af97-76cf-474a-88e0-9b40e06f1a32)
2. Create a table named <b>students<b> with the following structure <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/bf2ed021-21a2-4f15-b88b-c4f3f6da986c)

## 2-To run the project pt.2
1. Open "CS-EntityFramework-SimpleAPI.sln"
2. Go to the 'appsettings.json' file <br> ![image](https://github.com/OscarChavez99/CS-EntityFramework-SimpleAPI/assets/80979314/486fa631-7a80-4017-b274-64e352bb2f67)
3. If your database is NOT hosted on "localhost", modify the "DataSource" field <br> ![image](https://github.com/OscarChavez99/CS-EntityFramework-SimpleAPI/assets/80979314/65175464-43df-4019-bc52-93308d41dca9)
4. If you named your database differently, modify it in the "Database" field <br> ![image](https://github.com/OscarChavez99/CS-EntityFramework-SimpleAPI/assets/80979314/0fa7316d-ad44-4cd4-a9f1-596ec11dbbce)
5. Modify the "User" and "Password" fields if needed

## 3-How to use the program?
- Run the program <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/1cc6b6b6-9b15-4cee-bd00-06f67b587d37)

### 3.1 POST (insert) student
1. Click on "POST" and then on "Try it out" <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/c4f2b6e0-a554-425e-b8ae-1273ba2d38d1)
2. Enter the data you want to insert and then click on "Execute" <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/80f491b9-4357-4561-92f9-600bc2f59f48)

### 3.2 PUT (update) student
1. Click on "PUT" then on "Try it out" <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/61170bda-aef7-4467-9513-e3a84271373c)
2. Enter the user data to modify (remember to enter an existing ID) and click on "Execute" <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/b6d27117-fde9-4b16-9147-4295795c3631)

### 3.3 GetAllStudents (select all)
1. Click on "GetAllStudents" then on "Try it out" <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/8a5a3160-7852-4485-bfdb-e1797f78e50b)
2. Click on "Execute," and you will be able to observe all your records <br> ![image](https://github.com/OscarChavez99/CS-EntityFramework-SimpleAPI/assets/80979314/82186c3d-b16e-4019-ac95-4de9424d8de2)

### 3.4 GetStudentById (select)
1. Click on "GetStudentById" then on "Try it out" <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/5dc5fc7b-08a4-40c2-8f80-dc6aa9dd3e83)
2. Enter an existing ID then click on "Execute" <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/e7db64b0-43e7-4723-b0bb-2fac43997b57)
3. You will be able to observe your record <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/e7525d20-bc06-40b3-b267-3a8eeb220e88)

### 3.5 GetStudentsFilterName (select)
1. Click on "GetStudentsFilterName" then on "Try it out" <br> ![image](https://github.com/OscarChavez99/CS-EntityFramework-SimpleAPI/assets/80979314/2ae324b2-d23c-4f38-a539-2dc9664ea8d1)
2. Enter a string and click on "Execute" <br> ![image](https://github.com/OscarChavez99/CS-EntityFramework-SimpleAPI/assets/80979314/d7999717-2901-4c0c-8f4c-ec088b158706)
3. Observe the record(s) containing the specified string <br> ![image](https://github.com/OscarChavez99/CS-EntityFramework-SimpleAPI/assets/80979314/2fe3bb41-7812-4e3f-9c6f-399e2f8c0eb1)

### 3.6 Delete student
1. Click on "Delete" then on "Try it out" <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/45c52dcb-551f-4e13-8721-d7ca593e4c89)
2. Enter an existing ID then click on "Execute" <br> ![image](https://github.com/OscarChavez99/CS-DependencyInjected-SimpleAPI/assets/80979314/8ae048cd-aaca-4d4d-80de-83b37b2a0787)
