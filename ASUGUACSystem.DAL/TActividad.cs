using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class Actividad
    {
        public Actividad(Actividad obj)
        {
            Nombre = obj.Nombre;
            Descripcion = obj.Descripcion;
            IDTipoActividad = obj.IDTipoActividad;
            FechaInicio = obj.FechaInicio;
            FechaFin = obj.FechaFin;
            Estado = obj.Estado;
            IDUsuario = obj.IDUsuario;
        }
        public override bool Equals(object obj)
        {
            return obj is Actividad
            && ((Actividad)obj).Nombre == Nombre
            && ((Actividad)obj).Descripcion == Descripcion
            && ((Actividad)obj).IDTipoActividad == IDTipoActividad
            && ((Actividad)obj).FechaInicio == FechaInicio
            && ((Actividad)obj).FechaFin == FechaFin
            && ((Actividad)obj).Estado == Estado
            && ((Actividad)obj).IDUsuario == IDUsuario
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Nombre.GetHashCode();
            hash = (hash * 7) + Descripcion.GetHashCode();
            hash = (hash * 7) + IDTipoActividad.GetHashCode();
            hash = (hash * 7) + FechaInicio.GetHashCode();
            hash = (hash * 7) + FechaFin.GetHashCode();
            hash = (hash * 7) + Estado.GetHashCode();
            hash = (hash * 7) + IDUsuario.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Actividad ";
            retorno = retorno + "Nombre=" + Nombre;
            retorno = retorno + "Descripcion=" + Descripcion;
            retorno = retorno + "IDTipoActividad=" + IDTipoActividad;
            retorno = retorno + "FechaInicio=" + FechaInicio;
            retorno = retorno + "FechaFin=" + FechaFin;
            retorno = retorno + "Estado=" + Estado;
            retorno = retorno + "IDUsuario=" + IDUsuario;
            return retorno + "]";
        }
        public static bool operator ==(Actividad obj1, Actividad obj2)
        {
            return true
                  && obj1.Nombre == obj2.Nombre
                  && obj1.Descripcion == obj2.Descripcion
                  && obj1.IDTipoActividad == obj2.IDTipoActividad
                  && obj1.FechaInicio == obj2.FechaInicio
                  && obj1.FechaFin == obj2.FechaFin
                  && obj1.Estado == obj2.Estado
                  && obj1.IDUsuario == obj2.IDUsuario
            ;
        }
        public static bool operator !=(Actividad obj1, Actividad obj2)
        {
            return
                  obj1.Nombre != obj2.Nombre
                  || obj1.Descripcion != obj2.Descripcion
                  || obj1.IDTipoActividad != obj2.IDTipoActividad
                  || obj1.FechaInicio != obj2.FechaInicio
                  || obj1.FechaFin != obj2.FechaFin
                  || obj1.Estado != obj2.Estado
                  || obj1.IDUsuario != obj2.IDUsuario
            ;
        }
        public void Insertar()
        {
            var db = new ASUGUACEntities();
            db.Actividad.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Actividad where obj.Nombre == Nombre select obj).First();
            reg.Nombre = Nombre;
            reg.Descripcion = Descripcion;
            reg.IDTipoActividad = IDTipoActividad;
            reg.FechaInicio = FechaInicio;
            reg.FechaFin = FechaFin;
            reg.Estado = Estado;
            reg.IDUsuario = IDUsuario;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Actividad where obj.Nombre == Nombre select obj).First();
            db.Actividad.Remove(reg);
            db.SaveChanges();
        }
    }
}
