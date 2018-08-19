using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;
using GestionData.Helpers;

namespace GestionData.Repositorios
{
    public class RepositorioDocumentosParticipante
    {
        DefinicionesDataModel contextoDefiniciones = new DefinicionesDataModel();

        public DocumentosParticipantes GetOneDocumentoParticipante(int idDocumentoParticipante)
        {
            var documentoParticipante = contextoDefiniciones.DocumentosParticipantes.FirstOrDefault(d => d.IdDocumentoParticipante == idDocumentoParticipante);
            return documentoParticipante;
        }

        public IQueryable<DocumentosParticipantes> GetDocumentosParticipante(int idParticipante)
        {
            var documentosParicipante = contextoDefiniciones.DocumentosParticipantes.Where(p => p.IdParticipante == idParticipante);
            return documentosParicipante;
        }

        public IQueryable<Documentos> DocumentosExistentesParticipante(int idParticipante)
        {
            var documentosParicipante = contextoDefiniciones.DocumentosParticipantes.Where(p => p.IdParticipante == idParticipante).Select(d=> d.Documentos);
            return documentosParicipante;
        }

        public IQueryable<Documentos> GetDocumentosDisponibles(int idParticipante)
        {
            var documentosDisponibles = contextoDefiniciones.Documentos.Except(DocumentosExistentesParticipante(idParticipante));
            return documentosDisponibles;
        }

        public RespuestasServicios AddDocumentoParticipante(DocumentosParticipantes documentoParicipante)
        {
            contextoDefiniciones.DocumentosParticipantes.AddObject(documentoParicipante);
            
            return GuardarCambios();
        }

        public RespuestasServicios RemoveDocumentoParticipante(int idDocumentoParticipante)
        { 
            var docToDelete= GetOneDocumentoParticipante(idDocumentoParticipante);
            if (docToDelete != null)
            {
                contextoDefiniciones.DocumentosParticipantes.DeleteObject(docToDelete);
            }

            return GuardarCambios();
        }

        public RespuestasServicios GuardarCambios()
        {
            return DataHelper.GuardarContexto(contextoDefiniciones, "Documentos de Participante");
        }


    }
}
