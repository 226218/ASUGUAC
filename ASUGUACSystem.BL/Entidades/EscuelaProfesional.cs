using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.BL.Entidades
{
    public partial class EscuelaProfesional
    {
        public string IDCarreraProfesional { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public EscuelaProfesional()
        {
        }
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
            var DALEscuelaProfesional = new ASUGUACSystem.DAL.EscuelaProfesional();
            var traductor = new Traductores.EscuelaProfesional();
            DALEscuelaProfesional = traductor.HaciaEscuelaProfesional(this);
            DALEscuelaProfesional.Insertar();


        }
        public void Actualizar()
        {
            var DALEscuelaProfesional = new ASUGUACSystem.DAL.EscuelaProfesional();
            var traductor = new Traductores.EscuelaProfesional();
            DALEscuelaProfesional = traductor.HaciaEscuelaProfesional(this);
            DALEscuelaProfesional.Actualizar();


        }
        public void Eliminar()
        {
            var DALEscuelaProfesional = new ASUGUACSystem.DAL.EscuelaProfesional();
            var traductor = new Traductores.EscuelaProfesional();
            DALEscuelaProfesional = traductor.HaciaEscuelaProfesional(this);
            DALEscuelaProfesional.Eliminar();


        }
    }
}
