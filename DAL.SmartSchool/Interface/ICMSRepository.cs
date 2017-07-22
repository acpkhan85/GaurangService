using Entity.SmartSchool;

namespace DAL.SmartSchool.Interface
{
    interface ICmsRepository
    {
        #region Branding Page
        Message createBranding(Branding branding);
        Branding getBrandingDetail(int schoolId);
        Message updateBrandingDetail(Branding branding);

        #endregion

        #region MainBanner
        Message createBanner(Banner banner);
        Message editBanner(Banner banner);
        Banner getBannerDetail(int schoolId);

        #endregion

        #region LatestNews
        Message createNews(LatestNews news);
        Message editNews(LatestNews news);
        LatestNews getNewsDetail(int schoolId);
        #endregion

        #region Events
        Message createEvent(Event schoolEvent);
        Message editEvent(Event schoolEvent);
        Event getEventDetail(int schoolId);

        #endregion

        #region welcome Note from Headmaster

        Message createWelcomNote(WelcomNotes welcomenote);
        WelcomNotes getWelcomeNote(int schooId);
        Message editWelcomNote(WelcomNotes welcomenote);


        #endregion

        #region aboutUs
        Message createAboutUs(AboutUs aboutUs);
        Message editAboutUs(AboutUs aboutUs);
        AboutUs getAboutUsDetail(int schoolId);

        #endregion
    }
}
