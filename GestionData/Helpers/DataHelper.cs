using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using GestionData.Entities;
using System.Data;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.SqlClient;

namespace GestionData.Helpers
{
    public static class DataHelper
    {

        #region GUARDAR CONTEXTO
        public static RespuestasServicios GuardarContexto(ObjectContext contexto, string origenError)
        {
            RespuestasServicios respuesta = new RespuestasServicios();
            try
            {
                respuesta.idRespuesta = contexto.SaveChanges();
                respuesta.ResultadoOk = true;
                respuesta.Mensaje = string.Empty;
            }
            catch (OptimisticConcurrencyException oex)
            {
                respuesta.idRespuesta = -1;
                respuesta.ResultadoOk = false;
                respuesta.Mensaje = "Error al guardar los cambios en " + origenError + ". El registro fué modificado por otro usuario.";
            }
            catch (SqlException sex)
            {
                respuesta.idRespuesta = -1;
                respuesta.ResultadoOk = false;
                respuesta.Mensaje = "Error al guardar los cambios en " + origenError + ". Mensaje de error: " + sex.Message;
            }
            catch (Exception ex)
            {
                respuesta.idRespuesta = -1;
                respuesta.ResultadoOk = false;
                string mensaje = ex.Message;
                if (ex.InnerException != null)
                {
                    mensaje = ex.InnerException.Message;
                }
                respuesta.Mensaje = "Error al guardar los cambios en " + origenError + ". Mensaje de error: " + mensaje;
            }
            return respuesta;
        }
        #endregion GUARDAR CONTEXTO

        #region COMPROBAR SI EL CONTEXTO TIENE CAMBIOS SIN GUARDAR
        public static Boolean TieneCambiosSinGuardar(ObjectContext contexto)
        {
            return (contexto.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any());
        }
        #endregion COMPROBAR SI EL CONTEXTO HA CAMBIADO

    }
}
