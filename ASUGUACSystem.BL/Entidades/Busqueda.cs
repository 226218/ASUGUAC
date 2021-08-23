using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL.Entidades
{
    public partial class Busqueda
    {
        public string Contenido { get; set; }
        public string IDUsuario { get; set; }
        public DateTime FechaActual { get; set; }
        public Busqueda()
        {
        }
        public Busqueda(Busqueda obj)
        {
            Contenido = obj.Contenido;
            IDUsuario = obj.IDUsuario;
            FechaActual = obj.FechaActual;
        }
        public override bool Equals(object obj)
        {
            return obj is Busqueda
            && ((Busqueda)obj).Contenido == Contenido
            && ((Busqueda)obj).IDUsuario == IDUsuario
            && ((Busqueda)obj).FechaActual == FechaActual
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Contenido.GetHashCode();
            hash = (hash * 7) + IDUsuario.GetHashCode();
            hash = (hash * 7) + FechaActual.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Busqueda ";
            retorno = retorno + "Contenido=" + Contenido;
            retorno = retorno + "IDUsuario=" + IDUsuario;
            retorno = retorno + "FechaActual=" + FechaActual;
            return retorno + "]";
        }
        public static bool operator ==(Busqueda obj1, Busqueda obj2)
        {
            return true
                  && obj1.Contenido == obj2.Contenido
                  && obj1.IDUsuario == obj2.IDUsuario
                  && obj1.FechaActual == obj2.FechaActual
            ;
        }
        public static bool operator !=(Busqueda obj1, Busqueda obj2)
        {
            return
                   obj1.Contenido != obj2.Contenido
                  || obj1.IDUsuario != obj2.IDUsuario
                  || obj1.FechaActual != obj2.FechaActual
            ;
        }
        public void Insertar()
        {
            var DALBusqueda = new ASUGUACSystem.DAL.Busqueda();
            var traductor = new Traductores.Busqueda();
            DALBusqueda = traductor.HaciaBusqueda(this);
            DALBusqueda.Insertar();


        }
        public void Actualizar()
        {
            var DALBusqueda = new ASUGUACSystem.DAL.Busqueda();
            var traductor = new Traductores.Busqueda();
            DALBusqueda = traductor.HaciaBusqueda(this);
            DALBusqueda.Actualizar();


        }
        public void Eliminar()
        {
            var DALBusqueda = new ASUGUACSystem.DAL.Busqueda();
            var traductor = new Traductores.Busqueda();
            DALBusqueda = traductor.HaciaBusqueda(this);
            DALBusqueda.Eliminar();


        }
    }
}
