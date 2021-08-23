using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class BolsaLaboralCarrera
    {
        public BolsaLaboralCarrera(BolsaLaboralCarrera obj)
        {
            IDBolsaLaboral = obj.IDBolsaLaboral;
            IDCarreraProfesional = obj.IDCarreraProfesional;
        }

        public BolsaLaboralCarrera()
        {
            // TODO: Complete member initialization
        }
        public override bool Equals(object obj)
        {
            return obj is BolsaLaboralCarrera
            && ((BolsaLaboralCarrera)obj).IDBolsaLaboral == IDBolsaLaboral
            && ((BolsaLaboralCarrera)obj).IDCarreraProfesional == IDCarreraProfesional
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + IDBolsaLaboral.GetHashCode();
            hash = (hash * 7) + IDCarreraProfesional.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[BolsaLaboralCarrera ";
            retorno = retorno + "IDBolsaLaboral=" + IDBolsaLaboral;
            retorno = retorno + "IDCarreraProfesional=" + IDCarreraProfesional;
            return retorno + "]";
        }
        public static bool operator ==(BolsaLaboralCarrera obj1, BolsaLaboralCarrera obj2)
        {
            return true
                  && obj1.IDBolsaLaboral == obj2.IDBolsaLaboral
                  && obj1.IDCarreraProfesional == obj2.IDCarreraProfesional
            ;
        }
        public static bool operator !=(BolsaLaboralCarrera obj1, BolsaLaboralCarrera obj2)
        {
            return
                  obj1.IDBolsaLaboral != obj2.IDBolsaLaboral
                  || obj1.IDCarreraProfesional != obj2.IDCarreraProfesional
            ;
        }
        public void Insertar()
        {
            var db = new ASUGUACEntities();
            db.BolsaLaboralCarrera.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.BolsaLaboralCarrera where obj.IDBolsaLaboral == IDBolsaLaboral select obj).First();
            reg.IDBolsaLaboral = IDBolsaLaboral;
            reg.IDCarreraProfesional = IDCarreraProfesional;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.BolsaLaboralCarrera where obj.IDBolsaLaboral == IDBolsaLaboral select obj).First();
            db.BolsaLaboralCarrera.Remove(reg);
            db.SaveChanges();
        }
    }
}
