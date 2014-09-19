using System.Web;
using Abp.Localization.Sources.Xml;

namespace LearnSchool.Web.Localization.LearnSchool
{
    public class LearnSchoolLocalizationSource : XmlLocalizationSource
    {
        public LearnSchoolLocalizationSource()
            : base("LearnSchool", HttpContext.Current.Server.MapPath("/Localization/LearnSchool"))
        {
        }
    }
}