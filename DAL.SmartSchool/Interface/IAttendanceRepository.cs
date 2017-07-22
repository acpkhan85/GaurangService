using System.Collections.Generic;
using Entity.SmartSchool;

namespace DAL.SmartSchool.Interface
{
    interface IAttendanceRepository
    {
        Message createUpdateAttendance(List<Attendance> attendance);
        List<Attendance> getMonthlyAttendanceForAllStudent(int divisionId);
        List<Attendance> getStudnetAttendanceDetailById(int studentId);

    }
}
