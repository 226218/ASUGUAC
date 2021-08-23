using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class BolsaLaboral
    {
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
            var db = new ASUGUACEntities();
            db.BolsaLaboral.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.BolsaLaboral where obj.Nombre == Nombre select obj).First();
            reg.Nombre = Nombre;
            reg.Descripcion = Descripcion;
            reg.IDUsuario = IDUsuario;
            reg.FechaInicio = FechaInicio;
            reg.FechaFin = FechaFin;
            reg.Estado = Estado;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.BolsaLaboral where obj.Nombre == Nombre select obj).First();
            db.BolsaLaboral.Remove(reg);
            db.SaveChanges();
        }
    }
}