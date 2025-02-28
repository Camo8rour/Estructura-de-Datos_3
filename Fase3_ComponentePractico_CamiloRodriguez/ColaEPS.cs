using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3_ComponentePractico_CamiloRodriguez
{
    internal class ColaEPS
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Edad { get; set; }
        public string TipCo { get; set; }
        public DateTime Fec { get; set; }
        public int TimeEspMin { get; set; }

        private void CalTimeEs()
        {
            string catEps;

            if (Edad >= 0 && Edad <= 10)
            {
                catEps = "0-10";
            }
            else if (Edad >= 11 && Edad <= 20)
            {
                catEps = "11-20";
            }
            else if (Edad >= 21 && Edad <= 40)
            {
                catEps = "21-40";
            }
            else if (Edad >= 41 && Edad <= 60)
            {
                catEps = "41-60";
            }
            else if (Edad > 60)
            {
                catEps = "61";
            }
            else
            {
                catEps = "Peso del paquete no valido";
                return;
            }

            switch (catEps)
            {
                case "0-10":

                    switch (TipCo)
                    {
                        case "Prioritaria":
                            TimeEspMin = 10;
                            break;

                        case "General":
                            TimeEspMin = 20;
                            break;

                        case "Urgencia":
                            TimeEspMin = 5;
                            break;

                        default:
                            TimeEspMin = 0;
                            break;
                    }
                    break;

                case "11-20":

                    switch (TipCo)
                    {
                        case "Prioritaria":
                            TimeEspMin = 20;
                            break;

                        case "General":
                            TimeEspMin = 30;
                            break;

                        case "Urgencia":
                            TimeEspMin = 10;
                            break;

                        default:
                            TimeEspMin = 0;
                            break;
                    }
                    break;

                case "21-40":

                    switch (TipCo)
                    {
                        case "Prioritaria":
                            TimeEspMin = 25;
                            break;

                        case "General":
                            TimeEspMin = 35;
                            break;

                        case "Urgencia":
                            TimeEspMin = 15;
                            break;

                        default:
                            TimeEspMin = 0;
                            break;
                    }
                    break;

                case "41-60":

                    switch (TipCo)
                    {
                        case "Prioritaria":
                            TimeEspMin = 20;
                            break;

                        case "General":
                            TimeEspMin = 30;
                            break;

                        case "Urgencia":
                            TimeEspMin = 10;
                            break;

                        default:
                            TimeEspMin = 0;
                            break;
                    }
                    break;

                case "61":

                    switch (TipCo)
                    {
                        case "Prioritaria": 
                            TimeEspMin = 5;
                            break;

                        case "General":
                            TimeEspMin = 10;
                            break;

                        case "Urgencia":
                            TimeEspMin = 0;
                            break;

                        default:
                            TimeEspMin = 0;
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Categoría de edad no valida");
                    break;

            }
        }

        public int tieEs()
        {
            int TimeEs = 0;
            TimeEs = TimeEspMin;
            return TimeEs;
        }

        public ColaEPS(string ide, string nombre, int edd, string consu, DateTime fec)
        {
            Id = ide;
            Name = nombre;
            Edad = edd;
            TipCo = consu;
            Fec = fec;
            CalTimeEs();
        }
    }
}
