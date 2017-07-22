using System.Collections.Generic;
using Entity.SmartSchool;

namespace BAL.SmartSchool.Interface
{
    public interface IUser
    {
        Message createUser(Employee user);
        List<Employee> getUser(int schoolId);
        Message editUser(int id);

    }
}
