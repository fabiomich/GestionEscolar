//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionEscolar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno_materia
    {
        public int id { get; set; }
        public Nullable<int> id_alumno { get; set; }
        public Nullable<int> id_periodo { get; set; }
        public Nullable<int> id_clase { get; set; }
        public Nullable<double> calificacion { get; set; }
    
        public virtual Alumnos Alumnos { get; set; }
        public virtual Clases Clases { get; set; }
        public virtual Periodos Periodos { get; set; }
    }
}
