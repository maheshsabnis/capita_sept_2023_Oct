# C# Programming Language
	- Type Systeme with Support for Conversion
		- Value Types
			- Numeric
				- byte (1),short(2),int(4),long(8)
				- float(4), double(8)
				- decimal(16)
			- Boolean
				- bool(1)
			- Character
				- char(2)
			- Nullable Representation for type
				- Establish a bridge between C# code and database column type definitions to prevent runt-time exception
				- Value Types can be nullable
					- int? x;
						- x can have null value
		- Reference Types
			- String
				- Class for string operation
				- C# 9.0+ as nullable string
					- string? str; 
			- Collections
			- Delegates and Events
			- Classs
				- Foundation of OOPs
					- Class contains Members
						- Data Members, fields
						- Properties
						- methods
						- events
					- Access Speicfiers
						- private (default for Class members)
						- public, accessible everywhere
						- protected, accessible only in derived class
						- internal, default for class, accessible with a namespace in assembly
							- The namespace is collection of classes
						- protected internal
							- Accessible with a namespace in all derived classed also derived classed in other assembly
						- Access Modifiers
							- Define a behavior of class and its members
							- abstract
								- When applied on class, it cannot be instantiated
								- When applied on methods, the methos must be overriden in derived class
							- sealed
								- When applied on class, it cannot be derived
								- When applied on method, it canot be overriden		- static
								- The Class members are directly accessible w/o instance
							- virtual
								- Used to define a method with a default implmentation, it many be overriden by method in derived class or can be used as it is 
							- override
								- Used to override an abstract and vitrual methods 
				- Beginning of Domain-Driven-Development
					- Class 
						- Class with public properties only
							- An Entity class /  DTO
						- Class with Logic Method known as Business class or Domain class
					- Make sure that the class has all method targetted or scope to a specfic responsiblility (Single-Responsibility-Principal)
						- e.g. If created a class for Employee Opetrations, then each method of the class MUST contains logic around employee operations e.g. Read/Write		
				- For a method each value type paramerter will be having values stored in differnt memory locations, pass by value
					- For reference pass used 'ref' or 'out'
						- the 'ref' must be having initial values before passing to method
						- the 'out' must change values inside the method, the caller need not have an initial value for the 'out' variable 




			- Records (New in C# 10)
			- Interface
# C# Project with .NET 6+
	- Implict Main() method
	- Microsoft.NETCore.App
		- An assembly containing all Standard .NET Libraries those are used tobuild and run the application 
	- Single File Publish with The Compression of dependencies for XCopy or easy deployment

# Inheritance
	- A Class can be derived from 'ONLY-ONE-BASE' class
	- No Multiple inheritance is supported in C#

	- A base class has only one derived class, known as , Single Inheritence
	- A base class has multiple derived classes as same level, knows as, hierarchical Inheritance
	- A derive class act as a base class for further derived classes, known as, multi-level inheritance
# Polymorphism
	- Create an Abstratc class
		- A Plan for Expected Implementation
		- Techincal Specification w.r.t.C#
			- The 'abstract' keyword to declare the abstract class 
			- This cannot be instantiated
			- This MUST be derived
			- This can contain 'virtual' methods
				- These methods can contain default implementation
				- The derived class can use this implementation as it it w/o overriding these methods or derived can class override these methods and can add new implementation for it
			- This can contain 'abstract' method
				- These methods does not have any implementation
				- These methods 'MUST BE OVERRIDEN' by the derived class
				- If the derived class is not overriding all abstract methods of abstract base then the derived class MUST be made as abstract class
	- Compile Time Polymorphism
		- An idea to provide differewnt implmentation for abstract and virtual methods of base class in the derived class as per the requiremenets
		- The Base class is instantiated using its derive class to access specific behavior defined in the derived class implementation
	- Runtime aka Dynamic Polymorphism
		- In this case the Runtime accepts an abstract class type and then has to check the actual derived type from the abstract class and invoke the implementation from the derived type to execute it
		- Runtime Replaces the Abstract class type to its Derived Type at runt time, this is known as 'Liskov Substitution Principal'

# In-Memory Data Store
- System.Collections
	- IEnumerable data storage
		- A Data Structure that will store data in well-organized and read/write friendly manner
	- ArrayList, Stack, Queue, SortedList, etc.
		- Each entry in collection is stored as 'Object'	
		- Each entry in collection is 'Boxed', means the type of data and actual data will be stored in the collection
		- To Read data from the Object, the casting is mandatory
			- First Check the Type,First  CPU Cycle
			- Read data from it, Second CPU Cycle 

- System.Collections.Generic
	- Generics
		- The Template, which represents a standard Data Structure to store data of any .NET type
````csharp
 class MyCollection<T> 
 {....}
````
		- The 'T' is the template, that represent the .NET Type
````csharp
		MyCollection<int> intColl = new MyCollection<int>(); 
		MyCollection<string> strColl = new MyCollection<string>();
		MyCollection<Employee> empColl = new MyCollection<Employee>();

````
		- The 'intColl', is an interger copy of the MyCollection class in Memory and so on. The inColl will use all behavior of MyCollection class only for 'int' datatype
		- Define once and uses its In-Memory Binary copy to store data of any .NET Type

		- Generics
			- Class
				- List<T>, Stack<T>, LinkedList<T>, etc.
				- KeyValuePair<T,U>
					- T is Key
					- U is Value
				- Dictionary<K,V>
					- K: Generally a string, but can be any type of Object
					- V: May be a Colete Collection
			- Interface
				- IEnumerable<T>, IList<T>, IDictionary<K,V>, etc.
			- Member
			- Event and Delegate
	- Best Practices
		- WHile defining our own generic types make sure that use the 'Generic Constraints'
			- This will restrict the type for 'T' and hence avoid the misuse of T parameter 
	- Collection Popular Methods
		- Clone(), Copy(), Concatinate(), etc.
# Sealed class
	- The 'sealed' keyword to prevent the class from getting extended
	- Advantage
		- All behaviors of class as final and they are intended to be used as- it-is
		- The Funcaiotnality is prevented from getting overriden so its won't be intensionally misused
		- Most of the Third-Party uses this 
	- Extension Methods
		- USed to Extend Standard .NET or User defined sealed class w/o modifying or deriving from it
		- Rules
			- The class that contains logic for Extension method 'MUST be Static'
			- The Method 'MUST be Static'
			- The 'First Parameter' of the method 'MUST be "this" referred reference' of the class (or interface) for which the extension method is written 
	
# Interfaces
- A Type that contains method definitions and is implemented by a class to provide actual logic for each method in the interface
- A Class implements interface and hence MUST implement all method of interface, if not then compiler will generate error
- A Class can implement Multiple Interfaces (BUT this is not multiple inheritence)
	- Class implement Interface 'Implicitly'
		- The class is owner of methods from interface along with interface
		- Interface implemented Methods are accessible using class instance as well as interface reference
	- Class can implement Interface 'Explicitly'
		- Since a class can implement multiple interfaces, it may happen that these interface have same method with same signeture
		- In this case to provde different implementations for methods in interfaces, the class MUST implement methods 'explicitly'
		- In this case, although class provides implementation for methods (logic), these methods  are own by respective interface and will always be acceesible using interface reference
			- Polymorphism using interfaces

# Delegate and Event
- Delegate
	- A Type that is used to 'Invoke a method with its reference'
	- Rules
		- To invoke a method using delegate the signeture of method and delegate must match
		- Delegate is a Type 'System.Delegate' and used using the 'delegate' keyword
		- Delegate can also contain a method implementation in it without explicitly defining a method. This is known as 'Anonymous Method (C# 2.0)'
		- Delegate can be passed as input parameter to a method
		- If a method is accepting delegate as input parameter, then we can pass 'Lambda Expression' as an input parameter to the method
			-  Lambda Expression: This is an implementation which is directly eabstracted by the delegate
				- Syntax
					- DoOperation(x=>x+10)
					- '=>' called as 'goes into a method and returns'
		
- Event
	- A Special type of Delegate that is raised based on Condition
	- Event is always declared using Delegate
	- Event is responsible to invoke a method which contains logic for Notification
	- Event is always declared inside the class
	- The delegate which is used to define an event MUST have return type as void. This is because the event does not return any value to client


# Language Integrated Query (LINQ)
- Introduced with .NET 3.5 and C# 3.0
- Uses Extension Methods and Lambda Expressions extensively
	- Extension Method are utilities
		- Where(), Select(), Group(), OrderBy(), etc.
	- System.Core
		- OLinq, LINQ to Object
		- XLinq, LINQ to XML
		- DLinq, LINQ to Data
			- Enhanced to EntityFramework 
- Inperative Queries those are language agonostic
	- Keywords
		- select, where, order, by, descending, group, etc. 	


# Task Parallel Library .NET Framework 4.0
- TPL is standard for All next release of .NET Frwk and Foundation for Cross-Platform .NET (.NET Core for all versions and .NET 5 onwards)
- System.Thread.Task
	- Parallel
		- For()
			- Collection Reading on Seperate Threads 
		- ForEach()
			- Same as For() with Iteration 
		- Invoke() 
			- USed to Invoke Multiple Methods using 'Action' delegate so that all methods will be executed parallelly
	- Task
		- Task Non Generic
			- Unit of Async Operations
			- Start and execute a method on Thread but does not return anything 
		- Task<T>
			- Unit of Async Operation
			- Execute a method on Thread and return T as Result
			- Methods
				- StartNew
				- Run
				- Wait(), WaitAny(), WaitAll()
				- ContinueWith()
					- Executes Multiple Tasks in Sequence
					- Result of Previous Task is an put to next Task
		- .NET Framework 4.5+ (C# 4.0+) and in Cros-Platform .NET
			- Framework Managed Async Methods
				- Method that returns 'Task' object executed Asynchronously
				- Naming Policy for Async Method
					- XXXXAsync(), XXXX is method Name
						- e.g.
							- OpenAsync(), ReadFileAsync(), WriteFileAsync(), etc.
				- The 'async' and 'await' keywords
					- If the Method returns a Task Object, means its has some asynchrnous executing operations, 
					- Use 'async' keyword to define such method
					- Use 'await' keyword to make an async operation class from 'async' method
````csharp
	public async Task<string> ReadDataAsync()
	{
		string data1 = await File1.ReadAsync();
		string data2 = await File2.ReadAsync();
		string data = data1+data2;
		return data;
	}
````
					- The async and await will inform to dotnet.exe that the ReadDataAsync() method will be executed asynchronously on seperate thread and will return a 'string' after an async operation is over  
		- The 'Task' base Asynchronous programming allowed to have the code execution in no-block model 

		- We can easliy COntinue from Previous Task to Next Task, this will be handled by .NET execution engine for managing communciation across various Tasks
			- Continue W/o any input from Previous Task to Next Task
			- Continue with output of Previous Task to Next Task

# COncurrent Data STructures

- This is offered to stored data in memory in such a way that, the data can be accessible across multiple threads

- ConcuretBag<T>, Just like List
- ConcurrentStack<T>
- ConcurrentDictionary<T,U>
- ConcurrentQueue<T>


# Entity Framework Core [EF Core]

- Database First: When the database is already in production-ready state
	- Generate Entities from Tables
	- Perform CRUD OPerations
- Code-First: 
	- Design a Conceptual Model
	- Establish Relationships across These models
	- Generate Database and Tables with Constraints 
	- Perform CRUD OPerations

- Set of Packages
	- Microsoft.EntityFrameworkCore 
		- Foundation for EF Core
		- Classes
			- DbContext
			- DbSet<T>
	- Microsoft.EntityFrameworkCore.SqlServer 
		- Used to Manage Conection with SQL Server Database
		- Manage the SQL DbTypes for Mapping with properties of the CLR Objects
	- Microsoft.EntityFrameworkCore.Relational
		- Manage the Relationships across Tables
			- One-to-Many
				- Foreign Key 
			- One-to-One
				- Reference Key based on Foreign Key 
			- Many-to-Many
				- Manage the Many-to-Many SQL Table that contains primary keys for tables having Many-to-Many relationships  
				- When Transactions (Insert) are performed on these tables, the Many-to-Many SQL Table will store Primary Keys of Both tables for setting Many-to-Many Relationships
	- Microsoft.EntityFrameworkCore.Design
		- USed for Helping to generate Entities from Tables
	- Microsoft.EntityFrameworkCore.Tools
		- USed for EF Core CLI

- DbContext class
	- Used to manage the Database Connection and Transactions
		- Managing Connection, is using SQL Server
			- USes the 'Microsoft.EntityFrameworkCore.SqlServer ' package and its 'UseSqlSever("DB-CONNECTION-STRING")' method
		- Transaction Method
			- SaveChanges(), the Synchronous Method
			- SaveChangesAsync(), the Asynchronous Method
	- Used to manage the Mapping with between CLR Class (Entity Class) and the Database Table using the DbSet<T>
		- DbSet<T>
			- The  'T' is Entity class
			- Cursor that repreents the Mapping Between Entity class and DB Table
			- Contains Methods for INsert, Delete, Find, etc.

- Pseduo Code for EF Core
- The DbContext instance is 'ctx'
- The Entity class is 'Employee'
- The DbSet<Employee> is 'Employees'


- REad All Records 
	- var emps = ctx.Employees.ToList(); / var emps = await ctx.Employees.ToListAsync();
		- For ToListAsync(), we need 'Microsoft.EntityFrameworkCore' namespace used in code file 	
- Read a Single Record using Primary Key
	- var emp = ctx.Employees.Find(EmpNo); /  var emp = await ctx.Employees.FindAsync(EmpNo);
		- The Table 'MUST' have a Primary Key
		
- Create a new single record (Insert)
	- CReate an instance of EMployee class and set its properties values
		- Employee emp = new Employee(){EmpNo=, EmpName= "",....}
	- Add this instance in the Employees DbSet
		- ctx.Employees.Add(emp); /  await ctx.Employees.AddAsync(emp);
	- Complete Transaction
		- ctx.SaveChanges(); / await ctx.SaveChangesAsync();

- Inserting multiple records
	- Create an Array (or any COllection) of Employee class with values e.g. employees
	- PAss this collection to AddRange()
		- ctx.Employees.AddRange(employees); / await ctx.Employees.AddRangeAsync(employee);
		- Complete Transaction
			- ctx.SaveChanges(); / await ctx.SaveChangesAsync();

- Update Record
	- Search record based on Primary Key
	- If found then Update its property values
	- Complete Transaction
- Delete Record
	- Search record based on Primary Key
	- USe the Remove method for DbSet and pass the searched record to it
		- ctx.EMployees.Remove(emp);
	- Complete Transaction

# Pratically using EF Core

- Instaling Packages 
	- From Command prompt instaling pakages
	- Navigate to the Projet folder, (path upto bin for the project)
	- Syntax
		- dotnet add package [PACKAGE-NAME] -v [VERSION-NO]
	- e.g.
		- dotnet add pakage Microsoft.EntityFrameworkCore -v 7.0.0
		- dotnet add pakage Microsoft.EntityFrameworkCore.SqlServer -v 7.0.0 
		- dotnet add pakage Microsoft.EntityFrameworkCore.Relational -v 7.0.0
		- dotnet add pakage Microsoft.EntityFrameworkCore.Tools -v 7.0.0
		- dotnet add pakage Microsoft.EntityFrameworkCore.Design -v 7.0.0

- Use the 'dotnet ef' cli to generate enties from the database

- ****IMP Note
	- Make sure that the dotnet ef cli is instaled on the mahing using teh following command
		- dotnet tool install --global dotnet-ef 
- Generating Etities from the Database using the following command
	- dotnet ef dbcontext scaffold "[CONNECTIO-STRING]" [DATABASE-PROVIDEER-PACKAGE] -o [PATH-OF-FOLDER-WHERE-ENTITYCLASSES-AND-DBCONTEXT-CLASSES-WILL-BE-CREATED] 

	- e.g. (If using Windows Authetication)
		- dotnet ef dbcontext scaffold "Data Source=[IP-ADDRESS-OF-SERVER/SERVER-INSTANCE-NAME/localhost/.];Initial Catalog=[DATABASE-NAME];Integrated Secuity=SSPI;TrusetServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Models
		
		- E.g. In My Case on My MAchine
			- dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=UCompany;Integrated Secuity=SSPI;TrusetServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Models   
	
	
	- e.g. (If using SQL Authentication)
		- dotnet ef dbcontext scaffold "Data Source=[IP-ADDRESS-OF-SERVER/SERVER-INSTANCE-NAME/localhost/.];Initial Catalog=[DATABASE-NAME];User Id=[USER-NAME];PAssword=[PASSWORD];TrusetServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Models

- Code-First
	- Create ENtity Classes
	- Create a Class Derived from DbContext
		- override the OnCOnfiguring() method
			- in this method define connection string to database using UseSqlServer() method  
		- Define DbSet<T> public properties for each entity class
		- override OnModelCreating() method that contains code (fluent api) to establish relationships across entities that will be reflected in database tables
	
	- Generate migration
		- This is a C# code to create table
	
		- dotnet ef migrations add [MIGRATION-NAME] -c [NAMESPACE-PATH-FOR-DBContext-Class]
			- This command will add the 'Migrations' folder in the Project that contains code for generating table
		
	- Run Migrations to generate database and tables
		- dotnet ef database update -c  [NAMESPACE-PATH-FOR-DBContext-Class]



