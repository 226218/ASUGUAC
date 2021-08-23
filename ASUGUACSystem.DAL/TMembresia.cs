using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class Membresia
    {
        public Membresia(Membresia obj)
        {
            IDAsociado = obj.IDAsociado;
            FechaInicio = obj.FechaInicio;
            FechaFin = obj.FechaFin;
            Tipo = obj.Tipo;
            CategoriaMembresia = obj.CategoriaMembresia;
            Estado = obj.Estado;
        }
        public override bool Equals(object obj)
        {
            return obj is Membresia
            && ((Membresia)obj).IDAsociado == IDAsociado
            && ((Membresia)obj).FechaInicio == FechaInicio
            && ((Membresia)obj).FechaFin == FechaFin
            && ((Membresia)obj).Tipo == Tipo
            && ((Membresia)obj).CategoriaMembresia == CategoriaMembresia
            && ((Membresia)obj).Estado == Estado
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + IDAsociado.GetHashCode();
            hash = (hash * 7) + FechaInicio.GetHashCode();
            hash = (hash * 7) + FechaFin.GetHashCode();
            hash = (hash * 7) + Tipo.GetHashCode();
            hash = (hash * 7) + CategoriaMembresia.GetHashCode();
            hash = (hash * 7) + Estado.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Membresia ";
            retorno = retorno + "IDAsociado=" + IDAsociado;
            retorno = retorno + "FechaInicio=" + FechaInicio;
            retorno = retorno + "FechaFin=" + FechaFin;
            retorno = retorno + "Tipo=" + Tipo;
            retorno = retorno + "CategoriaMembresia=" + CategoriaMembresia;
            retorno = retorno + "Estado=" + Estado;
            return retorno + "]";
        }
        public static bool operator ==(Membresia obj1, Membresia obj2)
        {
            return true
                  && obj1.IDAsociado == obj2.IDAsociado
                  && obj1.FechaInicio == obj2.FechaInicio
                  && obj1.FechaFin == obj2.FechaFin
                  && obj1.Tipo == obj2.Tipo
                  && obj1.CategoriaMembresia == obj2.CategoriaMembresia
                  && obj1.Estado == obj2.Estado
            ;
        }
        public static bool operator !=(Membresia obj1, Membresia obj2)
        {
            return
                  obj1.IDAsociado != obj2.IDAsociado
                  || obj1.FechaInicio != obj2.FechaInicio
                  || obj1.FechaFin != obj2.FechaFin
                  || obj1.Tipo != obj2.Tipo
                  || obj1.CategoriaMembresia != obj2.CategoriaMembresia
                  || obj1.Estado != obj2.Estado
            ;
        }
        public void Insertar()
        {
            var db = new ASUGUACEntities();
            db.Membresia.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Membresia where obj.IDAsociado == IDAsociado select obj).First();
            reg.IDAsociado = IDAsociado;
            reg.FechaInicio = FechaInicio;
            reg.FechaFin = FechaFin;
            reg.Tipo = Tipo;
            reg.CategoriaMembresia = CategoriaMembresia;
            reg.Estado = Estado;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Membresia where obj.IDAsociado == IDAsociado select obj).First();
            db.Membresia.Remove(reg);
            db.SaveChanges();
        }
    }
}
