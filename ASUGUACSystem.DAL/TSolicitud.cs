using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class Solicitud
    {
        public Solicitud(Solicitud obj)
        {
            Nombres = obj.Nombres;
            Apellidos = obj.Apellidos;
            Telefono = obj.Telefono;
            Correo = obj.Correo;
            TipoRequerimiento = obj.TipoRequerimiento;
            Descripcion = obj.Descripcion;
            Fecha = obj.Fecha;
            Estado = obj.Estado;
        }
        public override bool Equals(object obj)
        {
            return obj is Solicitud
            && ((Solicitud)obj).Nombres == Nombres
            && ((Solicitud)obj).Apellidos == Apellidos
            && ((Solicitud)obj).Telefono == Telefono
            && ((Solicitud)obj).Correo == Correo
            && ((Solicitud)obj).TipoRequerimiento == TipoRequerimiento
            && ((Solicitud)obj).Descripcion == Descripcion
            && ((Solicitud)obj).Fecha == Fecha
            && ((Solicitud)obj).Estado == Estado
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Nombres.GetHashCode();
            hash = (hash * 7) + Apellidos.GetHashCode();
            hash = (hash * 7) + Telefono.GetHashCode();
            hash = (hash * 7) + Correo.GetHashCode();
            hash = (hash * 7) + TipoRequerimiento.GetHashCode();
            hash = (hash * 7) + Descripcion.GetHashCode();
            hash = (hash * 7) + Fecha.GetHashCode();
            hash = (hash * 7) + Estado.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Solicitud ";
            retorno = retorno + "Nombres=" + Nombres;
            retorno = retorno + "Apellidos=" + Apellidos;
            retorno = retorno + "Telefono=" + Telefono;
            retorno = retorno + "Correo=" + Correo;
            retorno = retorno + "TipoRequerimiento=" + TipoRequerimiento;
            retorno = retorno + "Descripcion=" + Descripcion;
            retorno = retorno + "Fecha=" + Fecha;
            retorno = retorno + "Estado=" + Estado;
            return retorno + "]";
        }
        public static bool operator ==(Solicitud obj1, Solicitud obj2)
        {
            return true
                  && obj1.Nombres == obj2.Nombres
                  && obj1.Apellidos == obj2.Apellidos
                  && obj1.Telefono == obj2.Telefono
                  && obj1.Correo == obj2.Correo
                  && obj1.TipoRequerimiento == obj2.TipoRequerimiento
                  && obj1.Descripcion == obj2.Descripcion
                  && obj1.Fecha == obj2.Fecha
                  && obj1.Estado == obj2.Estado
            ;
        }
        public static bool operator !=(Solicitud obj1, Solicitud obj2)
        {
            return
                  obj1.Nombres != obj2.Nombres
                  || obj1.Apellidos != obj2.Apellidos
                  || obj1.Telefono != obj2.Telefono
                  || obj1.Correo != obj2.Correo
                  || obj1.TipoRequerimiento != obj2.TipoRequerimiento
                  || obj1.Descripcion != obj2.Descripcion
                  || obj1.Fecha != obj2.Fecha
                  || obj1.Estado != obj2.Estado
            ;
        }
        public void Insertar()
        {
            var db = new ASUGUACEntities();
            db.Solicitud.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Solicitud where obj.Nombres == Nombres select obj).First();
            reg.Nombres = Nombres;
            reg.Apellidos = Apellidos;
            reg.Telefono = Telefono;
            reg.Correo = Correo;
            reg.TipoRequerimiento = TipoRequerimiento;
            reg.Descripcion = Descripcion;
            reg.Fecha = Fecha;
            reg.Estado = Estado;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Solicitud where obj.Nombres == Nombres select obj).First();
            db.Solicitud.Remove(reg);
            db.SaveChanges();
        }
    }
}
