using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL.Entidades
{
    public partial class BolsaLaboral
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string IDUsuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public BolsaLaboral()
        {
        }
        public BolsaLaboral(BolsaLaboral obj)
        {
            Nombre = obj.Nombre;
            Descripcion = obj.Descripcion;
            IDUsuario = obj.IDUsuario;
            FechaInicio = obj.FechaInicio;
            FechaFin = obj.FechaFin;
            Estado = obj.Estado;
        }
        public override bool Equals(object obj)
        {
            return obj is BolsaLaboral
            && ((BolsaLaboral)obj).Nombre == Nombre
            && ((BolsaLaboral)obj).Descripcion == Descripcion
            && ((BolsaLaboral)obj).IDUsuario == IDUsuario
            && ((BolsaLaboral)obj).FechaInicio == FechaInicio
            && ((BolsaLaboral)obj).FechaFin == FechaFin
            && ((BolsaLaboral)obj).Estado == Estado
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Nombre.GetHashCode();
            hash = (hash * 7) + Descripcion.GetHashCode();
            hash = (hash * 7) + IDUsuario.GetHashCode();
            hash = (hash * 7) + FechaInicio.GetHashCode();
            hash = (hash * 7) + FechaFin.GetHashCode();
            hash = (hash * 7) + Estado.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[BolsaLaboral ";
            retorno = retorno + "Nombre=" + Nombre;
            retorno = retorno + "Descripcion=" + Descripcion;
            retorno = retorno + "IDUsuario=" + IDUsuario;
            retorno = retorno + "FechaInicio=" + FechaInicio;
            retorno = retorno + "FechaFin=" + FechaFin;
            retorno = retorno + "Estado=" + Estado;
            return retorno + "]";
        }
        public static bool operator ==(BolsaLaboral obj1, BolsaLaboral obj2)
        {
            return true
                  && obj1.Nombre == obj2.Nombre
                  && obj1.Descripcion == obj2.Descripcion
                  && obj1.IDUsuario == obj2.IDUsuario
                  && obj1.FechaInicio == obj2.FechaInicio
                  && obj1.FechaFin == obj2.FechaFin
                  && obj1.Estado == obj2.Estado
            ;
        }
        public static bool operator !=(BolsaLaboral obj1, BolsaLaboral obj2)
        {
            return
                   obj1.Nombre != obj2.Nombre
                  || obj1.Descripcion != obj2.Descripcion
                  || obj1.IDUsuario != obj2.IDUsuario
                  || obj1.FechaInicio != obj2.FechaInicio
                  || obj1.FechaFin != obj2.FechaFin
                  || obj1.Estado != obj2.Estado
            ;
        }
        public void Insertar()
        {
            var DALBolsaLaboral = new ASUGUACSystem.DAL.BolsaLaboral();
            var traductor = new Traductores.BolsaLaboral();
            DALBolsaLaboral = traductor.HaciaBolsaLaboral(this);
            DALBolsaLaboral.Insertar();


        }
        public void Actualizar()
        {
            var DALBolsaLaboral = new ASUGUACSystem.DAL.BolsaLaboral();
            var traductor = new Traductores.BolsaLaboral();
            DALBolsaLaboral = traductor.HaciaBolsaLaboral(this);
            DALBolsaLaboral.Actualizar();


        }
        public void Eliminar()
        {
            var DALBolsaLaboral = new ASUGUACSystem.DAL.BolsaLaboral();
            var traductor = new Traductores.BolsaLaboral();
            DALBolsaLaboral = traductor.HaciaBolsaLaboral(this);
            DALBolsaLaboral.Eliminar();


        }
    }
}
