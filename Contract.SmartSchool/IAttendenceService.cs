using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Entity.SmartSchool;

namespace Contract.SmartSchool
{
    [ServiceContract]
    public interface IAttendenceService
    {
        [OperationContract]
        List<Student> GetStudents();
    }
}
