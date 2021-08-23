using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASUGUACSystem.DAL;
namespace ASUGUACSystem.BL
{
    public class Controlador
    {

        public Entidades.EscuelaProfesional SeleccionarEscuelaProfesional(string pIDCarreraProfesional)
        {
            var adm = new ASUGUACSystem.DAL.Controlador();
            var traductor = new Traductores.EscuelaProfesional();
            return traductor.HaciaEscuelaProfesional(adm.SeleccionarEscuelaProfesional(pIDCarreraProfesional));
        }
        public List<Entidades.EscuelaProfesional> SeleccionarEscuelaProfesionales()
        {
            var adm = new ASUGUACSystem.DAL.Controlador();
            var traductor = new Traductores.EscuelaProfesional();
            return traductor.HaciaEscuelaProfesional(adm.SeleccionarEscuelaProfesionals());
        }



    }
}
