# SVT Robotics - .NET core Take Home Recruiting Assessment Solution

### Instructions for Running & Testing the API

1. API is built using **Visual Studio 2022 with .NET 6 (C#10)**
2. Open Visual Studio and build solution
3. Hit 'F5' to run the application
4. Browse **`https://localhost:5001/swagger`** to access Swagger definition of the API
5. The API is accessible as **`https://localhost:5001/api/robots/closest/`** or **`http://localhost:5000/api/robots/closest/`**
6. Use either Swagger or Postman to test the API output



### Improvements - Next steps

1. Enough comments can be added in the code, where appropriate
2. We Can use logging library - depening upong how the API is being hosted, we can use corresponding logging framework such as Serilog with SEQ/Kibanna etc.
3. We Can use Polly library to make HTTP calls fault tolerant 
4. We can utilize Async streams if Robots count is going to be really huge
5. We can drive the robots API url from configuration
6. If the API is being containerized, we can add docker related configuration files.
