using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class PresupuestoDetalleBLL
    {

        public static bool Guardar(PresupuestoDetalles nuevo)
        {
            bool retorno = false;

            using (var db = new Repositorio<PresupuestoDetalles>())
            {
                retorno = db.Guardar(nuevo) != null;
            }
            return retorno;

        }

        public static bool Mofidicar(PresupuestoDetalles existente)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<PresupuestoDetalles>())
            {
                eliminado = repositorio.Modificar(existente);
            }

            return eliminado;

        }



        public static bool Eliminar(PresupuestoDetalles id)
        {
            bool resultado = false;
            using (var db = new Repositorio<PresupuestoDetalles>())
            {
                resultado = db.Eliminar(id);

            }
            return resultado;
        }


        public static PresupuestoDetalles Buscar(Expression<Func<PresupuestoDetalles, bool>> tipo)
        {
            PresupuestoDetalles Result = null;
            using (var repoitorio = new Repositorio<PresupuestoDetalles>())

            {
                Result = repoitorio.Buscar(tipo);
            }

            return Result;
        }



        public static List<Entidades.PresupuestoDetalles> GetListodo()
        {
            List<Entidades.PresupuestoDetalles> lista = new List<PresupuestoDetalles>();
            using (var db = new DAL.Repositorio<PresupuestoDetalles>())
            {
                try
                {
                    return db.ListaTodo();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }


        public static List<Entidades.PresupuestoDetalles> GetList(Expression<Func<Entidades.PresupuestoDetalles, bool>> criterioBusqueda)
        {
            using (var repositorio = new DAL.Repositorio<Entidades.PresupuestoDetalles>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }

    }
}
