using System.Collections.Generic;
using Entity.SmartSchool;

namespace BAL.SmartSchool.Interface
{
    public interface IAttendance
    {
        Message createUpdateAttendance(List<Attendance> attendance);
        List<Attendance> getMonthlyAttendanceForAllStudent(int divisionId);
        List<Attendance> getStudnetAttendanceDetailById(int studentId);
    }
}
