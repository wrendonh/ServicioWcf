namespace RC.FacElecCol.Dependencia
{
    using Comun;
    using Microsoft.Practices.Unity;

    public class UnityRegistrationModule : IContainerRegistrationModule<IUnityContainer>
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IServiceLocator, CustomUnityServiceLocator>();

            //container.RegisterType<ITareasFachada, TareasFachada>();
            //container.RegisterType<ITareasRn, TareasRn>();
            //container.RegisterType<ITareasRepositorio, TareasRepositorio>();
        }
    }
}
