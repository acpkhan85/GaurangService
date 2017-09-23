using System.Collections.Generic;
using Entity.SmartSchool;

namespace DAL.SmartSchool.Interface
{
    public interface IAttendanceRepository
    {
        Message createUpdateAttendance(List<Attendance> attendance);
        List<Attendance> getMonthlyAttendanceForAllStudent(int divisionId);
        List<Attendance> getStudnetAttendanceDetailById(int studentId);
        List<ClassAttendance> getClassAttendence(int classId, int divisionId);
    }
}
