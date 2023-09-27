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
