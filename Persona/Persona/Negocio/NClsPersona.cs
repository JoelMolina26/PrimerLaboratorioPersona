using Persona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Negocio
{
    class NClsPersona
    {
        public String Hablar(ClsPersona persona)
        {
<<<<<<< HEAD
            return " La persona de nombre " + persona.Nombre + " Está hablando ";

=======
            return " La persona de nombre " + persona.Nombre + " Está hablando";
>>>>>>> parent of 9364cd8 (Negocio 1)
        }
        public String Caminar(ClsPersona persona)
        {
            return " La persona de nombre " + persona.Nombre + " Está caminando";
        }
    }
}
