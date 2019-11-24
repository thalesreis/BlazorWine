﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontSystemWine.Models
{
    public class TipoVinho
    {
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }
    }
}
