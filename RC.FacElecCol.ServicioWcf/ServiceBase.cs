namespace RC.FacElecCol.ServicioWcf
{
    using Castle.Windsor;
    using Comun;
    using Dependencia;
    using Microsoft.Practices.Unity;
    using RC.FacElecCol.Fachada.Aspectos;

    public class ServiceBase
    {
        public static WindsorContainer Kernel;
        private static IUnityContainer unityContainer;
        private static IServiceLocator serviceLocator;

        private static IUnityContainer UnityContainer
        {
            get { return unityContainer ?? (unityContainer = UnityConfig.GetUnityContainer()); }
        }

        private static IServiceLocator ServiceLocator
        {
            get { return serviceLocator ?? (serviceLocator = UnityContainer.Resolve<IServiceLocator>()); }
        }

        protected static TService GetService<TService>()
        {
            return ServiceLocator.Get<TService>();
        }

        protected static void InitializeClass()
        {
            Kernel = new WindsorContainer();
            Kernel.Install(new DataInstaller());
        }
    }
}