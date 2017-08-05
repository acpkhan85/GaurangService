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

        public Message addUpdateExamTimeTable(ExamTimeTable examTimeTable)
        {
            return _classSetupRepository.createUpdateExamTimeTable(examTimeTable);
        }

        public Message addUpdateHolidayDetail(Holidays holiday)
        {
            return _classSetupRepository.createUpdateHolidays(holiday);
        }

        public Message addUpdateStudentDetail(Student student)
        {
            return _classSetupRepository.createUpdateStudent(student);
        }

        public Message addUpdateTimeTable(TimeTable timeTable)
        {
            return _classSetupRepository.createUpdateTimeTable(timeTable);
        }

        public Message createUpdateDivision(ClassRoom division)
        {
           return _classSetupRepository.createUpdateDivision(division);
        }

        public List<ClassRoom> getDivision(int standard, int division, Pagination pagination, out int totalNoOfRecords)
        {
            return _classSetupRepository.getDivision(standard, division, pagination, out totalNoOfRecords);
        }

        public List<ExamTimeTable> getExamTimeTable(int classId)
        {
            return _classSetupRepository.getExamTimeTable(classId);
        }

        public List<Holidays> getHolidaysDetail(int schoolId)
        {
            return _classSetupRepository.getHolidaysDetail(schoolId);
        }

        public List<Student> getStudent(int studentId, int classId, Pagination pagination, out int totalNoOfRecords)
        {
            return _classSetupRepository.getStudent(studentId, classId, pagination, out totalNoOfRecords);
        }

        public List<TimeTable> getTimeTable(int classId)
        {
            return _classSetupRepository.getTimeTable(classId);
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
