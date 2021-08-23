using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class EPMiembro
    {
        public EPMiembro(EPMiembro obj)
        {
            IDCarreraProfesional = obj.IDCarreraProfesional;
            DNI = obj.DNI;
        }

        public EPMiembro()
        {
            // TODO: Complete member initialization
        }
        public override bool Equals(object obj)
        {
            return obj is EPMiembro
            && ((EPMiembro)obj).IDCarreraProfesional == IDCarreraProfesional
            && ((EPMiembro)obj).DNI == DNI
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + IDCarreraProfesional.GetHashCode();
            hash = (hash * 7) + DNI.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[EPMiembro ";
            retorno = retorno + "IDCarreraProfesional=" + IDCarreraProfesional;
            retorno = retorno + "DNI=" + DNI;
            return retorno + "]";
        }
        public static bool operator ==(EPMiembro obj1, EPMiembro obj2)
        {
            return true
                  && obj1.IDCarreraProfesional == obj2.IDCarreraProfesional
                  && obj1.DNI == obj2.DNI
            ;
        }
        public static bool operator !=(EPMiembro obj1, EPMiembro obj2)
        {
            return
                  obj1.IDCarreraProfesional != obj2.IDCarreraProfesional
                  || obj1.DNI != obj2.DNI
            ;
        }
        public void Insertar()
        {
            var db = new ASUGUACEntities();
            db.EPMiembro.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.EPMiembro where obj.IDCarreraProfesional == IDCarreraProfesional select obj).First();
            reg.IDCarreraProfesional = IDCarreraProfesional;
            reg.DNI = DNI;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.EPMiembro where obj.IDCarreraProfesional == IDCarreraProfesional select obj).First();
            db.EPMiembro.Remove(reg);
            db.SaveChanges();
        }
    }
}
