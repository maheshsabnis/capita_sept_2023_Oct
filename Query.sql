Create database UCompany
Use UComapny


Create Table Department (
  DeptNo int Primary Key,
  DeptName varchar(200) Not Null,
  Location varchar(100) Not Null,
  Capacity int Not Null
)


Create Table Employee (
  EmpNo int Primary Key,
  EmpName varchar(200) Not Null,
  Designation varchar(200) Not Null,
  DeptNo int not null References Department(DeptNo)
)