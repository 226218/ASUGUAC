using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class Busqueda
    {
        public Busqueda(Busqueda obj)
        {
            Contenido = obj.Contenido;
            IDUsuario = obj.IDUsuario;
            FechaActual = obj.FechaActual;
        }

        public Busqueda()
        {
            // TODO: Complete member initialization
        }
        public override bool Equals(object obj)
        {
            return obj is Busqueda
            && ((Busqueda)obj).Contenido == Contenido
            && ((Busqueda)obj).IDUsuario == IDUsuario
            && ((Busqueda)obj).FechaActual == FechaActual
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Contenido.GetHashCode();
            hash = (hash * 7) + IDUsuario.GetHashCode();
            hash = (hash * 7) + FechaActual.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Busqueda ";
            retorno = retorno + "Contenido=" + Contenido;
            retorno = retorno + "IDUsuario=" + IDUsuario;
            retorno = retorno + "FechaActual=" + FechaActual;
            return retorno + "]";
        }
        public static bool operator ==(Busqueda obj1, Busqueda obj2)
        {
            return true
                  && obj1.Contenido == obj2.Contenido
                  && obj1.IDUsuario == obj2.IDUsuario
                  && obj1.FechaActual == obj2.FechaActual
            ;
        }
        public static bool operator !=(Busqueda obj1, Busqueda obj2)
        {
            return
                  obj1.Contenido != obj2.Contenido
                  || obj1.IDUsuario != obj2.IDUsuario
                  || obj1.FechaActual != obj2.FechaActual
            ;
        }
        public void Insertar()
        {
            var db = new ASUGUACEntities();
            db.Busqueda.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Busqueda where obj.Contenido == Contenido select obj).First();
            reg.Contenido = Contenido;
            reg.IDUsuario = IDUsuario;
            reg.FechaActual = FechaActual;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Busqueda where obj.Contenido == Contenido select obj).First();
            db.Busqueda.Remove(reg);
            db.SaveChanges();
        }
    }
}
