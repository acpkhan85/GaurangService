
using System;
using System.Collections.Generic;
using BAL.SmartSchool.Interface;
using Entity.SmartSchool;

namespace BAL.SmartSchool
{
    public class Attendance : IAttendance
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
