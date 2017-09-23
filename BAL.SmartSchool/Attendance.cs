using System;
using System.Collections.Generic;
using BAL.SmartSchool.Interface;
using Entity.SmartSchool;
using DAL.SmartSchool.Interface;

namespace BAL.SmartSchool
{
    public class Attendance : IAttendance
    {
        IAttendanceRepository _iIAttendanceRepository;

        public Message createUpdateAttendance(List<Attendance> attendance)
        {
            throw new NotImplementedException();
        }

        public List<ClassAttendance> getClassAttendence(int classId, int divisionId)
        {
            return _iIAttendanceRepository.getClassAttendence(classId, divisionId);
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
