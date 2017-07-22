using System;
using System.Collections.Generic;
using BAL.SmartSchool.Interface;
using DAL.SmartSchool.Interface;
using Entity.SmartSchool;

namespace BAL.SmartSchool
{
    public class ClassSetup : IClass
    {
        IClassRepository _classSetupRepository;

        public ClassSetup(IClassRepository classRepository)
        {
            _classSetupRepository = classRepository;
        }

        public Message addUpdateHolidayDetail(Holidays holiday)
        {
            throw new NotImplementedException();
        }

        public Message addUpdateStudentDetail(Student student)
        {
            return _classSetupRepository.createUpdateStudent(student);
        }

        public Message createUpdateDivision(ClassRoom division)
        {
           return _classSetupRepository.createUpdateDivision(division);
        }

        public List<ClassRoom> getDivision(int standard, int division)
        {
            throw new NotImplementedException();
        }

        public List<ExamTimeTable> getExamDetailByStandard(int standard)
        {
            throw new NotImplementedException();
        }

        public List<Holidays> getHolidaysDetail(int schoolId)
        {
            throw new NotImplementedException();
        }

        public List<Student> getStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public List<TimeTable> getTimeTableDetail(int divisionId)
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

        public Message uploadTimeTable(TimeTable timeTable)
        {
            throw new NotImplementedException();
        }

        public Message uploadTimeTableByStandard(ExamTimeTable timeTable)
        {
            throw new NotImplementedException();
        }
    }
}
