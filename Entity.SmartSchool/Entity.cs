using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.SmartSchool
{
    public class School : BaseClass
    {
        public School()
        {

        }
        public int SchoolId { get; set; }

        public string SchoolName { get; set; }


        public string PortalUrl { get; set; }

        public bool IsActive { get; set; }
    }
    public class Employee : SchoolBase
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
    }
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleDescription { get; set; }
    }

    #region Portal Setup

    public class Branding : BaseClass
    {
        public int BrandingID { get; set; }
        public int SchoolID { get; set; }
        public int BrandingOption { get; set; }
        public string PortalURL { get; set; }
        public int ThemeId { get; set; }
        public string Logo { get; set; }
        public string Banner { get; set; }
        public string FavIcon { get; set; }
        public string Disclaimer { get; set; }
        public string ContactInfo { get; set; }
    }
    public class Theme
    {

        public int ThemeID { get; set; }


        public string ThemeName { get; set; }
    }
    public class Banner : BaseClass
    {

        public int BannerId { get; set; }
        public int SchoolId { get; set; }


        public string BannerImg1 { get; set; }


        public string BannerText1 { get; set; }


        public string BannerImg2 { get; set; }


        public string BannerText2 { get; set; }


        public string BannerImg3 { get; set; }


        public string BannerText3 { get; set; }
    }
    public class Feature : BaseClass
    {

        public int FeatureId { get; set; }
        public int SchoolId { get; set; }



        public string FeatureImg1 { get; set; }

        public string FeatureTitle1 { get; set; }


        public string FeatureText1 { get; set; }



        public string FeatureImg2 { get; set; }


        public string FeatureTitle2 { get; set; }

        public string FeatureText2 { get; set; }


        public string FeatureImg3 { get; set; }

        public string FeatureTitle3 { get; set; }


        public string FeatureText3 { get; set; }

    }

    public class AboutUs : SchoolBase
    {

        public int id { get; set; }

        public string AboutUsInfo { get; set; }

        public List<Leaders> leaders { get; set; }

        public SchoolProsepectus prospectus { get; set; }
    }

    public class Leaders : SchoolBase
    {

        public int LeadersId { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Designation { get; set; }

    }

    public class SchoolProsepectus
    {

        public int SchoolProsepectusId { get; set; }


        public string ProspectusImage { get; set; }


        public string Description { get; set; }
    }

    public class WelcomNotes
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string HeadMasterImg { get; set; }
    }

    #endregion

    #region Class Setup
    public class ClassRoom : SchoolBase
    {
        public int ClassId { get; set; }
        public string Standard { get; set; }
        public string Division { get; set; }
    }
    public class Student : BaseClass
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BloodGroup { get; set; }
        public string ParentCellNumber { get; set; }
    }
    public class TimeTable : BaseClass
    {
        public int TimeTableID { get; set; }
        public int ClassId { get; set; }
        public string Mon { get; set; }
        public string Tue { get; set; }
        public string Wed { get; set; }
        public string Thu { get; set; }
        public string Fri { get; set; }
        public string Sat { get; set; }
        public string Sun { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

    }
    public class ExamTimeTable : BaseClass
    {

        public string ExamTimeTableID { get; set; }
        public int ClassId { get; set; }
        public string Subject { get; set; }
        public string FromDate { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public string Location { get; set; }
        public string Batch { get; set; }


    }
    public class LatestNews : SchoolBase
    {


        public int newsId { get; set; }


        public string Image { get; set; }


        public string Header { get; set; }


        public string NewsDescription { get; set; }

    }
    public class Event : SchoolBase
    {

        public int EventId { get; set; }

        public string Header { get; set; }


        public string LocationImage { get; set; }



        public string EventDescription { get; set; }


        public string Location { get; set; }


        public DateTime StartDate { get; set; }


        public DateTime EndDate { get; set; }
    }

    public class AbsentStudent : BaseClass
    {

        public int ID { get; set; }
        public int StudentId { get; set; }
        public int ClassID { get; set; }


        public string Notes { get; set; }
        public bool IsPlaneedLeave { get; set; }

    }

    #endregion

    #region Holiday Calendar

    public class Holidays : SchoolBase
    {
        public string HolidaysId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Festival { get; set; }
        public string Notes { get; set; }
    }

    #endregion

    #region Attendance Module

    public class Attendance : BaseClass
    {
        public int AttendanceID { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Notes { get; set; }
        public string RoleNo { get; set; }
        public string StudentName { get; set; }
        public bool IsInformedLeave { get; set; }
    }

    #endregion

    public class BaseClass
    {
        public int CreateBy { get; set; }
        public int UpdatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
    }

    public class SchoolBase : BaseClass
    {
        public int SchoolId { get; set; }
    }

    public class Message
    {
        public string message { get; set; }
        public int status { get; set; }
    }

    public enum status
    {
        sucusses,
        failure,
        warning
    }

    public class Pagination
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public int TotalCount { get; set; }
    }

    #region Events and news
    public class Events : BaseClass
    {
        public int EventId { get; set; }
        public string Header { get; set; }
        public string LocationImage { get; set; }
        public string EventDescription { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SchoolId { get; set; }
    }

    public class News: BaseClass
    {
        public int newsId { get; set; }
        public string Image { get; set; }
        public string Header { get; set; }
        public string NewsDescription { get; set; }
        public int SchoolId { get; set; }
    }
    #endregion

    #region About
    public class Staff : BaseClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string ImagePath { get; set; }
        public string LastName { get; set; }
        public int SchoolId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Designation { get; set; }
    }
    #endregion
}
