using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//La cree a parte como prueba, luego descubrí que se podian hacer en la misma clase, perdon por el desorden.

namespace zoologico_virtual
{
        internal class Jirafa
        {
            public string Nombre { get; set; }
            public string Sexo { get; set; }
            public string Animo { get; set; }

            public Jirafa(string nombre, string sexo, string animo)
            {
                Nombre = nombre;
                Sexo = sexo;
                Animo = animo;
            }

        }
    }
