using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace ASUGUACSystem.SL.DataContract
{

        [CollectionDataContract]
        public class ListaEscuelaProfesional : System.Collections.Generic.List<EscuelaProfesional>
        {
        }
    
}
