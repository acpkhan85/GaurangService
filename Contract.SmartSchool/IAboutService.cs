using Entity.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contract.SmartSchool
{
    [ServiceContract]
    public interface IAboutService
    {
        [OperationContract]
        Message addUpdateStaff(Staff staff);
        [OperationContract]
        List<Staff> getSchoolStaff(int schoolId, Pagination pagination, out int totalNoOfRecords);
    }
}
