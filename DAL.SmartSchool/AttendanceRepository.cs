using System;
using System.Collections.Generic;
using DAL.SmartSchool.Interface;
using Entity.SmartSchool;

namespace DAL.SmartSchool
{
    public class AttendanceRepository : IAttendanceRepository
    {
        public Message createUpdateAttendance(List<Attendance> attendance)
        {
            throw new NotImplementedException();
        }

        public List<Attendance> getMonthlyAttendanceForAllStudent(int divisionId)
        {
            throw new NotImplementedException();
        }

        public List<Attendance> getStudnetAttendanceDetailById(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}
