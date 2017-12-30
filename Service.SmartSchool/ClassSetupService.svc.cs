using System;
using System.Collections.Generic;
using BAL.SmartSchool.Interface;
using Contract.SmartSchool;
using Entity.SmartSchool;
using AutoMapper;

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

        public MessageDTO addUpdateHolidayDetail(HolidaysDto holiday)
        {
            Holidays holi = Mapper.Map<HolidaysDto, Holidays>(holiday);
            Message msg = _class.addUpdateHolidayDetail(holi);
            var result = Mapper.Map<Message, MessageDTO>(msg);
            return result;
        }

        public MessageDTO addUpdateStandrdDivision(ClassRoomDto classRoomDetail)
        {
            ClassRoom classR = Mapper.Map<ClassRoomDto, ClassRoom>(classRoomDetail);
            Message msg = _class.createUpdateDivision(classR);
            var result = Mapper.Map<Message, MessageDTO>(msg);
            return result;
        }

        public MessageDTO addUpdateStudentDetail(StudentDto student)
        {
            Student std = Mapper.Map<StudentDto, Student>(student);
            Message msg = _class.addUpdateStudentDetail(std);
            var result = Mapper.Map<Message, MessageDTO>(msg);
            return result;
        }

        public MessageDTO addUpdateExamTimeTable(ExamTimeTableDto examTimeTable)
        {
            ExamTimeTable examTimeT = Mapper.Map<ExamTimeTableDto, ExamTimeTable>(examTimeTable);
            Message msg = _class.addUpdateExamTimeTable(examTimeT);
            var result = Mapper.Map<Message, MessageDTO>(msg);
            return result;
        }

        public MessageDTO addUpdateTimeTable(TimeTableDto timeTable)
        {
            TimeTable timeT = Mapper.Map<TimeTableDto, TimeTable>(timeTable);
            Message msg = _class.addUpdateTimeTable(timeT);
            var result = Mapper.Map<Message, MessageDTO>(msg);
            return result;
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
