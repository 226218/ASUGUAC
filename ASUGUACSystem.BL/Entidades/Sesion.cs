using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL.Entidades
{
    public partial class Sesion
    {
        public string IDUsuario { get; set; }
        public TimeSpan Duracion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaFin { get; set; }
        public Sesion()
        {
        }
        public Sesion(Sesion obj)
        {
            IDUsuario = obj.IDUsuario;
            Duracion = obj.Duracion;
            FechaIngreso = obj.FechaIngreso;
            FechaFin = obj.FechaFin;
        }
        public override bool Equals(object obj)
        {
            return obj is Sesion
            && ((Sesion)obj).IDUsuario == IDUsuario
            && ((Sesion)obj).Duracion == Duracion
            && ((Sesion)obj).FechaIngreso == FechaIngreso
            && ((Sesion)obj).FechaFin == FechaFin
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + IDUsuario.GetHashCode();
            hash = (hash * 7) + Duracion.GetHashCode();
            hash = (hash * 7) + FechaIngreso.GetHashCode();
            hash = (hash * 7) + FechaFin.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Sesion ";
            retorno = retorno + "IDUsuario=" + IDUsuario;
            retorno = retorno + "Duracion=" + Duracion;
            retorno = retorno + "FechaIngreso=" + FechaIngreso;
            retorno = retorno + "FechaFin=" + FechaFin;
            return retorno + "]";
        }
        public static bool operator ==(Sesion obj1, Sesion obj2)
        {
            return true
                  && obj1.IDUsuario == obj2.IDUsuario
                  && obj1.Duracion == obj2.Duracion
                  && obj1.FechaIngreso == obj2.FechaIngreso
                  && obj1.FechaFin == obj2.FechaFin
            ;
        }
        public static bool operator !=(Sesion obj1, Sesion obj2)
        {
            return
                   obj1.IDUsuario != obj2.IDUsuario
                  || obj1.Duracion != obj2.Duracion
                  || obj1.FechaIngreso != obj2.FechaIngreso
                  || obj1.FechaFin != obj2.FechaFin
            ;
        }
        public void Insertar()
        {
            var DALSesion = new ASUGUACSystem.DAL.Sesion();
            var traductor = new Traductores.Sesion();
            DALSesion = traductor.HaciaSesion(this);
            DALSesion.Insertar();


        }
        public void Actualizar()
        {
            var DALSesion = new ASUGUACSystem.DAL.Sesion();
            var traductor = new Traductores.Sesion();
            DALSesion = traductor.HaciaSesion(this);
            DALSesion.Actualizar();


        }
        public void Eliminar()
        {
            var DALSesion = new ASUGUACSystem.DAL.Sesion();
            var traductor = new Traductores.Sesion();
            DALSesion = traductor.HaciaSesion(this);
            DALSesion.Eliminar();


        }
    }
}
