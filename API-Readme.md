# ASP.NET Core API

- WebApplication class
	- Provides Hosting Env. For ASP.NET Core Apps
	- Contracts
		- IHostingEnvironment
			- Manages Host Based Object model for Services, Middlewares.
		- IConfiguration
			- USed to Read the appSettings.json
			-  The 'appSettings.josn' file exist in ASP.NET Core App. THis contains following
				- Connection String to DB, to Distributed Cache
				- JSON token Secret Keys
				- Logging Configuration
		- IServiceCollection
			- Represents the Dependency Injetion Container
			- USed to Register all Application Required Services in DI Container, e.g. Data Access, Session, Caching, etc.
			- The 'ServiceDescriptor' class is used by the IServiceCollection to manage the 'Lifetime' of service instance
				- Singleton
					- Object is live throughout the lifecyle of the application
						- Logging, Caching, etc.
					- AddSingleton()
				- Scopped
					- Object is live for specific session
						- Data Access
					- AddScopped()
				- Transient
					- Object is live only for a specific request for execution
						- An instance of utility class which will be used only for a specific requet e.g. ColletionUtilities 
					- AddTransient()
		- IApplicationBuilder
			- Used to Register MIddleware classes into the HTTP-Request Pipeline
				- IMiddleware
				- The 'Middleware' class that is used to define a Middleware
- Controller Class
	- This is the Actual Resource that is requested by making HTTP REquest
	- ControllerBase
		- Base class for API Controller
		- Methods and properties for HTTP Request and Response
	- ApiControllerAttribute class
		- Used to Read Request Body for Http POST and PUT Method and map that data from body to POST and PUT methods' input parameters of API Controller class
	- RouteAttribute class
		- MAp the HTTP Request URL to the controller
			- e.g.
				- https://MyServer/MyApp/MyCtrl, and the request is HTTP POST
		- This is executed depending on The 'Route' Middleware
				- BAsed on the Request for Controller, the MyCtrl Controller will be executed by Invoking its HTTP POST Action Method, because the Request for URL is HTTP POST 
	- HttpGetAttribute class
		- FOr Http Get MEthod Invocation
	- HttpPostAttribute class
		- For Http POST MEthod Invocation
	- HttpPutAttribute class
		- For Http PUT MEthod Invocation
	- HttpDeleteAttribue class
		- For Http DELETE MEthod Invocation
	- The IActionResult Interface contract for Response
		- OkResult class, Status 200
		- OkObjectResult class , Status 200 with JSON Data as Response
		- NotFoundResult, ConflictResult, etc.

- The JSON Serialization Format
	- COnfigure the API COntroller to Serilize the JSOn Response in CamelCase (Default)	to PAscal Case
````csharp

builder.Services.AddControllers() // Configure the Response as Pascal Case instead of Camel Case
      .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null) ;
````


# API Design Guidelines

1. Validate each input received by the API
2. The Validation can be managed using following
	- Model Data Validations
		- Validate the 'Model' object received using POST and PUT method
			- The Data Annotations, those are rules defined to validate each property of the Model/Entity class
				- System.ComponentModel.DataAnnotations
					- ValidattionAttribute class
						- RequiredAttribute
						- StringLengthAttribute
						- CompareAttribute
						- ... and many more
			- Use the 'ModelState' property of 'ControllerBase' class of the type ModelStateDictionary class to validate each property from the Entity class 
				- ModelState.IsValid
			- Create a Custom Data Annotation Validator to define a custom Validation
				- Derive class from ValidationAttribute and override its 'IsValid()' method 
	- Process Validations


# ASP.NET Core Action Filters

- ***** IMportant
	- Action Filters are only valid for MVC and API.
	- Action Filters will not execute for Razor Veiws
- Note
	- If using a Single ASP.NET Core App with Razor Veiws, MVC, and API then put all global logic at application level in Middlewares
	- If still wants to use Action Filters then do not register then in Global Scope, instead use them at Controller level (or at action level)
	- Type of Filters
		- IActionFilter
			- AuthenticationFilter (Managed using Middlewares)
			- AuthorizationFilter (Managed using Middlewares)
			- ResourceFilter (MVC Views)
			- ActionFilter (Custom Filter)
			- ExceptionFilter (STandard Exception Handling for MVC and API Controllers)
			- ResultFilter (Result Generation from MVC and API Controllers)
	- Execution Order
		- When an Action Hit 	
			- OnActionExecuting(), Global Scope 
			- OnActionExecuting(), Controller Scope 
			- OnActionExecuting(), Action Scope 
		- When an action is Completed its execution
			- OnActionExecuted(), Action Scope
			- OnActionExecuted(), Controller Scope
			- OnActionExecuted(), Global Scope

# Creation of Middlewares

- Create a class that is construtor injected using the 'RequestDelegate' delegate
	- RequestDelegate, a .NET Delegate that accepts the 'HttpContext' as input parameter and return Task (aka void) as output parameter	 
		- HttpContext, this is a HTTP Channel that contains HttpRequest and HttpResponse
		- The RequestDelegate will execute the current Middeware and once done, it will inform to the HttpContext to movew next middleware in the pipeline
	- The class MUST implement the 'InvokeAsync(HttpContext ctx)' method. This method contains logic for the middleware  
- Create an Extension method class
	- THe extension method MUST access the first parameter as 'IApplicationBuilder'
	- IApplicationBuilder, interface is used to build the HttpPipeline and hence this alos configure Middleware(s) in the request pipeline
		- This interface has the 'Use(Func<RequestDelegate,RequestDelegate>)' method that is used  to define Middleware execution in Pipeline
	- This extension method will be used to register our class as Custom Middleware in the request Pipeline 
````html 
	- There exist a 'UseMiddeware<T>()' method
````		
		- The 'T' is the Custom Middleware class that has the RequestDelegate injected to it using the Constructor Ijection 


# ASP.NET Core Identity for APIs
````html

- Microsoft.AspNetCore.Identity
	- Authentication and Authorization Services
		- AddAuthentication()
		- AddAuthorization()
	-  Authentication and Authorization Middlewares
		- UseAuthentication()
		- UseAuthorization()

- Microsoft.AspNetCore.Identity.EntiryFrameworkCore
	- Data Access Layer for Identity
		- IdentityDbContext
			- Manages Connection to Identity Database and mapping with ASP.NET Core Identity Tables
			- IdentityUser and IdentityRole mapping classes with ASP.NET Core Identity Tables 
			- IdentityUser mapped with AspNetUsers table
			- IdentityRole mapped with AspNetRoles table
- Microsoft.AspNetCore.Identity.UI
	- UserManager<IdentityUser> 
	- RoleManager<IdentityRole>
- Microsoft.AspNetCore.Authentication.JwtBearer
	- System.IdentityModel.Tokens.Jwt 

````

# API Deployment for Production

- On-Premise Deployment
	- Configure the Appliction Server aka web Server
		- Create a Web Site as No-Managed Code
		- Publish the ASP.NET Core Application on IIS in the website
			- This will create web.config file 
- Cloud i.e. Azure Deployment
	- First Deploye Database
	- Modify the App Connection String
	- Publis App on Cloud
		