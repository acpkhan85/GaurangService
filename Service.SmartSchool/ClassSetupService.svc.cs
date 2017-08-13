using System;
using System.Collections.Generic;
using BAL.SmartSchool.Interface;
using Contract.SmartSchool;
using Entity.SmartSchool;

namespace Service.SmartSchool
{

    [AutomapServiceBehavior]
    public class ClassSetupService : IClassSetupService
    {
        IClass _class;

        public ClassSetupService(IClass classRoom)
        {
            _class = classRoom;
        }

        public Message addUpdateHolidayDetail(Holidays holiday)
        {
            return _class.addUpdateHolidayDetail(holiday);
        }

        public Message addUpdateStandrdDivision(ClassRoom classRoomDetail)
        {
            return _class.createUpdateDivision(classRoomDetail);
        }

        public Message addUpdateStudentDetail(Student student)
        {
            return _class.addUpdateStudentDetail(student);
        }

        public Message addUpdateExamTimeTable(ExamTimeTable examTimeTable)
        {
            return _class.addUpdateExamTimeTable(examTimeTable);
        }

        public Message addUpdateTimeTable(TimeTable timeTable)
        {
            return _class.addUpdateTimeTable(timeTable);
        }

        public List<ExamTimeTable> getExamTimeTable(int classId)
        {
            return _class.getExamTimeTable(classId);
        }

        public List<Holidays> getHolidayDetail(int shcoolId)
        {
            return _class.getHolidaysDetail(shcoolId);
        }

        public List<ClassRoom> getStandardDivision(int standard, int division, int schoolId, Pagination pagination, out int totalNoOfRecords)
        {
            return _class.getDivision(standard, division, schoolId, pagination, out totalNoOfRecords);
        }

        public List<Student> getStudent(int studentId, int classId, Pagination pagination, out int totalNoOfRecords)
        {
            return _class.getStudent(studentId, classId, pagination, out totalNoOfRecords);
        }

        public List<TimeTable> getTimeTable(int classId)
        {
            return _class.getTimeTable(classId);
        }

        public Message uploadHoliday(List<Holidays> lstHoliday)
        {
            throw new NotImplementedException();
        }

        public Message uploadStudentDetail(List<Student> lstStudent)
        {
            throw new NotImplementedException();
        }

        public Message uploadTimeTable(List<TimeTable> lstTimeTable)
        {
            throw new NotImplementedException();
        }

        public Message uploadTimeTableByStandard(List<TimeTable> timeTable)
        {
            throw new NotImplementedException();
        }
    }
}
