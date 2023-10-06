using Core_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_API.Services
{
    internal class EmployeeDataAccessRepository :  IDataResponseService<Employee, int>
    {
        UcompanyContext ctx;

        ResponseObject<Employee> response;

        public EmployeeDataAccessRepository(UcompanyContext ctx)
        {
            this.ctx = ctx;
            response = new ResponseObject<Employee>();
        }

        async Task<ResponseObject<Employee>> IDataResponseService<Employee, int>.CreateAsync(Employee entity)
        {
            try
            {
                var result = await ctx.Employees.AddAsync(entity);
                await ctx.SaveChangesAsync();
                response.Record = result.Entity;
                response.IsSuccess = true;
                response.Message = "Record added Successfully";
                response.ResponseCode = 200;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Error Occurred while Adding Record";
                /* Logic to Log Error Here */
                /* Ends Here */
                response.ResponseCode = 500;
            }
            return response;
        }

        async Task<ResponseObject<Employee>> IDataResponseService<Employee, int>.DeleteAsync(int id)
        {
            try
            {
                response.Record = await ctx.Employees.FindAsync(id);
                if (response.Record is Employee)
                {
                    ctx.Employees.Remove(response.Record);
                    await ctx.SaveChangesAsync();    
                    response.IsSuccess = true;
                    response.Message = "Record found Successfully";
                    response.ResponseCode = 200;
                }
                else
                {
                    throw new Exception($"Record based on Id = {id} is not found");
                }
               
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                /* Logic to Log Error Here */
                /* Ends Here */
                response.ResponseCode = 500;
            }
            return response;
        }

        async Task<ResponseObject<Employee>> IDataResponseService<Employee, int>.GetAsync()
        {
            response.Records = await ctx.Employees.ToListAsync();
            response.IsSuccess = true;
            response.Message = "Data Read Successfully";
            response.ResponseCode = 200;
            return response;
        }

        async Task<ResponseObject<Employee>> IDataResponseService<Employee, int>.GetAsync(int id)
        {
            try
            {
                response.Record = await ctx.Employees.FindAsync(id);
                if (response.Record is Employee)
                {
                    response.IsSuccess = true;
                    response.Message = $"Record based on Id = {id} is searched successfully";
                    response.ResponseCode = 200;
                }
                else
                {
                    throw new Exception($"Record based on id = {id} is not found");
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                /* Logic to Log Error Here */
                /* Ends Here */
                response.ResponseCode = 500;
            }
            return response;
        }

        async Task<ResponseObject<Employee>> IDataResponseService<Employee, int>.UpdateAsync(int id, Employee entity)
        {
            try
            {
                var recordToUpdate = await ctx.Employees.FindAsync(id);
                if (recordToUpdate is Employee)
                {
                    recordToUpdate.EmpName = entity.EmpName;
                    recordToUpdate.Designation = entity.Designation;
                    recordToUpdate.DeptNo = entity.DeptNo;
                    await ctx.SaveChangesAsync();   
                    response.Record = recordToUpdate;
                    response.IsSuccess = true;
                    response.Message = "Record updated Successfully";
                    response.ResponseCode = 200;
                }
                else
                {
                    throw new Exception($"Updated failed because Record based on Id = {id} is not found");
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                /* Logic to Log Error Here */
                /* Ends Here */
                response.ResponseCode = 500;
            }
            return response;
        }
    }
}
