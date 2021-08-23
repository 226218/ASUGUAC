using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL.Entidades
{
    public partial class Tag
    {
        public string Palabra { get; set; }
        public Tag()
        {
        }
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
            var DALTag = new ASUGUACSystem.DAL.Tag();
            var traductor = new Traductores.Tag();
            DALTag = traductor.HaciaTag(this);
            DALTag.Insertar();


        }
        public void Actualizar()
        {
            var DALTag = new ASUGUACSystem.DAL.Tag();
            var traductor = new Traductores.Tag();
            DALTag = traductor.HaciaTag(this);
            DALTag.Actualizar();


        }
        public void Eliminar()
        {
            var DALTag = new ASUGUACSystem.DAL.Tag();
            var traductor = new Traductores.Tag();
            DALTag = traductor.HaciaTag(this);
            DALTag.Eliminar();


        }
    }
}
