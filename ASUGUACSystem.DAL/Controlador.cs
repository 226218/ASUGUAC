using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUGUACSystem.DAL
{
    public class Controlador
    {
        public EscuelaProfesional SeleccionarEscuelaProfesional(string pIDEscuelaProfesional)
        {
            var db = new ASUGUACEntities();
            return db.EscuelaProfesional.Find(pIDEscuelaProfesional);
        }
        public List<EscuelaProfesional> SeleccionarEscuelaProfesionals()
        {
            var db = new ASUGUACEntities();
            return db.EscuelaProfesional.ToList<EscuelaProfesional>();

        }
    }
}
