using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL.Entidades
{
    public partial class TipoActividad
    {
        public string Nombre { get; set; }
        public TipoActividad()
        {
        }
        public TipoActividad(TipoActividad obj)
        {
            Nombre = obj.Nombre;
        }
        public override bool Equals(object obj)
        {
            return obj is TipoActividad
            && ((TipoActividad)obj).Nombre == Nombre
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Nombre.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[TipoActividad ";
            retorno = retorno + "Nombre=" + Nombre;
            return retorno + "]";
        }
        public static bool operator ==(TipoActividad obj1, TipoActividad obj2)
        {
            return true
                  && obj1.Nombre == obj2.Nombre
            ;
        }
        public static bool operator !=(TipoActividad obj1, TipoActividad obj2)
        {
            return
                   obj1.Nombre != obj2.Nombre
            ;
        }
        public void Insertar()
        {
            var DALTipoActividad = new ASUGUACSystem.DAL.TipoActividad();
            var traductor = new Traductores.TipoActividad();
            DALTipoActividad = traductor.HaciaTipoActividad(this);
            DALTipoActividad.Insertar();


        }
        public void Actualizar()
        {
            var DALTipoActividad = new ASUGUACSystem.DAL.TipoActividad();
            var traductor = new Traductores.TipoActividad();
            DALTipoActividad = traductor.HaciaTipoActividad(this);
            DALTipoActividad.Actualizar();


        }
        public void Eliminar()
        {
            var DALTipoActividad = new ASUGUACSystem.DAL.TipoActividad();
            var traductor = new Traductores.TipoActividad();
            DALTipoActividad = traductor.HaciaTipoActividad(this);
            DALTipoActividad.Eliminar();


        }
    }
}
