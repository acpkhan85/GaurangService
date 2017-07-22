using System;
using System.Data;
using System.Data.SqlClient;
using Common.SmartSchool;
using DAL.SmartSchool.Interface;
using Entity.SmartSchool;

namespace DAL.SmartSchool
{
    public class CMS : DBHelper, ICmsRepository
    {
        #region Branding Page
        public Message createBranding(Branding branding)
        {
            Message msg = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Helper.sp_CreateUpdateBranding, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BrandingID", branding.BrandingID);
                command.Parameters.AddWithValue("@SchoolID", branding.SchoolID);
                command.Parameters.AddWithValue("@BrandingOption", branding.BrandingOption);
                command.Parameters.AddWithValue("@PortalURL", branding.PortalURL);
                command.Parameters.AddWithValue("@ThemeId", branding.ThemeId);
                command.Parameters.AddWithValue("@Logo", branding.Logo);
                command.Parameters.AddWithValue("@Banner", branding.Banner);
                command.Parameters.AddWithValue("@FavIcon", branding.FavIcon);
                command.Parameters.AddWithValue("@Disclaimer", branding.Disclaimer);
                command.Parameters.AddWithValue("@ContactInfo", branding.ContactInfo);
                command.Parameters.AddWithValue("@CreateBy", branding.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", branding.UpdatedBy);
                msg.status = objCommand.ExecuteNonQuery();
            }
            return msg;
        }

        public Branding getBrandingDetail(int schoolId)
        {
            Branding objBranding = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("", connection);
                command.CommandType = CommandType.StoredProcedure; command.Parameters.AddWithValue("@schoolId", schoolId);
                objReader = objCommand.ExecuteReader();
                if (objReader.HasRows)
                {
                    while (objReader.Read())
                    {
                        objBranding = new Branding();
                        objBranding.BrandingID = (int)objReader["BrandingID"];
                        objBranding.SchoolID = (int)objReader["SchoolID"];
                        objBranding.BrandingOption = (int)objReader["BrandingOption"];
                        objBranding.PortalURL = objReader["PortalURL"].ToString();
                        objBranding.ThemeId = (int)objReader["ThemeId"];
                        objBranding.Logo = objReader["Logo"].ToString();
                        objBranding.Banner = objReader["Banner"].ToString();
                        objBranding.FavIcon = objReader["FavIcon"].ToString();
                        objBranding.Disclaimer = objReader["Disclaimer"].ToString();
                        objBranding.ContactInfo = objReader["ContactInfo"].ToString();
                    }
                }
            }
            return objBranding;
        }

        public Message updateBrandingDetail(Branding branding) { throw new NotImplementedException(); }

        #endregion

