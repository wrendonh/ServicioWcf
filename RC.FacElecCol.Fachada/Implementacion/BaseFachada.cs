namespace RC.FacElecCol.Fachada.Implementacion
{
    using System.Collections.Generic;
    using RC.FacElecCol.Fachada.Interfaz;
    using RC.FacElecCol.Modelo.Entidades;

    public class BaseFachada : IBaseFachada
    {
        public List<MensajeDto> Mensajes { get; set; }

        public void SetMessages(List<MensajeDto> mensajes)
        {
            Mensajes = mensajes;
        }
    }
}
