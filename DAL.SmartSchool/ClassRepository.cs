using System;
using System.Collections.Generic;
using DAL.SmartSchool.Interface;
using Entity.SmartSchool;

namespace DAL.SmartSchool
{
    public class ClassRepository : IClassRepository
    {
        #region Divion Setup
       public Message createDivision(ClassRoom division){  throw new NotImplementedException(); }
        public Message editDivision(ClassRoom division){  throw new NotImplementedException(); }
        public ClassRoom getDivision(int standard, int division){  throw new NotImplementedException(); }

        #endregion

        #region Set up studnet
        public Message createStudent(Student student){  throw new NotImplementedException(); }
        public Student getStudent(int studentId){  throw new NotImplementedException(); }
        public Message editStudent(Student student){  throw new NotImplementedException(); }
        #endregion

        #region TimeTable
        public Message createTimeTable(TimeTable timeTable){  throw new NotImplementedException(); }
        public Message editTimeTable(TimeTable timeTable){  throw new NotImplementedException(); }
        public List<TimeTable> getTimeTableDetail(int divisionId){  throw new NotImplementedException(); }
        #endregion

        #region ExamTimeTable
        public Message createExamTimeTable(ExamTimeTable timeTable){  throw new NotImplementedException(); }
        public Message editExamTimeTable(ExamTimeTable timeTable){  throw new NotImplementedException(); }
        public List<ExamTimeTable> getExamTimeTableDetail(int standard){  throw new NotImplementedException(); }
        #endregion

        #region Holidays
        public Message createHolidays(Holidays holiday){  throw new NotImplementedException(); }
        public Message editHolidays(Holidays holiday){
            //code for insert / uppdate Holiday
            throw new NotImplementedException(); }
        public List<Holidays> getHolidaysDetail(int schoolId){  throw new NotImplementedException(); }
        #endregion
    }
}
