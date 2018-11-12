using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos
{
    

    class Info_proceso
    {
        string nombre, url;
        string indice;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Url { get => url; set => url = value; }
        public string Indice { get => indice; set => indice = value; }
    }
}
