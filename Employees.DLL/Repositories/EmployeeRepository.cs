using Employees.DLL.Data;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System;
using System.Security.Cryptography.X509Certificates;
using Employees.DLL.Data;
using Employees.DLL.Interfaces;
using Employees.Domain.Entities;

namespace Employees.DLL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDBContext _db;

        public EmployeeRepository(AppDBContext db)
        {
            _db = db;
        }

        public EmployeeRepository()
        {
        }

        public async Task<Employee> AddToPersonAsync(Employee employee, EmployeeInfo employeeInfo, EmployeePosition employeePosition)
        {
            try
            {
                var addressUpdate = _db.Entry<Employee>(employee);
                addressUpdate.State = EntityState.Modified;
                addressUpdate.Entity.EmployeeInfo.Add(employeeInfo);
                await _db.SaveChangesAsync();
                return addressUpdate.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Employee> RemoveFromPersonAsync(Employee employee, List<int> employeeId)
        {
            try
            {
                var addressState = await _db.Employee.Include(x => x.EmployeeInfo).FirstOrDefaultAsync(x => x.Id == employee.Id);
                addressState.EmployeeInfo.RemoveAll(x => employeeId.Contains(x.Id));
                await _db.SaveChangesAsync();
                return addressState;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Employee> CreateAsync(Employee entity)
        {
            try
            {
                await _db.Employee.AddAsync(entity);
                await _db.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Employee> CreateWithPersonsAsync(Employee address)
        {
            try
            {
                _db.EmployeeInfo.AddRange(address.EmployeeInfo);
                address.EmployeeInfo = address.EmployeeInfo;
                await _db.Employee.AddAsync(address);
                await _db.SaveChangesAsync();
                return address;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Employee> DeleteAsync(int id)
        {
            try
            {
                var address = await _db.Employee.FindAsync(id);

                if (address == null)
                    throw new Exception();

                _db.Employee.Remove(address);
                await _db.SaveChangesAsync();
                return address;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Employee>> GetAsync()
        {
            try
            {
                return await _db.Employee
                    .AsNoTracking()
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Employee> GetAsync(int id)
        {
            try
            {
                return await _db.Employee
                    .AsNoTracking()
                    .Include(x => x.EmployeeInfo)
                    .FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Employee> UpdateAsync(Employee entity)
        {
            try
            {
                var address = _db.Entry<Employee>(entity);
                address.State = EntityState.Modified;

                await _db.SaveChangesAsync();
                return entity;
            }
            catch
            {
                throw new Exception();
            }
        }

        public async Task<Employee> AddPersonsRangeAsync(Employee employee, List<int> persinsId)
        {
            try
            {
                var addressState = _db.Entry<Employee>(employee);
                addressState.State = EntityState.Modified;
                addressState.Entity.EmployeeInfo.AddRange(_db.EmployeeInfo.AsNoTracking().Where(x => persinsId.Contains(x.Id)));
                await _db.SaveChangesAsync();
                return addressState.Entity;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}