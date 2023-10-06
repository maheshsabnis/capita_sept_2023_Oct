// See https://aka.ms/new-console-template for more information
using System.Net.Http.Json;
using System.Text.Json;
using CS_API_Managed_Client;

Console.WriteLine("API Managed Client");

Console.WriteLine("Press any key when API Starts");
Console.ReadKey();

HttpClient client = new HttpClient();

// https://localhost:7169


var response = await client.GetFromJsonAsync<ResponseObject<Employee>>("https://localhost:7169/api/Employee");

Console.WriteLine($"Response = {JsonSerializer.Serialize(response)}");


Employee emp = new Employee() 
{
  EmpNo=102, EmpName="Sachin",Designation="Director",DeptNo=20
};

var postedObject = new ResponseObject<Employee>()
{
     Record = emp
};

var postResponse = client.PostAsJsonAsync<Employee>("https://localhost:7169/api/Employee", emp);

Console.WriteLine($"Response after Post : {JsonSerializer.Serialize(postResponse)}");


Console.ReadLine();
