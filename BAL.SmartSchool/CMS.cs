using System;
using BAL.SmartSchool.Interface;
using Entity.SmartSchool;

namespace DAL.SmartSchool
{
    public class CMS : ICms
    {
        #region Branding Page
        public Message createBranding(Branding branding) { throw new NotImplementedException(); }
        public Branding getBrandingDetail(int schoolId) { throw new NotImplementedException(); }
        public Message updateBrandingDetail(Branding branding) { throw new NotImplementedException(); }

        #endregion

        #region MainBanner
        public Message createBanner(Banner banner) { throw new NotImplementedException(); }
        public Message editBanner(Banner banner) { throw new NotImplementedException(); }
        public Banner getBannerDetail(int schoolId) { throw new NotImplementedException(); }

        #endregion

        #region LatestNews
        public Message createNews(LatestNews news) { throw new NotImplementedException(); }
        public Message editNews(LatestNews news) { throw new NotImplementedException(); }
        public LatestNews getNewsDetail(int schoolId) { throw new NotImplementedException(); }
        #endregion

        #region Events
        public Message createEvent(Event schoolEvent) { throw new NotImplementedException(); }
        public Message editEvent(Event schoolEvent) { throw new NotImplementedException(); }
        public Event getEventDetail(int schoolId) { throw new NotImplementedException(); }

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
