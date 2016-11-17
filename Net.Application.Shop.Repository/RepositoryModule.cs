using Net.General.Dependency;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Net.Application.Shop
{
    public class RepositoryModule
    {
        public static void Initialize()
        {
            IocManager.RegisterAssembly(Assembly.GetExecutingAssembly());
            IocManager.Register<DbContext, DataContext>(DependencyLifeStyle.Transient);
        }
    }
}
