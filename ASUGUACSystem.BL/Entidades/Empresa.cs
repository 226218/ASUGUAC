using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL.Entidades
{
    public partial class Empresa
    {
        public string IDEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string Descripcion { get; set; }
        public Empresa()
        {
        }
        public Empresa(Empresa obj)
        {
            IDEmpresa = obj.IDEmpresa;
            NombreEmpresa = obj.NombreEmpresa;
            Descripcion = obj.Descripcion;
        }
        public override bool Equals(object obj)
        {
            return obj is Empresa
            && ((Empresa)obj).IDEmpresa == IDEmpresa
            && ((Empresa)obj).NombreEmpresa == NombreEmpresa
            && ((Empresa)obj).Descripcion == Descripcion
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + IDEmpresa.GetHashCode();
            hash = (hash * 7) + NombreEmpresa.GetHashCode();
            hash = (hash * 7) + Descripcion.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Empresa ";
            retorno = retorno + "IDEmpresa=" + IDEmpresa;
            retorno = retorno + "NombreEmpresa=" + NombreEmpresa;
            retorno = retorno + "Descripcion=" + Descripcion;
            return retorno + "]";
        }
        public static bool operator ==(Empresa obj1, Empresa obj2)
        {
            return true
                  && obj1.IDEmpresa == obj2.IDEmpresa
                  && obj1.NombreEmpresa == obj2.NombreEmpresa
                  && obj1.Descripcion == obj2.Descripcion
            ;
        }
        public static bool operator !=(Empresa obj1, Empresa obj2)
        {
            return
                   obj1.IDEmpresa != obj2.IDEmpresa
                  || obj1.NombreEmpresa != obj2.NombreEmpresa
                  || obj1.Descripcion != obj2.Descripcion
            ;
        }
        public void Insertar()
        {
            var DALEmpresa = new ASUGUACSystem.DAL.Empresa();
            var traductor = new Traductores.Empresa();
            DALEmpresa = traductor.HaciaEmpresa(this);
            DALEmpresa.Insertar();


        }
        public void Actualizar()
        {
            var DALEmpresa = new ASUGUACSystem.DAL.Empresa();
            var traductor = new Traductores.Empresa();
            DALEmpresa = traductor.HaciaEmpresa(this);
            DALEmpresa.Actualizar();


        }
        public void Eliminar()
        {
            var DALEmpresa = new ASUGUACSystem.DAL.Empresa();
            var traductor = new Traductores.Empresa();
            DALEmpresa = traductor.HaciaEmpresa(this);
            DALEmpresa.Eliminar();


        }
    }
}
