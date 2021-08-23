using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class TipoActividad
    {
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
            var db = new ASUGUACEntities();
            db.TipoActividad.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.TipoActividad where obj.Nombre == Nombre select obj).First();
            reg.Nombre = Nombre;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.TipoActividad where obj.Nombre == Nombre select obj).First();
            db.TipoActividad.Remove(reg);
            db.SaveChanges();
        }
    }
}
