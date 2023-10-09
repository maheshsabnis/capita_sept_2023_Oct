# Date: 25-Sept-2023
Create a Class with methods to store Employee Information, read and update the information

# Date: 26-Sept-2023

1.	(LAB): Create a Employee abstract class by containing abstract methods for Read and Write Employee Information. Add the Virtual method to calculate Salary
2.	(LAB): Derive the Manager, Consultant, and Software Engineer classes from Employee class and override all methods of the Employee class.
3. (LAB):Creating a Abstract Factory that will calculate the Tax of each employee
4. Instead of defining Array in each Logic class for Storing employees based on its designation, define a single array of Employees which will store all types employees in it 
	- Perform Following Operation on this array (No LINQ No Google)
		- List all Directors in ascending order of Salary
		- Find details of specific Employee from this array	
		- Modify details of Employee e.g. Salary, and other data
		
# Date: 27-Sept-2023

1.	(LAB): Modify the Employee class and its derive classes that will store information of each Employee in Generic Dictionary
	1.	Dictionary<string, List<Employee>> db = new Dictionary<string, List<Employee>>()
		1.	The key 'string' will be DeptName
		1. Each DeptName will have List of Employees (with its derivations) 
2. Write following Extension Methods for 'String' class
	- GetAllCharacters()
	- GetAllWords()
	- GetAllDigits()
	- GetCountSpecialCharacters(char c)
		- c will be special character entered by user
	- ChangeTitleCase()  
		
# Date: 28-Sept-2023

1	(LAB): Define an event for the Employee class that will generate a notification to pay tax based on the Salary calculated. 

2.	(LAB): Create an application that will query to Employee collection for performing the following
a.	Sort all Employees by Salary
b.	Sort all Employees by EmpName
c.	Group all Employees by DeptName
d.	Get the Second Max Salary


# Date: 29-Sept-2023

1.	(LAB): Using Parallel class to Process all employees to calculate NetSalary and Tax for each salary using Parallel.ForEach Method

2.	(LAB): Using Parallel Invoke method to process Category wise employees for processing them to  calculate Tax 
	- Means: REad the Dictionary<string, List<Employee>> object
		-  string is Key which is category of Employee i.e. Director, Manager, Engineer, etc
			- The Calculate Salary will invoked for Each Employee Category in Parallel Invoke Method and the Salary Data along with the Tax will be written into a text file created using the File class
			- Create a seperate file for each employee based in following naming pattern 
				- empNo_empname.txt

# Date: 03-Oct-2023

1. Using ContinueWith() method for performing Tasks like read each Employee, calculate Income Details and write those details in file
	- Task 1: Read EMployee DEtails
	- Task 2: Calculate Income
	- TAsk 3: Write that Data in File
2. Make sure that the Global Database for Storing the Employee Information is repaced by ConcurrentDictionary


# Date: 06-Oct-2023

1. Create a Custom Validator to make sure that the EmpName MUST be accepted as 'FirstName MiddleName LastName'

2. MOdify the Post method for EMployeeController as follows:
	- If the Empployee is added in specific Department but its capacity is already full then throw an exception statng that the 'Department is already full with ix max capacity of Employees'

	- e.g.
		-	If 'IT' Department has 10 Capacity and already there are 10 EMployees exisit into it then throw an exception
			- 

# Date: 09-Oct-2023
- Modify the Exception Handler Middleware to Log Each Incomming Request into the Database table with the Table having Following schema
	- LoggerID, MUST be a GUID
	- LogDate, Date
	- LogTime, Time
	- LoggerMessage, varchar(4000) characters
	- ControllerName, varchar(200)
	- ActionName, varchar(200)

- Each Request (Success as well as  Excpetion) MUST be logged in Database