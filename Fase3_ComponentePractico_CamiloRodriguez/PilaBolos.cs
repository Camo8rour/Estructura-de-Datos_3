using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3_ComponentePractico_CamiloRodriguez
{
    internal class PilaBolos
    {

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Jugador { get; set; }
        public int Pista { get; set; }
        public DateTime Fecha { get; set; }
        public bool Afiliado { get; set; }
        private double valor;
        public double Valor { get { return valor; } }

        public PilaBolos(string id, string name, string dire, int cantjug, int nupi, DateTime datetime, bool afili)
        {
            Identificacion = id;
            Nombre = name;
            Direccion = dire;
            Jugador = cantjug;
            Pista = nupi;
            Fecha = datetime;
            Afiliado = afili;
            getValor();
        }

        public double getValor()
        {
            valor = 50000;

            switch (Jugador)
            {
                case 1:
                    valor = valor + 0;
                    break;

                case 2:
                    valor = valor + 1000;
                    break;

                case 3:
                    valor = valor + 2000;
                    break;

                case 4:
                    valor = valor + 3000;
                    break;

                case 5:
                    valor = valor + 4000;
                    break;

                case 6:
                    valor = valor + 5000;
                    break;

                default:
                    Console.WriteLine("La cantidad de jugadores debe ser mayor a 0 y menor o igual que 6");
                    break;
            }

            switch (Pista)
            {
                case 1:
                    valor = valor + 0;
                    break;

                case 2:
                    valor = valor + 0;
                    break;

                case 3:
                    valor = valor + 5000;
                    break;

                case 4:
                    valor = valor + 10000;
                    break;

                default:
                    Console.WriteLine("Debes elegír una pista de la 1 a la 4");
                    break;
            }

            if (Afiliado)
            {
                double des;
                des = valor * 0.1;
                valor = valor - des;
            }

            return valor;
        }

    }

}
