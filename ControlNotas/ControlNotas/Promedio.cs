﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNotas
{
    public class Promedio
    {
        public string Almuno { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public double CalculaNotaBaja()
        {
            double menor = double.MaxValue;

            if(Nota1 < Nota2) menor = Nota1; else menor = Nota2;
            if(Nota3 < menor) menor = Nota3;
            if(Nota4 < menor) menor= Nota4;

            return menor;
        }

        public double CalculaPromedio()
        {
            return (Nota1 + Nota2 + Nota3 + Nota4) / 4;
        }

        public string Condicion()
        {
            double promedio = CalculaPromedio();

            if (promedio > 12.5) return "Aprovado";
            else if (promedio > 10 && promedio <= 12.5) return "Recuperacion";
            else return "Desaprobado";
        }
    }
}
