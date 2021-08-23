using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace ASUGUACSystem.SL.DataContract
{
    [DataContract]
    public class EscuelaProfesional
    {
        string iDCarreraProfesional;
    [DataMember]
        public string IDCarreraProfesional
        {
            get { return iDCarreraProfesional; }
            set { iDCarreraProfesional = value; }
        }
        string nombre;
        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string descripcion;
        [DataMember]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
