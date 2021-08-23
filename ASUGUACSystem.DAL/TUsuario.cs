using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class Usuario
    {
        public Usuario(Usuario obj)
        {
            IDUsuario = obj.IDUsuario;
            Contraseña = obj.Contraseña;
            Estado = obj.Estado;
            IDAsociado = obj.IDAsociado;
            IDMembresia = obj.IDMembresia;
            Permiso = obj.Permiso;
        }
        public override bool Equals(object obj)
        {
            return obj is Usuario
            && ((Usuario)obj).IDUsuario == IDUsuario
            && ((Usuario)obj).Contraseña == Contraseña
            && ((Usuario)obj).Estado == Estado
            && ((Usuario)obj).IDAsociado == IDAsociado
            && ((Usuario)obj).IDMembresia == IDMembresia
            && ((Usuario)obj).Permiso == Permiso
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + IDUsuario.GetHashCode();
            hash = (hash * 7) + Contraseña.GetHashCode();
            hash = (hash * 7) + Estado.GetHashCode();
            hash = (hash * 7) + IDAsociado.GetHashCode();
            hash = (hash * 7) + IDMembresia.GetHashCode();
            hash = (hash * 7) + Permiso.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Usuario ";
            retorno = retorno + "IDUsuario=" + IDUsuario;
            retorno = retorno + "Contraseña=" + Contraseña;
            retorno = retorno + "Estado=" + Estado;
            retorno = retorno + "IDAsociado=" + IDAsociado;
            retorno = retorno + "IDMembresia=" + IDMembresia;
            retorno = retorno + "Permiso=" + Permiso;
            return retorno + "]";
        }
        public static bool operator ==(Usuario obj1, Usuario obj2)
        {
            return true
                  && obj1.IDUsuario == obj2.IDUsuario
                  && obj1.Contraseña == obj2.Contraseña
                  && obj1.Estado == obj2.Estado
                  && obj1.IDAsociado == obj2.IDAsociado
                  && obj1.IDMembresia == obj2.IDMembresia
                  && obj1.Permiso == obj2.Permiso
            ;
        }
        public static bool operator !=(Usuario obj1, Usuario obj2)
        {
            return
                  obj1.IDUsuario != obj2.IDUsuario
                  || obj1.Contraseña != obj2.Contraseña
                  || obj1.Estado != obj2.Estado
                  || obj1.IDAsociado != obj2.IDAsociado
                  || obj1.IDMembresia != obj2.IDMembresia
                  || obj1.Permiso != obj2.Permiso
            ;
        }
        public void Insertar()
        {
            var db = new ASUGUACEntities();
            db.Usuario.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Usuario where obj.IDUsuario == IDUsuario select obj).First();
            reg.IDUsuario = IDUsuario;
            reg.Contraseña = Contraseña;
            reg.Estado = Estado;
            reg.IDAsociado = IDAsociado;
            reg.IDMembresia = IDMembresia;
            reg.Permiso = Permiso;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Usuario where obj.IDUsuario == IDUsuario select obj).First();
            db.Usuario.Remove(reg);
            db.SaveChanges();
        }
    }
}
