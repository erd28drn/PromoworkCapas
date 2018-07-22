using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioNota
    {
        GeneralesDataModel contextoGenerales = new GeneralesDataModel();

        public List<Notas> GetAll()
        {
            return contextoGenerales.Notas.ToList();
        }

        /// <summary>
        /// Inserta los nuevos elementos, actualiza los existentes y borras los eliminados.
        /// </summary>
        /// <param name="notas"></param>
        /// <returns></returns>
        public bool InsertUpdateDelete(List<Notas> notas, int idUsuario)
        {
            var notasInsert= notas.Where(n=> n.IdNota==0);
            var notasUpdate = notas.Where(n => n.EntityState == System.Data.EntityState.Modified);   //notas.Where(n=> n.IdNota>0);
            var notasDelete = contextoGenerales.Notas.ToList().Except(notas.ToList());

            foreach (var nota in notasDelete)
            {
                contextoGenerales.Notas.DeleteObject(nota);
            }

            foreach (var nota in notasUpdate)
            {
                var notaToUpdate = contextoGenerales.Notas.FirstOrDefault(c => c.IdNota == nota.IdNota);
                nota.IdUsuarioModifica = idUsuario;
                nota.FechaModifica = DateTime.Now;
                notaToUpdate = nota;
            }
            foreach (var nota in notasInsert)
            {
                nota.IdUsuarioCrea = idUsuario;
                nota.IdUsuarioModifica = idUsuario;
                nota.FechaCrea = DateTime.Now;
                nota.FechaModifica = DateTime.Now;

                contextoGenerales.Notas.AddObject(nota);
            }
            contextoGenerales.SaveChanges();
            return true;
        }

        public bool InsertNotas(List<Notas> notas)
        {
            foreach (var nota in notas)
            {
                contextoGenerales.Notas.AddObject(nota);
                contextoGenerales.SaveChanges();
            }
            return true;
        }

        public bool UpdateNotaTransact(Notas nota)
        {

            var notaToUpdate = contextoGenerales.Notas.FirstOrDefault(c => c.IdNota == nota.IdNota);
            notaToUpdate = nota;

            return true;
        }

        public bool InsertNotaTransact(Notas nota)
        {
            contextoGenerales.Notas.AddObject(nota);
            return true;
        }

        public bool DeleteNotaTransact(Notas nota)
        {
            contextoGenerales.Notas.DeleteObject(nota);
            return true;
        }

        public bool SaveDataTransact()
        {
            contextoGenerales.SaveChanges();
            return true;
        }
    }
}
