using System;
namespace DapperDemoMac
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartment();
        public void InsertDepartment(string newDepartmentName);
    }
}

