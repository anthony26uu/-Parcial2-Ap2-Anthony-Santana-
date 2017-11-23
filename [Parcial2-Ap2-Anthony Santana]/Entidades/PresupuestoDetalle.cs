using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class PresupuestoDetalle
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Meta { get; set; }
        public decimal Logrado { get; set; }

        public PresupuestoDetalle()
        {


        }
    }
}
