﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.Models
{
    [Table("Tb_T_User")]
    public class User
    { 

            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
    }
}
