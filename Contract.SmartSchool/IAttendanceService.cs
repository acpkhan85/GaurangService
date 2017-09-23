using Entity.SmartSchool;
using System.Collections.Generic;
using System.ServiceModel;

namespace Contract.SmartSchool
{
    [ServiceContract]
    public interface IAttendanceService
    {
        [OperationContract]
        List<ClassAttendanceDto> getClassAttendence(int classId, int divisionId);
    }
}
