using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class Empresa
    {
        public Empresa(Empresa obj)
        {
            IDEmpresa = obj.IDEmpresa;
            NombreEmpresa = obj.NombreEmpresa;
            Descripcion = obj.Descripcion;
        }

        public Empresa()
        {
            // TODO: Complete member initialization
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
            var db = new ASUGUACEntities();
            db.Empresa.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Empresa where obj.IDEmpresa == IDEmpresa select obj).First();
            reg.IDEmpresa = IDEmpresa;
            reg.NombreEmpresa = NombreEmpresa;
            reg.Descripcion = Descripcion;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Empresa where obj.IDEmpresa == IDEmpresa select obj).First();
            db.Empresa.Remove(reg);
            db.SaveChanges();
        }
    }
}
