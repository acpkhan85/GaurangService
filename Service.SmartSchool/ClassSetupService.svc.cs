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

        public List<ExamTimeTableDto> getExamTimeTable(int classId)
        {
            var result = _class.getExamTimeTable(classId);
            List<ExamTimeTableDto> holidaysList = AutoMapper.Mapper.Map<List<ExamTimeTable>, List<ExamTimeTableDto>>(result);
            return holidaysList;
        }

        public List<HolidaysDto> getHolidayDetail(int shcoolId)
        {
            var result = _class.getHolidaysDetail(shcoolId);
            List<HolidaysDto> holidaysList = AutoMapper.Mapper.Map<List<Holidays>, List<HolidaysDto>>(result);
            return holidaysList;
        }

        public ClassRoomCollection getStandardDivision(int? standard, int? division, int schoolId, Pagination pagination)
        {
            int totalNoOfRecords = 0;
            var result = _class.getDivision(standard, division, schoolId, pagination, out totalNoOfRecords);
            List<ClassRoomDto> clsDto = AutoMapper.Mapper.Map<List<ClassRoom>, List<ClassRoomDto>>(result);

            ClassRoomCollection collection = new ClassRoomCollection();
            collection.TotalCount = totalNoOfRecords;
            collection.ClassRoom = clsDto;
            return collection;
        }

        public StudentCollection getStudent(int studentId, int classId, Pagination pagination)
        {
            int totalNoOfRecords = 0;
            var result = _class.getStudent(studentId, classId, pagination, out totalNoOfRecords);
            List<StudentDto> studentDto = AutoMapper.Mapper.Map<List<Student>, List<StudentDto>>(result);

            StudentCollection collection = new StudentCollection();
            collection.TotalCount = totalNoOfRecords;
            collection.StudentList = studentDto;
            return collection;
        }

        public List<TimeTableDto> getTimeTable(int classId)
        {
            var result = _class.getTimeTable(classId);
            List<TimeTableDto> timeTableist = AutoMapper.Mapper.Map<List<TimeTable>, List<TimeTableDto>>(result);

            return timeTableist;
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
