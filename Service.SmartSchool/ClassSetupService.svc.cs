using System;
using System.Collections.Generic;
using BAL.SmartSchool.Interface;
using Contract.SmartSchool;
using Entity.SmartSchool;

namespace Service.SmartSchool
{

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

        public List<ExamTimeTable> getExamDetailByStandard(int schoolId, int division)
        {
            throw new NotImplementedException();
        }

        public List<Holidays> getHolidayDetail(int shcoolId)
        {
            throw new NotImplementedException();
        }

        public List<ClassRoom> getStandardDivision(int schoolId, int standard, int division)
        {
            throw new NotImplementedException();
        }

        public List<Student> getStudentDetail(int schoolId, string fname, string lname, int division)
        {
            throw new NotImplementedException();
        }

        public List<TimeTable> getTimeTableByDivsion()
        {
            throw new NotImplementedException();
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
