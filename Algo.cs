using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText
{
    class Algo
    {
        private string Lan;

        public string Numero_a_Texto(double N)
        {
            return Numero_a_Texto(N, "es", false);
        }

        public string Numero_a_Texto(double N, string lan = "es")
        {
            return Numero_a_Texto(N, lan, false);
        }

        public string Numero_a_Texto(double N, string lan = "es", Boolean Miles = false)
        {
            string cNumero;
            string Unidad;
            string Decena;
            string Centena = "";
            Int32 Entero;
            Int32 Millones = 0;
            Int32 Billones = 0;
            byte nUni;
            string r = "";
            Lan = lan;

            cNumero = Math.Truncate(N).ToString();

            if (cNumero.Length > 16 || N > 999999999999999)
            {
                if (Lan == "es")
                    r = "Número demasiado grande";
                else
                    r = "Number too big";
                return r;
            }

            if (lan == "es")
            {
                if (cNumero.Length > 12)
                {
                    Billones = Int32.Parse(cNumero.Substring(0, cNumero.Length - 12));
                    cNumero = cNumero.Substring(cNumero.Length - 12, 12);
                }
            }
            else
            {
                if (cNumero.Length > 9)
                {
                    Billones = Int32.Parse(cNumero.Substring(0, cNumero.Length - 9));
                    cNumero = cNumero.Substring(cNumero.Length - 9, 9);
                }
            }

            if (cNumero.Length > 6)
            {
                Millones = Int32.Parse(cNumero.Substring(0, cNumero.Length - 6));
                Entero = Int32.Parse(cNumero.Substring(cNumero.Length - 6, 6));
            }
            else
                Entero = Int32.Parse(cNumero);

            if (Entero == 0 && Millones == 0 && Billones == 0)
            {
                if (Lan == "es")
                    return "cero ";
                else
                    return "zero ";
            }

            if (Billones > 0)
            {
                r = Numero_a_Texto(Billones, Lan, true);
                if (lan == "es")
                {
                    if (Billones > 1)
                        r += "billones ";
                    else
                        r += "billón ";
                }
                else
                    r += "billion ";
            }

            if (Millones > 0)
            {
                r += Numero_a_Texto(Millones, Lan, true);
                if (lan == "es")
                {
                    if (Millones > 1)
                        r += "millones ";
                    else
                        r += "millón ";
                }
                else
                   r += "million ";
            }

            if (N > 999)
                if (Entero / 1000 >= 1)
                {
                    //bool mil = true;
                    //if (Entero / 1000 > 1)
                    //    mil = false;
                    r += Numero_a_Texto(Entero / 1000, Lan, true);
                    if (lan == "es")
                        r += "mil ";
                    else
                        r += "thousand ";
                }

            if (N > 99)
                Centena = cNumero.Substring(cNumero.Length - 3, 1);

            if (cNumero.Length > 1)
                nUni = byte.Parse(cNumero.Substring(cNumero.Length - 2, 2));
            else
                nUni = byte.Parse(cNumero);

            if (lan == "es" && nUni < 16 || lan == "en" && nUni < 20)
            {
                Decena = "0";
                if (cNumero.Length > 1)
                    Unidad = cNumero.Substring(cNumero.Length - 2, 2);
                else
                    Unidad = cNumero;
            }
            else
            {
                Decena = cNumero.Substring(cNumero.Length - 2, 1);
                Unidad = cNumero.Substring(cNumero.Length - 1, 1);
            }

            if (Centena != "")
                r += Centenas(byte.Parse(Centena), byte.Parse(Decena), byte.Parse(Unidad));

            if (Decena != "")
                r += Decenas(byte.Parse(Decena), byte.Parse(Unidad));

            if (Unidad != "")
                r += Unidades(byte.Parse(Unidad), Miles);

            if (N - Math.Truncate(N) > 0)
            {
                if (lan == "es")
                    r += "c/" + (Math.Round(N - Math.Truncate(N), 2) * 100) + " Cvs.";
                else
                    r += "and" + (Math.Round(N - Math.Truncate(N), 2) * 100) + " Cents";
            }

            return r;
        }
        
        private string Unidades(byte nUnidad, Boolean Miles)
        {
            string r = "";
            if (Lan == "es")
            {
                if (nUnidad == 1)
                {
                    if (Miles)
                        r = "un ";
                    else
                        r = "uno ";
                }
                if (nUnidad == 2)
                    r = "dos ";
                if (nUnidad == 3)
                    r = "tres ";
                if (nUnidad == 4)
                    r = "cuatro ";
                if (nUnidad == 5)
                    r = "cinco ";
                if (nUnidad == 6)
                    r = "seis ";
                if (nUnidad == 7)
                    r = "siete ";
                if (nUnidad == 8)
                    r = "ocho ";
                if (nUnidad == 9)
                    r = "nueve ";
                if (nUnidad == 10)
                    r = "diez ";
                if (nUnidad == 11)
                    r = "once ";
                if (nUnidad == 12)
                    r = "doce ";
                if (nUnidad == 13)
                    r = "trece ";
                if (nUnidad == 14)
                    r = "catorce ";
                if (nUnidad == 15)
                    r = "quince ";
            }
            else
            {
                if (nUnidad == 1)
                    r = "one ";
                if (nUnidad == 2)
                    r = "two ";
                if (nUnidad == 3)
                    r = "trree ";
                if (nUnidad == 4)
                    r = "four ";
                if (nUnidad == 5)
                    r = "five ";
                if (nUnidad == 6)
                    r = "six ";
                if (nUnidad == 7)
                    r = "seven ";
                if (nUnidad == 8)
                    r = "eight ";
                if (nUnidad == 9)
                    r = "nine ";
                if (nUnidad == 10)
                    r = "ten ";
                if (nUnidad == 11)
                    r = "eleven ";
                if (nUnidad == 12)
                    r = "twelve ";
                if (nUnidad == 13)
                    r = "thirteen ";
                if (nUnidad == 14)
                    r = "fourteen ";
                if (nUnidad == 15)
                    r = "fifteen ";
                if (nUnidad == 16)
                    r = "sixteen ";
                if (nUnidad == 17)
                    r = "seventeen ";
                if (nUnidad == 18)
                    r = "eighteen ";
                if (nUnidad == 19)
                    r = "nighteen ";
            }
            return r;
        }

        private string Decenas(byte nDecena, byte nUnidad)
        {
            string r = "";
            if (Lan == "es")
            {
                if (nDecena == 1)
                    r = "dieci";
                if (nDecena == 2)
                {
                    if (nUnidad == 0)
                        r = "veinte ";
                    else
                        r = "veinti";
                }
                if (nDecena == 3)
                    r = "treinta ";
                if (nDecena == 4)
                    r = "cuarenta ";
                if (nDecena == 5)
                    r = "cincuenta ";
                if (nDecena == 6)
                    r = "sesenta ";
                if (nDecena == 7)
                    r = "setenta ";
                if (nDecena == 8)
                    r = "ochenta ";
                if (nDecena == 9)
                    r = "noventa ";
                if (nDecena > 2 && nUnidad > 0)
                    r += "y ";
            }
            else
            {
                if (nDecena == 1)
                    r = "";
                if (nDecena == 2)
                    r = "twenty ";
                if (nDecena == 3)
                    r = "thirty ";
                if (nDecena == 4)
                    r = "Fourty ";
                if (nDecena == 5)
                    r = "fifty ";
                if (nDecena == 6)
                    r = "sixty ";
                if (nDecena == 7)
                    r = "seventy ";
                if (nDecena == 8)
                    r = "eighty ";
                if (nDecena == 9)
                    r = "ninety ";
            }
            return r;
        }

        private string Centenas(byte nCentenas, byte nDecenas, byte nUnidades)
        {
            string r = "";
            if (Lan == "es")
            {
                if (nCentenas == 1)
                {
                    if (nDecenas + nUnidades == 0)
                        r = "cien ";
                    else
                        r = "ciento ";
                }
                if (nCentenas == 2)
                    r = "doscientos ";
                if (nCentenas == 3)
                    r = "trescientos ";
                if (nCentenas == 4)
                    r = "cuatrocientos ";
                if (nCentenas == 5)
                    r = "quinientos ";
                if (nCentenas == 6)
                    r = "seiscientos ";
                if (nCentenas == 7)
                    r = "setecientos ";
                if (nCentenas == 8)
                    r = "ochocientos ";
                if (nCentenas == 9)
                    r = "novecientos ";
            }
            else
            {
                if (nCentenas > 0)
                    r = Unidades(nCentenas, false) + "hundred ";
            }
            return r;
        }
        
        public char SoloNumeros(char Key, bool Punto)
        {
            if (Punto == false)
                if (Key == char.Parse("."))
                    Key = char.Parse("");
            if (Key > char.Parse(" ") && (Key < char.Parse("0") || Key > char.Parse("9")))
            {
                if (Key == char.Parse("."))
                    Key = char.Parse(",");
                if (Key != char.Parse(","))
                    Key = char.Parse("");
            }
            return Key;
        }
    }
}
