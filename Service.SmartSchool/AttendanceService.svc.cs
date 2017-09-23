using System;
using System.Collections.Generic;
using Contract.SmartSchool;
using Entity.SmartSchool;
using BAL.SmartSchool.Interface;

namespace Service.SmartSchool
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AttendanceService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AttendanceService.svc or AttendanceService.svc.cs at the Solution Explorer and start debugging.
    public class AttendanceService : IAttendanceService
    {
        IAttendance _iattendance;

        public AttendanceService(IAttendance iAttendance)
        {
            _iattendance = iAttendance;
        }

        public List<ClassAttendanceDto> getClassAttendence(int classId, int divisionId)
        {
            //var result = _iattendance.getClassAttendence(classId, divisionId);

            List<ClassAttendanceDto> classAttendance = new List<ClassAttendanceDto>();
            //classAttendance = AutoMapper.Mapper.Map<List<ClassAttendance>, List<ClassAttendanceDto>>(result);
            classAttendance.Add(new ClassAttendanceDto { StudentId = 1, FullName = "Gaurang Shinde", Attendence = 1, StudentImageURL = "/images/img.jpg" });
            classAttendance.Add(new ClassAttendanceDto { StudentId = 2, FullName = "Shreedhar Deshwal", Attendence = 2, StudentImageURL = "/images/img.jpg" });
            classAttendance.Add(new ClassAttendanceDto { StudentId = 3, FullName = "Gilbert Temudo", Attendence = 3, StudentImageURL = "/images/img.jpg" });
            classAttendance.Add(new ClassAttendanceDto { StudentId = 4, FullName = "Abhijeet Talele", Attendence = 1, StudentImageURL = "/images/img.jpg" });
            return classAttendance;
        }
    }
}
