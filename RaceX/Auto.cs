using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceX
{
    public abstract class Auto
    {
        public string Nombre {  get; set; }

        public string Tipo { get; set; }

        public int DistanciaRecorrida { get; protected set; } = 0;

        public Auto(string nombre) 
        { 
            this.Nombre = nombre;
        }

        public abstract int CalcularBonificacion(string clima);

        public void Avanzar(int DistBase, string clima) 
        {
            int avance = DistBase + CalcularBonificacion(clima);
            DistanciaRecorrida += Math.Max(0, avance);
        }
        public void Obstaculo() 
        {
            DistanciaRecorrida -= Math.Max(0, DistanciaRecorrida - 5);
        }
    }
}
