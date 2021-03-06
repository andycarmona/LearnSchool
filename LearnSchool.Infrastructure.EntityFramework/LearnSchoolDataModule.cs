﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LearnSchoolDataModule.cs" company="uni-app">
//   -
// </copyright>
// <summary>
//   -
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnSchool
{
    using System;
    using System.Reflection;

    using Abp.Dependency;
    using Abp.Modules;
    using Abp.Startup;
    using Abp.Startup.Infrastructure.EntityFramework;

    public class LearnSchoolDataModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(AbpEntityFrameworkModule),
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
