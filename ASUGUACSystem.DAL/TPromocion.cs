using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class Promocion
    {
        public Promocion(Promocion obj)
        {
            Nombre = obj.Nombre;
            Descripcion = obj.Descripcion;
            IDUsuario = obj.IDUsuario;
            FechaInicio = obj.FechaInicio;
            FechaFin = obj.FechaFin;
            Estado = obj.Estado;
            CodigoPromo = obj.CodigoPromo;
        }
        public override bool Equals(object obj)
        {
            return obj is Promocion
            && ((Promocion)obj).Nombre == Nombre
            && ((Promocion)obj).Descripcion == Descripcion
            && ((Promocion)obj).IDUsuario == IDUsuario
            && ((Promocion)obj).FechaInicio == FechaInicio
            && ((Promocion)obj).FechaFin == FechaFin
            && ((Promocion)obj).Estado == Estado
            && ((Promocion)obj).CodigoPromo == CodigoPromo
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
            hash = (hash * 7) + CodigoPromo.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Promocion ";
            retorno = retorno + "Nombre=" + Nombre;
            retorno = retorno + "Descripcion=" + Descripcion;
            retorno = retorno + "IDUsuario=" + IDUsuario;
            retorno = retorno + "FechaInicio=" + FechaInicio;
            retorno = retorno + "FechaFin=" + FechaFin;
            retorno = retorno + "Estado=" + Estado;
            retorno = retorno + "CodigoPromo=" + CodigoPromo;
            return retorno + "]";
        }
        public static bool operator ==(Promocion obj1, Promocion obj2)
        {
            return true
                  && obj1.Nombre == obj2.Nombre
                  && obj1.Descripcion == obj2.Descripcion
                  && obj1.IDUsuario == obj2.IDUsuario
                  && obj1.FechaInicio == obj2.FechaInicio
                  && obj1.FechaFin == obj2.FechaFin
                  && obj1.Estado == obj2.Estado
                  && obj1.CodigoPromo == obj2.CodigoPromo
            ;
        }
        public static bool operator !=(Promocion obj1, Promocion obj2)
        {
            return
                  obj1.Nombre != obj2.Nombre
                  || obj1.Descripcion != obj2.Descripcion
                  || obj1.IDUsuario != obj2.IDUsuario
                  || obj1.FechaInicio != obj2.FechaInicio
                  || obj1.FechaFin != obj2.FechaFin
                  || obj1.Estado != obj2.Estado
                  || obj1.CodigoPromo != obj2.CodigoPromo
            ;
        }
        public void Insertar()
        {
            var db = new ASUGUACEntities();
            db.Promocion.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Promocion where obj.Nombre == Nombre select obj).First();
            reg.Nombre = Nombre;
            reg.Descripcion = Descripcion;
            reg.IDUsuario = IDUsuario;
            reg.FechaInicio = FechaInicio;
            reg.FechaFin = FechaFin;
            reg.Estado = Estado;
            reg.CodigoPromo = CodigoPromo;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Promocion where obj.Nombre == Nombre select obj).First();
            db.Promocion.Remove(reg);
            db.SaveChanges();
        }
    }
}
