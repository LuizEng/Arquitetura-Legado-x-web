﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Model.Entity
{
    public class Usuario
    {        
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        public string Token { get; set; }
    }
}
