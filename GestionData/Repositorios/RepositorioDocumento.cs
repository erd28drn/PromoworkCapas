using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects;
using GestionData.Modelos;
using GestionData.Entities;
using GestionData.Helpers;

namespace GestionData.Repositorios
{
    public class RepositorioDocumento
    {
        DefinicionesDataModel contextoDefiniciones = new DefinicionesDataModel();

        public Documentos GetOneDocumento(int idDocumento)
        {
            var documento = contextoDefiniciones.Documentos.FirstOrDefault(d => d.IdDocumento == idDocumento);
            return documento;
        }
        
        public ObjectSet<Documentos> GetAllDocumentos()
        {
            var documentos = contextoDefiniciones.Documentos;
            return documentos;
        }

        public bool InsertDocumentoTransact(Documentos documento, int idUsuario)
        {
            documento.UsuarioCrea = idUsuario;
            documento.UsuarioModifica = idUsuario;
            documento.FechaCrea = DateTime.Now;
            documento.FechaModifica = DateTime.Now;
            contextoDefiniciones.Documentos.AddObject(documento);
            return true;
        }

        public RespuestasServicios InsertDocumento(Documentos documento, int idUsuario)
        {
            InsertDocumentoTransact(documento, idUsuario);
            var respuesta = GuardarCambios();
            return respuesta;
        }

        public bool DeleteDocumentoTransact(Documentos docuemnto)
        {
            contextoDefiniciones.DeleteObject(docuemnto);
            return true;
        }

        public RespuestasServicios DeleteDocumento(Documentos docuemnto)
        {
            DeleteDocumentoTransact(docuemnto);
            var respuesta = GuardarCambios();
            return respuesta;
        }

        public bool UpdateDocumentoTransact(Documentos documento, int idUsuario)
        {
            documento.UsuarioModifica = idUsuario;
            documento.FechaModifica = DateTime.Now;

            var documentoToUpdate = contextoDefiniciones.Documentos.FirstOrDefault(d => d.IdDocumento == documento.IdDocumento);
            documentoToUpdate = documento;
            return true;
        }

        public RespuestasServicios UpdateDocumento(Documentos documento, int idUsuario)
        {
            UpdateDocumentoTransact(documento, idUsuario);
            var respuesta = GuardarCambios();
            return respuesta;
        }

        public RespuestasServicios GuardarCambios()
        {
            return DataHelper.GuardarContexto(contextoDefiniciones, "Documentos");
        }


    }
}
