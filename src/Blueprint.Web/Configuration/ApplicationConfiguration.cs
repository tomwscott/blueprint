using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;
using Blueprint.Web.Configuration.Modules;

namespace Blueprint.Web.Configuration
{
    public class ApplicationConfiguration
    {
        private static readonly List<ApplicationModule> MODULES = new List<ApplicationModule>{ Infrastructure.Module };
        private static readonly ApplicationConfiguration INSTANCE;

        static ApplicationConfiguration()
        {
            INSTANCE = new ApplicationConfiguration();
        }

        public static ApplicationConfiguration Instance { get { return INSTANCE; } }

        public SimpleContainer Container { 
            get {
                var container = new SimpleContainer();
                MODULES.ForEach(module => module.RegisterDependencies(container));
                return container;
            } 
        }
    }

    public class SimpleContainer
    {
        private readonly Yadic.IContainer container = new Yadic.SimpleContainer();

        public SimpleContainer Register<Implementation>()
        {
            container.Add<Implementation>();
            return this;
        }

        public SimpleContainer Register<Interface, Implemenation>()
        {
            container.Add<Interface, Implemenation>();
            return this;
        }

        public T Get<T>(Type type)
        {
            return (T) container.Resolve(type);
        }
    }
}