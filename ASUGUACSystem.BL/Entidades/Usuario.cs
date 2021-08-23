using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL.Entidades
{
    public partial class Usuario
    {
        public string IDUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Estado { get; set; }
        public string IDAsociado { get; set; }
        public string IDMembresia { get; set; }
        public string Permiso { get; set; }
        public Usuario()
        {
        }
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
            var DALUsuario = new ASUGUACSystem.DAL.Usuario();
            var traductor = new Traductores.Usuario();
            DALUsuario = traductor.HaciaUsuario(this);
            DALUsuario.Insertar();


        }
        public void Actualizar()
        {
            var DALUsuario = new ASUGUACSystem.DAL.Usuario();
            var traductor = new Traductores.Usuario();
            DALUsuario = traductor.HaciaUsuario(this);
            DALUsuario.Actualizar();


        }
        public void Eliminar()
        {
            var DALUsuario = new ASUGUACSystem.DAL.Usuario();
            var traductor = new Traductores.Usuario();
            DALUsuario = traductor.HaciaUsuario(this);
            DALUsuario.Eliminar();


        }
    }
}
