
using System.Collections.Generic;
using System.ServiceModel;
using Entity.SmartSchool;


namespace Contract.SmartSchool
{
    [ServiceContract]
    public interface IClassSetupService
    {

        #region Division
        [OperationContract]
        MessageDTO addUpdateStandrdDivision(ClassRoomDto classRoomDetail);
        [OperationContract]
        ClassRoomCollection getStandardDivision(int? standard, int? division, int schoolId, Pagination pagination);
        #endregion

        #region StudentSetup
        [OperationContract]
        StudentCollection getStudent(int studentId, int classId, Pagination pagination);
        [OperationContract]
        MessageDTO addUpdateStudentDetail(StudentDto student);
        [OperationContract]
        Message uploadStudentDetail(List<Student> lstStudent);
        #endregion

        #region TimeTable
        [OperationContract]
        MessageDTO addUpdateTimeTable(TimeTableDto timeTable);
        [OperationContract]
        Message uploadTimeTable(List<TimeTable> lstTimeTable);
        [OperationContract]
        List<TimeTableDto> getTimeTable(int classId);
        #endregion

        #region Exam

        [OperationContract]
        List<ExamTimeTableDto> getExamTimeTable(int classId);
        [OperationContract]
        MessageDTO addUpdateExamTimeTable(ExamTimeTableDto examTimeTable);
        [OperationContract]
        Message uploadTimeTableByStandard(List<TimeTable> timeTable);
        #endregion

        #region Holiday
        [OperationContract]
        MessageDTO addUpdateHolidayDetail(HolidaysDto holiday);
        [OperationContract]
        List<HolidaysDto> getHolidayDetail(int shcoolId);
        [OperationContract]
        Message uploadHoliday(List<Holidays> lstHoliday);
        #endregion

    }
}
