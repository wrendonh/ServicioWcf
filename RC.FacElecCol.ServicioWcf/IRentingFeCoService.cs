﻿namespace RC.FacElecCol.ServicioWcf
{
    using System.Runtime.Serialization;
    using System.ServiceModel;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IRentingFeCoService
    {
        [OperationContract]
        bool GenerarXml();
    }
}
