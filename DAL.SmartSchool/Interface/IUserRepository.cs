using System.Collections.Generic;
using Entity.SmartSchool;

namespace DAL.SmartSchool.Interface
{
    public interface IUserRepository
    {
        Message createUser(Employee user);      
        List<Employee> getUser(int schoolId);     
    }
}
