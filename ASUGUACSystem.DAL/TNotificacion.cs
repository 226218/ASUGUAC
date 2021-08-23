using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class Notificacion
    {
        public Notificacion(Notificacion obj)
        {
            IDUsuario = obj.IDUsuario;
            FechaNotificacion = obj.FechaNotificacion;
            TextoNotificacion = obj.TextoNotificacion;
            IDPublicacion = obj.IDPublicacion;
        }
        public override bool Equals(object obj)
        {
            return obj is Notificacion
            && ((Notificacion)obj).IDUsuario == IDUsuario
            && ((Notificacion)obj).FechaNotificacion == FechaNotificacion
            && ((Notificacion)obj).TextoNotificacion == TextoNotificacion
            && ((Notificacion)obj).IDPublicacion == IDPublicacion
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + IDUsuario.GetHashCode();
            hash = (hash * 7) + FechaNotificacion.GetHashCode();
            hash = (hash * 7) + TextoNotificacion.GetHashCode();
            hash = (hash * 7) + IDPublicacion.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Notificacion ";
            retorno = retorno + "IDUsuario=" + IDUsuario;
            retorno = retorno + "FechaNotificacion=" + FechaNotificacion;
            retorno = retorno + "TextoNotificacion=" + TextoNotificacion;
            retorno = retorno + "IDPublicacion=" + IDPublicacion;
            return retorno + "]";
        }
        public static bool operator ==(Notificacion obj1, Notificacion obj2)
        {
            return true
                  && obj1.IDUsuario == obj2.IDUsuario
                  && obj1.FechaNotificacion == obj2.FechaNotificacion
                  && obj1.TextoNotificacion == obj2.TextoNotificacion
                  && obj1.IDPublicacion == obj2.IDPublicacion
            ;
        }
        public static bool operator !=(Notificacion obj1, Notificacion obj2)
        {
            return
                  obj1.IDUsuario != obj2.IDUsuario
                  || obj1.FechaNotificacion != obj2.FechaNotificacion
                  || obj1.TextoNotificacion != obj2.TextoNotificacion
                  || obj1.IDPublicacion != obj2.IDPublicacion
            ;
        }
        public void Insertar()
        {
            var db = new ASUGUACEntities();
            db.Notificacion.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Notificacion where obj.IDUsuario == IDUsuario select obj).First();
            reg.IDUsuario = IDUsuario;
            reg.FechaNotificacion = FechaNotificacion;
            reg.TextoNotificacion = TextoNotificacion;
            reg.IDPublicacion = IDPublicacion;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Notificacion where obj.IDUsuario == IDUsuario select obj).First();
            db.Notificacion.Remove(reg);
            db.SaveChanges();
        }
    }
}
