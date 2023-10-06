using Core_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_API.Services
{
    internal class DepartmentDataAccessRepository : IDataAccessRepository<Department, int>
    {
        UcompanyContext ctx;
        /// <summary>
        /// Inject the UcompanyContext using Constructor Injection 
        /// </summary>
        public DepartmentDataAccessRepository(UcompanyContext ctx)
        {
             this.ctx = ctx;
        }

        async Task<Department> IDataAccessRepository<Department, int>.CreateAsync(Department entity)
        {
            var result = await ctx.Departments.AddAsync(entity);
            await ctx.SaveChangesAsync();
            return result.Entity; // Newly created entity will be reurned
        }

        async Task<Department> IDataAccessRepository<Department, int>.DeleteAsync(int id)
        {
            var record = await ctx.Departments.FindAsync(id);
            ctx.Departments.Remove(record);
            await ctx.SaveChangesAsync();
            return record;   
        }

        

        async Task<Department> IDataAccessRepository<Department, int>.GetAsync(int id)
        {
            var result = await ctx.Departments.FindAsync(id);
            return result;
        }

        async Task<IEnumerable<Department>> IDataAccessRepository<Department, int>.GetAsync()
        {
            var result = await ctx.Departments.ToListAsync();
            return result;
        }

        async Task<Department> IDataAccessRepository<Department, int>.UpdateAsync(int id, Department entity)
        {
            var record = await ctx.Departments.FindAsync( id);

            record.DeptName = entity.DeptName;
            record.Location = entity.Location;
            record.Capacity = entity.Capacity;

            await ctx.SaveChangesAsync();
            return record; // Updated record
        }
    }
}
