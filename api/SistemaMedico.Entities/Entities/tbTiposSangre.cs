﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaMedico.Entities.Entities
{
    public partial class tbTiposSangre
    {
        public tbTiposSangre()
        {
            tbPersonas = new HashSet<tbPersonas>();
        }

        public int TiSa_Id { get; set; }
        public string TiSa_Descripcion { get; set; }
        public bool? TiSa_Estado { get; set; }
        public int TiSa_Creacion { get; set; }
        public DateTime TiSa_FechaCreacion { get; set; }
        public int? TiSa_Modificacion { get; set; }
        public DateTime? TiSa_FechaModificacion { get; set; }

        public virtual tbUsuarios TiSa_CreacionNavigation { get; set; }
        public virtual tbUsuarios TiSa_ModificacionNavigation { get; set; }
        public virtual ICollection<tbPersonas> tbPersonas { get; set; }
    }
}