        #region MainBanner
        public Message createBanner(Banner banner)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlCommand command = new SqlCommand("", connection);
                command.CommandType = CommandType.StoredProcedure; command.Parameters.AddWithValue("@BannerId", banner);
                command.Parameters.AddWithValue("@SchoolId", banner.SchoolId);
                command.Parameters.AddWithValue("@BannerImg1", banner.BannerImg1);
                command.Parameters.AddWithValue("@BannerText1", banner.BannerText1);
                command.Parameters.AddWithValue("@BannerImg2", banner.BannerImg2);
                command.Parameters.AddWithValue("@BannerText2", banner.BannerText2);
                command.Parameters.AddWithValue("@BannerImg3", banner.BannerImg3);
                command.Parameters.AddWithValue("@BannerText3", banner.BannerText3);
                command.Parameters.AddWithValue("@CreateBy", banner.CreateBy);
                msg.status = objCommand.ExecuteNonQuery();
            }
            return msg;
        }
        public Message editBanner(Banner banner) { throw new NotImplementedException(); }
        public Banner getBannerDetail(int schoolId)
        {
            Banner objBanner = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@schoolId", schoolId);
                objReader = objCommand.ExecuteReader();
                if (objReader.HasRows)
                {
                    while (objReader.Read())
                    {
                        objBanner = new Banner();
                        objBanner.BannerId = (int)objReader["BannerId"];
                        objBanner.SchoolId = (int)objReader["SchoolId"];
                        objBanner.BannerImg1 = objReader["BannerImg1"].ToString();
                        objBanner.BannerText1 = objReader["BannerText1"].ToString();
                        objBanner.BannerImg2 = objReader["BannerImg2"].ToString();
                        objBanner.BannerText2 = objReader["BannerText2"].ToString();
                        objBanner.BannerImg3 = objReader["BannerImg3"].ToString();
                        objBanner.BannerText3 = objReader["BannerText3"].ToString();
                    }
                }
            }
            return objBanner;
        }
        #endregion

        #region LatestNews
        public Message createNews(LatestNews news)
        {
            Message msg = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("", connection);
                msg = new Message();

                command.CommandType = CommandType.StoredProcedure; command.Parameters.AddWithValue("@newsId", news.newsId);
                command.Parameters.AddWithValue("@Image", news.Image);
                command.Parameters.AddWithValue("@Header", news.Header);
                command.Parameters.AddWithValue("@NewsDescription", news.NewsDescription);
                command.Parameters.AddWithValue("@SchoolId", news.SchoolId);
                command.Parameters.AddWithValue("@CreateBy", news.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", news.UpdatedBy);
                msg.status = objCommand.ExecuteNonQuery();
            }
            return msg;
        }
        public Message editNews(LatestNews news) { throw new NotImplementedException(); }

        public LatestNews getNewsDetail(int id)
        {
            LatestNews objLatestNews = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                objReader = objCommand.ExecuteReader();
                if (objReader.HasRows)
                {
                    while (objReader.Read())
                    {
                        objLatestNews = new LatestNews();
                        objLatestNews.newsId = (int)objReader["newsId"];
                        objLatestNews.Image = objReader["Image"].ToString();
                        objLatestNews.Header = objReader["Header"].ToString();
                        objLatestNews.NewsDescription = objReader["NewsDescription"].ToString();
                        objLatestNews.SchoolId = (int)objReader["SchoolId"];
                    }
                }
            }
            return objLatestNews;
        }

        #endregion

        #region Events

        public Message createEvent(Event evnt)
        {
            Message msg = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("", connection);

                command.CommandType = CommandType.StoredProcedure; command.Parameters.AddWithValue("@EventId", evnt.EventId);
                command.Parameters.AddWithValue("@Header", evnt.Header);
                command.Parameters.AddWithValue("@LocationImage", evnt.LocationImage);
                command.Parameters.AddWithValue("@EventDescription", evnt.EventDescription);
                command.Parameters.AddWithValue("@Location", evnt.Location);
                command.Parameters.AddWithValue("@StartDate", evnt.StartDate);
                command.Parameters.AddWithValue("@EndDate", evnt.EndDate);
                command.Parameters.AddWithValue("@SchoolId", evnt.SchoolId);
                command.Parameters.AddWithValue("@CreateBy", evnt.CreateBy);
                command.Parameters.AddWithValue("@UpdatedBy", evnt.UpdatedBy);
                msg.status = command.ExecuteNonQuery();
            }
            return msg;
        }

        public Message editEvent(Event schoolEvent) { throw new NotImplementedException(); }
        public Event getEventDetail(int schoolId)
        {
            Event objEvent = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                objReader = objCommand.ExecuteReader();
                if (objReader.HasRows)
                {
                    while (objReader.Read())
                    {
                        objEvent = new Event();
                        objEvent.EventId = (int)objReader["EventId"];
                        objEvent.Header = objReader["Header"].ToString();
                        objEvent.LocationImage = objReader["LocationImage"].ToString();
                        objEvent.EventDescription = objReader["EventDescription"].ToString();
                        objEvent.Location = objReader["Location"].ToString();
                        objEvent.StartDate = (DateTime)objReader["StartDate"];
                        objEvent.EndDate = (DateTime)objReader["EndDate"];
                        objEvent.SchoolId = (int)objReader["SchoolId"];
                    }
                }
            }
            return objEvent;
        }

        #endregion

        #region welcome Note from Headmaster

        public Message createWelcomNote(WelcomNotes welcomenote) { throw new NotImplementedException(); }
        public WelcomNotes getWelcomeNote(int schooId) { throw new NotImplementedException(); }
        public Message editWelcomNote(WelcomNotes welcomenote) { throw new NotImplementedException(); }


        #endregion

        #region aboutUs
        public Message createAboutUs(AboutUs aboutUs) { throw new NotImplementedException(); }
        public Message editAboutUs(AboutUs aboutUs) { throw new NotImplementedException(); }
        public AboutUs getAboutUsDetail(int schoolId) { throw new NotImplementedException(); }

        #endregion
    }
}
