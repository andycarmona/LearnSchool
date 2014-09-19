using Abp.Web.Mvc.Controllers;

namespace LearnSchool.Web.Controllers
{
    public abstract class LearnSchoolControllerBase : AbpController
    {
        protected LearnSchoolControllerBase()
        {
            LocalizationSourceName = "LearnSchool";
        }
    }
}