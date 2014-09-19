using System;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Dependency;
using Abp.Localization;
using Abp.Modules;
using Abp.Startup;
using LearnSchool.Web.Localization.LearnSchool;

namespace LearnSchool.Web
{
    public class LearnSchoolWebModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(LearnSchoolDataModule),
                       typeof(LearnSchoolApplicationModule),
                       typeof(LearnSchoolWebApiModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            LocalizationHelper.RegisterSource<LearnSchoolLocalizationSource>();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
