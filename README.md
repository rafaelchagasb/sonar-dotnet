# sonar-dotnet

Steps

1 Add ProjectGUID to all projects (.NET) analyzed

2 Add dependencies in test projects 

    dotnet add package coverlet.msbuild
    dotnet add package coverlet.collector

3 Reference frontend project in solution

![sonar](https://user-images.githubusercontent.com/724699/65832434-119f3c00-e29a-11e9-92ff-471b1e59061f.png)
