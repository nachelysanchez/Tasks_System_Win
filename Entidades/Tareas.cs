﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_System_Win.Entidades
{
    public class Tareas
    {
        [Key]
        public int TareaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
