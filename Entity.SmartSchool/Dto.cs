using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.SmartSchool
{
    public class MessageDTO
    {
        public string message { get; set; }
        public int status { get; set; }
    }
    public class ClassRoomDto
    {
        public int ClassId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(1, ErrorMessage = "Max length is 1")]
        public string Standard { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Division { get; set; }
        public int SchoolId { get; set; }
        public string Actions { get; set; }
    }

    public class StudentDto
    {
        public int SchoolId { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        [Required]
        public string ParentCellNumber { get; set; }
    }
    public class TimeTableDto
    {
        public int SchoolId { get; set; }
        public int TimeTableID { get; set; }
        [Required]
        public int ClassId { get; set; }
        [Required]
        public string Mon { get; set; }
        [Required]
        public string Tue { get; set; }
        [Required]
        public string Wed { get; set; }
        [Required]
        public string Thu { get; set; }
        [Required]
        public string Fri { get; set; }
        [Required]
        public string Sat { get; set; }
        [Required]
        public string Sun { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public string EndTime { get; set; }

    }
    public class ExamTimeTableDto
    {
        public int SchoolId { get; set; }
        public int ExamTimeTableID { get; set; }
        [Required]
        public int ClassId { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string FromDate { get; set; }
        [Required]
        public string FromTime { get; set; }
        [Required]
        public string ToTime { get; set; }
        [Required]
        public string Location { get; set; }
        public string Batch { get; set; }


    }
    #region Events and news
    public class EventsDto
    {
        public int EventId { get; set; }
        [Required]
        public string Header { get; set; }
        public string LocationImage { get; set; }
        [Required]
        public string EventDescription { get; set; }
        public string Location { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public int SchoolId { get; set; }
        public int CreateBy { get; set; }
        public string CreatedDate { get; set; }
    }

    public class NewsDto
    {
        public int newsId { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string NewsDescription { get; set; }
        public int SchoolId { get; set; }
        public int CreateBy { get; set; }
        public string CreatedDate { get; set; }
    }
    #endregion

    #region About
    public class StaffDto
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public string LastName { get; set; }
        public int SchoolId { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Designation { get; set; }
    }
    #endregion

    #region Holiday Calendar
    public class HolidaysDto
    {
        public int SchoolId { get; set; }
        public string HolidaysId { get; set; }
        [Required]
        public string FromDate { get; set; }
        [Required]
        public string ToDate { get; set; }
        [Required]
        public string Festival { get; set; }
        public string Notes { get; set; }
    }

    #endregion

    #region Notice Board
    public class NoticeBoardDto
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int DivisionId { get; set; }
        [Required]
        public string Description { get; set; }
    }
    #endregion

    #region Process document
    public class ProcessDocumentDto
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Application { get; set; }
        public int Status { get; set; }
        public string Notes { get; set; }
    }
    #endregion

    #region Collections
    public class BaseDTOCollection
    {
        public int TotalCount { get; set; }
    }
    public class ClassRoomCollection : BaseDTOCollection
    {
        public List<ClassRoomDto> ClassRoom { get; set; }
    }
    public class StudentCollection : BaseDTOCollection
    {
        public List<StudentDto> StudentList { get; set; }
    }
    #endregion

    #region Dashboard
    public class DashboardDto
    {
        public int TotalStudents { get; set; }
        public int TotalAbsentStudents { get; set; }
        public int TotalBackOfficeApplications { get; set; }
        public int TotalStaff { get; set; }
        public List<DivisionDto> Divisions { get; set; }
        public List<EventsDto> Events { get; set; }
        public List<NewsDto> News { get; set; }
    }

    public class DivisionDto
    {
        public int SchoolId { get; set; }
        public float Percentage { get; set; }
        public string Divison { get; set; }
        public string Standard { get; set; }
        public int PresentStudent { get; set; }
        public int TotalStudent { get; set; }

    }
    #endregion

    #region Attendenece
    public class ClassAttendanceDto
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string StudentImageURL { get; set; }
        public Int16 Attendence { get; set; }
    }
    #endregion
}
