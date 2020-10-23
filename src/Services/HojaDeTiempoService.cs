
using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public interface IHojaDeTiempoService
    {
        bool Add(HojaDeTiempos model);
        bool Update(HojaDeTiempos model);
        bool Delete(int id);
        HojaDeTiempos GeById(int id);
        IEnumerable<HojaDeTiempos> GetAll();
    }

    public class HojaDeTiempoService : IHojaDeTiempoService
    {
        private readonly DiveriaTimesheetContext _timeSheetContext;

        //Constructor de la clase 
        public HojaDeTiempoService(
                DiveriaTimesheetContext timeSheetContext
            )
        {
            timeSheetContext = _timeSheetContext;
        }

        public bool Add(HojaDeTiempos model)
        {
            try
            {
                _timeSheetContext.Add(model);
                _timeSheetContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(HojaDeTiempos model)
        {
            try
            {
                //traigo de la BD pra asegur no dejar campos sin actualizar
                var originalModel = _timeSheetContext.HojaDeTiempos.Single(h => h.IdHojaDeTiempo == model.IdHojaDeTiempo);
                //Actualizo los datos que se que cambiaro
                //To do: ver si no puedo usar un auto mapper 
                originalModel.Notas = model.Notas;
                originalModel.CantidadDeHoras = model.CantidadDeHoras;

                _timeSheetContext.Update(originalModel);
                _timeSheetContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _timeSheetContext.HojaDeTiempos.Remove(_timeSheetContext.HojaDeTiempos.Find(id));
                _timeSheetContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public HojaDeTiempos GeById(int id)
        {
            var retorno = new HojaDeTiempos();
            using (var context = new DiveriaTimesheetContext())
            {
                retorno = context.HojaDeTiempos.Where(h => h.IdHojaDeTiempo == id).FirstOrDefault();

            }
            return retorno;
        }

        public IEnumerable<HojaDeTiempos> GetAll()
        {
            var result = new List<HojaDeTiempos>();
            var context = new DiveriaTimesheetContext();
            try
            {
                result = context.HojaDeTiempos.Take(10).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }

}
