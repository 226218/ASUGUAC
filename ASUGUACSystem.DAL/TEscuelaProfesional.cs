using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class EscuelaProfesional
    {
        public EscuelaProfesional(EscuelaProfesional obj)
        {
            IDCarreraProfesional = obj.IDCarreraProfesional;
            Nombre = obj.Nombre;
            Descripcion = obj.Descripcion;
        }
        public override bool Equals(object obj)
        {
            return obj is EscuelaProfesional
            && ((EscuelaProfesional)obj).IDCarreraProfesional == IDCarreraProfesional
            && ((EscuelaProfesional)obj).Nombre == Nombre
            && ((EscuelaProfesional)obj).Descripcion == Descripcion
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + IDCarreraProfesional.GetHashCode();
            hash = (hash * 7) + Nombre.GetHashCode();
            hash = (hash * 7) + Descripcion.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[EscuelaProfesional ";
            retorno = retorno + "IDCarreraProfesional=" + IDCarreraProfesional;
            retorno = retorno + "Nombre=" + Nombre;
            retorno = retorno + "Descripcion=" + Descripcion;
            return retorno + "]";
        }
        public static bool operator ==(EscuelaProfesional obj1, EscuelaProfesional obj2)
        {
            return true
                  && obj1.IDCarreraProfesional == obj2.IDCarreraProfesional
                  && obj1.Nombre == obj2.Nombre
                  && obj1.Descripcion == obj2.Descripcion
            ;
        }
        public static bool operator !=(EscuelaProfesional obj1, EscuelaProfesional obj2)
        {
            return
                  obj1.IDCarreraProfesional != obj2.IDCarreraProfesional
                  || obj1.Nombre != obj2.Nombre
                  || obj1.Descripcion != obj2.Descripcion
            ;
        }
        public void Insertar()
        {
            var db = new ASUGUACEntities();
            db.EscuelaProfesional.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.EscuelaProfesional where obj.IDCarreraProfesional == IDCarreraProfesional select obj).First();
            reg.IDCarreraProfesional = IDCarreraProfesional;
            reg.Nombre = Nombre;
            reg.Descripcion = Descripcion;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.EscuelaProfesional where obj.IDCarreraProfesional == IDCarreraProfesional select obj).First();
            db.EscuelaProfesional.Remove(reg);
            db.SaveChanges();
        }
    }
}
