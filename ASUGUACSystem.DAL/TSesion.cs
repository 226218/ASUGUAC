using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class Sesion
    {
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
            var db = new ASUGUACEntities();
            db.Sesion.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Sesion where obj.IDUsuario == IDUsuario select obj).First();
            reg.IDUsuario = IDUsuario;
            reg.Duracion = Duracion;
            reg.FechaIngreso = FechaIngreso;
            reg.FechaFin = FechaFin;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Sesion where obj.IDUsuario == IDUsuario select obj).First();
            db.Sesion.Remove(reg);
            db.SaveChanges();
        }
    }
}
