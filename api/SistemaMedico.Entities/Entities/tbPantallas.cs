﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaMedico.Entities.Entities
{
    public partial class tbPantallas
    {
        public tbPantallas()
        {
            tbPantallasPorRoles = new HashSet<tbPantallasPorRoles>();
        }

        public int Pant_Id { get; set; }
        public string Pant_Descripcion { get; set; }
        public bool? Pant_Estado { get; set; }
        public int Pant_Creacion { get; set; }
        public DateTime Pant_FechaCreacion { get; set; }
        public int? Pant_Modificacion { get; set; }
        public DateTime? Pant_FechaModificacion { get; set; }

        public virtual tbUsuarios Pant_CreacionNavigation { get; set; }
        public virtual tbUsuarios Pant_ModificacionNavigation { get; set; }
        public virtual ICollection<tbPantallasPorRoles> tbPantallasPorRoles { get; set; }
    }
}