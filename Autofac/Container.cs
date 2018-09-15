using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac
{
    public class Container
    {
        /// <summary>
        /// IOC 容器
        /// </summary>
        public static IContainer container = null;
        public static T Resolve<T>()
        {
            try
            {
                if (container == null)
                {

                    var builder = new ContainerBuilder();
                    builder.RegisterType<BLL>().As<IBLL>().InstancePerMatchingLifetimeScope();

                    container = builder.Build(); 


                }
            }
            catch (Exception ex)
            {
                throw new Exception("IOC实例化出错!" + ex.Message);
            }

            return container.Resolve<T>();
        }



    }
}
