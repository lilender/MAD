using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD
{
    public class Usuario
    {
        public string correo { get; set; }
        public string nombres { get; set; }
        public string apellido_p { get; set; }
        public string apellido_m { get; set; }
        public string f_nacimiento { get; set; }
        public bool genero { get; set; }
        public string pregunta { get; set; }
        public string respuesta { get; set; }
        public string contrasena { get; set; }
        public string idioma { get; set; }
        public string contador { get; set; }
        public Usuario() { }

        public Usuario(string _correo, string _nombres, string _apellido_p, string _apellido_m, string _f_nacimiento, bool _genero, string _pregunta, string _respuesta, string _contrasena) {
            correo = _correo;
            nombres = _nombres;
            apellido_p = _apellido_p;
            apellido_m = _apellido_m;
            f_nacimiento = _f_nacimiento;
            genero = _genero;
            pregunta = _pregunta;
            respuesta = _respuesta;
            contrasena = _contrasena;
        }


    }
}
