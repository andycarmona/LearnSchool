using System;
using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.Startup;
using Abp.Startup.Application;

namespace LearnSchool
{
    public class LearnSchoolApplicationModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(AbpApplicationModule),
                       typeof(LearnSchoolCoreModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
