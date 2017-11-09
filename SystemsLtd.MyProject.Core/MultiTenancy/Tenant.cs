using Abp.MultiTenancy;
using SystemsLtd.MyProject.Authorization.Users;

namespace SystemsLtd.MyProject.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}