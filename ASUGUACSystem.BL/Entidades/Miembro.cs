using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL.Entidades
{
    public partial class Miembro
    {
        public string DNI { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public string Celular { get; set; }
        public string Telefonopcional { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public Miembro()
        {
        }
        public Miembro(Miembro obj)
        {
            DNI = obj.DNI;
            ApellidoPaterno = obj.ApellidoPaterno;
            ApellidoMaterno = obj.ApellidoMaterno;
            Nombres = obj.Nombres;
            Celular = obj.Celular;
            Telefonopcional = obj.Telefonopcional;
            Direccion = obj.Direccion;
            CorreoElectronico = obj.CorreoElectronico;
        }
        public override bool Equals(object obj)
        {
            return obj is Miembro
            && ((Miembro)obj).DNI == DNI
            && ((Miembro)obj).ApellidoPaterno == ApellidoPaterno
            && ((Miembro)obj).ApellidoMaterno == ApellidoMaterno
            && ((Miembro)obj).Nombres == Nombres
            && ((Miembro)obj).Celular == Celular
            && ((Miembro)obj).Telefonopcional == Telefonopcional
            && ((Miembro)obj).Direccion == Direccion
            && ((Miembro)obj).CorreoElectronico == CorreoElectronico
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + DNI.GetHashCode();
            hash = (hash * 7) + ApellidoPaterno.GetHashCode();
            hash = (hash * 7) + ApellidoMaterno.GetHashCode();
            hash = (hash * 7) + Nombres.GetHashCode();
            hash = (hash * 7) + Celular.GetHashCode();
            hash = (hash * 7) + Telefonopcional.GetHashCode();
            hash = (hash * 7) + Direccion.GetHashCode();
            hash = (hash * 7) + CorreoElectronico.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Miembro ";
            retorno = retorno + "DNI=" + DNI;
            retorno = retorno + "ApellidoPaterno=" + ApellidoPaterno;
            retorno = retorno + "ApellidoMaterno=" + ApellidoMaterno;
            retorno = retorno + "Nombres=" + Nombres;
            retorno = retorno + "Celular=" + Celular;
            retorno = retorno + "Telefonopcional=" + Telefonopcional;
            retorno = retorno + "Direccion=" + Direccion;
            retorno = retorno + "CorreoElectronico=" + CorreoElectronico;
            return retorno + "]";
        }
        public static bool operator ==(Miembro obj1, Miembro obj2)
        {
            return true
                  && obj1.DNI == obj2.DNI
                  && obj1.ApellidoPaterno == obj2.ApellidoPaterno
                  && obj1.ApellidoMaterno == obj2.ApellidoMaterno
                  && obj1.Nombres == obj2.Nombres
                  && obj1.Celular == obj2.Celular
                  && obj1.Telefonopcional == obj2.Telefonopcional
                  && obj1.Direccion == obj2.Direccion
                  && obj1.CorreoElectronico == obj2.CorreoElectronico
            ;
        }
        public static bool operator !=(Miembro obj1, Miembro obj2)
        {
            return
                   obj1.DNI != obj2.DNI
                  || obj1.ApellidoPaterno != obj2.ApellidoPaterno
                  || obj1.ApellidoMaterno != obj2.ApellidoMaterno
                  || obj1.Nombres != obj2.Nombres
                  || obj1.Celular != obj2.Celular
                  || obj1.Telefonopcional != obj2.Telefonopcional
                  || obj1.Direccion != obj2.Direccion
                  || obj1.CorreoElectronico != obj2.CorreoElectronico
            ;
        }
        public void Insertar()
        {
            var DALMiembro = new ASUGUACSystem.DAL.Miembro();
            var traductor = new Traductores.Miembro();
            DALMiembro = traductor.HaciaMiembro(this);
            DALMiembro.Insertar();


        }
        public void Actualizar()
        {
            var DALMiembro = new ASUGUACSystem.DAL.Miembro();
            var traductor = new Traductores.Miembro();
            DALMiembro = traductor.HaciaMiembro(this);
            DALMiembro.Actualizar();


        }
        public void Eliminar()
        {
            var DALMiembro = new ASUGUACSystem.DAL.Miembro();
            var traductor = new Traductores.Miembro();
            DALMiembro = traductor.HaciaMiembro(this);
            DALMiembro.Eliminar();


        }
    }
}
