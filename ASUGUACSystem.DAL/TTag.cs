using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public partial class Tag
    {
        public Tag(Tag obj)
        {
            Palabra = obj.Palabra;
        }
        public override bool Equals(object obj)
        {
            return obj is Tag
            && ((Tag)obj).Palabra == Palabra
        ;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Palabra.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            var retorno = "[Tag ";
            retorno = retorno + "Palabra=" + Palabra;
            return retorno + "]";
        }
        public static bool operator ==(Tag obj1, Tag obj2)
        {
            return true
                  && obj1.Palabra == obj2.Palabra
            ;
        }
        public static bool operator !=(Tag obj1, Tag obj2)
        {
            return
                  obj1.Palabra != obj2.Palabra
            ;
        }
        public void Insertar()
        {
            var db = new ASUGUACEntities();
            db.Tag.Add(this);
            db.SaveChanges();


        }
        public void Actualizar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Tag where obj.Palabra == Palabra select obj).First();
            reg.Palabra = Palabra;
            db.SaveChanges();
        }
        public void Eliminar()
        {
            var db = new ASUGUACEntities();
            var reg = (from obj in db.Tag where obj.Palabra == Palabra select obj).First();
            db.Tag.Remove(reg);
            db.SaveChanges();
        }
    }
}
