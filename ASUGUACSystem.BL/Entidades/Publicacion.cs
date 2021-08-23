using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL.Entidades
{
    public partial class Publicacion
    {
        public long IDPromocion { get; set; }
        public long IDBolsaLaboral { get; set; }
        public long IDActividad { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public Publicacion()
        {
        }
        public Publicacion(Publicacion obj)
        {
            IDPromocion = obj.IDPromocion;
            IDBolsaLaboral = obj.IDBolsaLaboral;
            IDActividad = obj.IDActividad;
            FechaInicio = obj.FechaInicio;
            FechaFin = obj.FechaFin;
            Estado = obj.Estado;
        }
        public override bool Equals(object obj)
        {
            return obj is Publicacion
            && ((Publicacion)obj).IDPromocion == IDPromocion
            && ((Publicacion)obj).IDBolsaLaboral == IDBolsaLaboral
            && ((Publicacion)obj).IDActividad == IDActividad
            && ((Publicacion)obj).FechaInicio == FechaInicio
            && ((Publicacion)obj).FechaFin == FechaFin
            && ((Publicacion)obj).Estado == Estado
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + IDPromocion.GetHashCode();
            hash = (hash * 7) + IDBolsaLaboral.GetHashCode();
            hash = (hash * 7) + IDActividad.GetHashCode();
            hash = (hash * 7) + FechaInicio.GetHashCode();
            hash = (hash * 7) + FechaFin.GetHashCode();
            hash = (hash * 7) + Estado.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Publicacion ";
            retorno = retorno + "IDPromocion=" + IDPromocion;
            retorno = retorno + "IDBolsaLaboral=" + IDBolsaLaboral;
            retorno = retorno + "IDActividad=" + IDActividad;
            retorno = retorno + "FechaInicio=" + FechaInicio;
            retorno = retorno + "FechaFin=" + FechaFin;
            retorno = retorno + "Estado=" + Estado;
            return retorno + "]";
        }
        public static bool operator ==(Publicacion obj1, Publicacion obj2)
        {
            return true
                  && obj1.IDPromocion == obj2.IDPromocion
                  && obj1.IDBolsaLaboral == obj2.IDBolsaLaboral
                  && obj1.IDActividad == obj2.IDActividad
                  && obj1.FechaInicio == obj2.FechaInicio
                  && obj1.FechaFin == obj2.FechaFin
                  && obj1.Estado == obj2.Estado
            ;
        }
        public static bool operator !=(Publicacion obj1, Publicacion obj2)
        {
            return
                   obj1.IDPromocion != obj2.IDPromocion
                  || obj1.IDBolsaLaboral != obj2.IDBolsaLaboral
                  || obj1.IDActividad != obj2.IDActividad
                  || obj1.FechaInicio != obj2.FechaInicio
                  || obj1.FechaFin != obj2.FechaFin
                  || obj1.Estado != obj2.Estado
            ;
        }
        public void Insertar()
        {
            var DALPublicacion = new ASUGUACSystem.DAL.Publicacion();
            var traductor = new Traductores.Publicacion();
            DALPublicacion = traductor.HaciaPublicacion(this);
            DALPublicacion.Insertar();


        }
        public void Actualizar()
        {
            var DALPublicacion = new ASUGUACSystem.DAL.Publicacion();
            var traductor = new Traductores.Publicacion();
            DALPublicacion = traductor.HaciaPublicacion(this);
            DALPublicacion.Actualizar();


        }
        public void Eliminar()
        {
            var DALPublicacion = new ASUGUACSystem.DAL.Publicacion();
            var traductor = new Traductores.Publicacion();
            DALPublicacion = traductor.HaciaPublicacion(this);
            DALPublicacion.Eliminar();


        }
    }
}
