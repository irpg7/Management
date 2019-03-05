using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Bll.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
         public static T GetInstance<T>()
        {
            var kernel = new KernelConfiguration(new BusinessModule()).BuildReadonlyKernel();
            return kernel.Get<T>();
          
        }
    }
}
