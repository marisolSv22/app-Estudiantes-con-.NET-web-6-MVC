﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace NotaEstudiantes.Models
{
    public partial class Nota
    {
        public int Id { get; set; }
        public string Calificacion { get; set; }
        public int? IdMateria { get; set; }
        public int? IdEstudiante { get; set; }

        public virtual Estudiante IdEstudianteNavigation { get; set; }
        public virtual Materia IdMateriaNavigation { get; set; }
    }
}