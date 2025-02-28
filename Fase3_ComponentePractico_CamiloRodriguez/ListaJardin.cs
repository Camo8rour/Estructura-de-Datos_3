using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3_ComponentePractico_CamiloRodriguez
{
    internal class ListaJardin
    {
        public string RegistroCivil { get; set; }
        public string Nombre { get; set; }
        public string Condicion { get; set; }
        public string Estrato { get; set; }
        public DateTime Nacimiento { get; set; }
        public bool Terapia { get; set; }

        public ListaJardin(string civil, string name, string cond, string estra, DateTime naci, bool tera)
        {
            RegistroCivil= civil;
            Nombre = name;
            Condicion = cond;
            Estrato = estra;
            Nacimiento = naci;
            Terapia = tera;
        }

    }
}
