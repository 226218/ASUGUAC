//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASUGUACSystem.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Actividad = new HashSet<Actividad>();
            this.BolsaLaboral = new HashSet<BolsaLaboral>();
            this.Busqueda = new HashSet<Busqueda>();
            this.Notificacion = new HashSet<Notificacion>();
            this.Promocion = new HashSet<Promocion>();
            this.Sesion = new HashSet<Sesion>();
        }
    
        public string IDUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Estado { get; set; }
        public string IDAsociado { get; set; }
        public Nullable<long> IDMembresia { get; set; }
        public string Permiso { get; set; }
    
        public virtual ICollection<Actividad> Actividad { get; set; }
        public virtual ICollection<BolsaLaboral> BolsaLaboral { get; set; }
        public virtual ICollection<Busqueda> Busqueda { get; set; }
        public virtual Membresia Membresia { get; set; }
        public virtual ICollection<Notificacion> Notificacion { get; set; }
        public virtual ICollection<Promocion> Promocion { get; set; }
        public virtual ICollection<Sesion> Sesion { get; set; }
    }
}
