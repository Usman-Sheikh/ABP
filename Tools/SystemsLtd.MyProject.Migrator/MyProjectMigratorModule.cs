using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SystemsLtd.MyProject.EntityFramework;

namespace SystemsLtd.MyProject.Migrator
{
    [DependsOn(typeof(MyProjectDataModule))]
    public class MyProjectMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyProjectDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}