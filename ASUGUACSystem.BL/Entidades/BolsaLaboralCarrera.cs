using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL.Entidades
{
    public partial class BolsaLaboralCarrera
    {
        public long IDBolsaLaboral { get; set; }
        public string IDCarreraProfesional { get; set; }
        public BolsaLaboralCarrera()
        {
        }
        public BolsaLaboralCarrera(BolsaLaboralCarrera obj)
        {
            IDBolsaLaboral = obj.IDBolsaLaboral;
            IDCarreraProfesional = obj.IDCarreraProfesional;
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
            var DALBolsaLaboralCarrera = new ASUGUACSystem.DAL.BolsaLaboralCarrera();
            var traductor = new Traductores.BolsaLaboralCarrera();
            DALBolsaLaboralCarrera = traductor.HaciaBolsaLaboralCarrera(this);
            DALBolsaLaboralCarrera.Insertar();


        }
        public void Actualizar()
        {
            var DALBolsaLaboralCarrera = new ASUGUACSystem.DAL.BolsaLaboralCarrera();
            var traductor = new Traductores.BolsaLaboralCarrera();
            DALBolsaLaboralCarrera = traductor.HaciaBolsaLaboralCarrera(this);
            DALBolsaLaboralCarrera.Actualizar();


        }
        public void Eliminar()
        {
            var DALBolsaLaboralCarrera = new ASUGUACSystem.DAL.BolsaLaboralCarrera();
            var traductor = new Traductores.BolsaLaboralCarrera();
            DALBolsaLaboralCarrera = traductor.HaciaBolsaLaboralCarrera(this);
            DALBolsaLaboralCarrera.Eliminar();


        }
    }
}
