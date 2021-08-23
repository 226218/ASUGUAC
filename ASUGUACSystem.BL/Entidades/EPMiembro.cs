using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL.Entidades
{
    public partial class EPMiembro
    {
        public string IDCarreraProfesional { get; set; }
        public string DNI { get; set; }
        public EPMiembro()
        {
        }
        public EPMiembro(EPMiembro obj)
        {
            IDCarreraProfesional = obj.IDCarreraProfesional;
            DNI = obj.DNI;
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
            var DALEPMiembro = new ASUGUACSystem.DAL.EPMiembro();
            var traductor = new Traductores.EPMiembro();
            DALEPMiembro = traductor.HaciaEPMiembro(this);
            DALEPMiembro.Insertar();


        }
        public void Actualizar()
        {
            var DALEPMiembro = new ASUGUACSystem.DAL.EPMiembro();
            var traductor = new Traductores.EPMiembro();
            DALEPMiembro = traductor.HaciaEPMiembro(this);
            DALEPMiembro.Actualizar();


        }
        public void Eliminar()
        {
            var DALEPMiembro = new ASUGUACSystem.DAL.EPMiembro();
            var traductor = new Traductores.EPMiembro();
            DALEPMiembro = traductor.HaciaEPMiembro(this);
            DALEPMiembro.Eliminar();


        }
    }
}
