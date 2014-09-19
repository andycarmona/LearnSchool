using Abp.Web.Mvc.Views;

namespace LearnSchool.Web.Views
{
    public abstract class LearnSchoolWebViewPageBase : LearnSchoolWebViewPageBase<dynamic>
    {

    }

    public abstract class LearnSchoolWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected LearnSchoolWebViewPageBase()
        {
            LocalizationSourceName = "LearnSchool";
        }
    }
}