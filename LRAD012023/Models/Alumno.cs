using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using SQLite;


namespace LRAD012023.Models
{
    public class personas
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public string nombres { get; set; }

        [MaxLength(100)]
        public string apellidos { get; set;}
        [MaxLength(2)] 
        public string edad { get; set; }
        [MaxLength(300)]
        public string correo { get; set; }

        [MaxLength(300)]
        public string direccion { get; set;}
        public Byte[] foto { get; set; }
    }
}
