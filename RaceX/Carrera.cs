using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RaceX
{
    public class Carrera
    {
        public List<Auto> Participantes {  get; private set; } = new List<Auto>();
        public string Clima { get; set; }
        public bool CarreraIniciada { get; private set; } = false;
        public bool CarreraFinalizada { get; private set; } = false;
        public Auto Ganador { get; private set; } = null;

        private Random random = new Random();
        public void AgregarAuto(Auto auto) 
        {
            if (CarreraIniciada)
                throw new InvalidOperationException("No se pueden agregar autos una vez iniciada la Carrera.");
            if (Participantes.Exists(buscar => buscar.Nombre == auto.Nombre))
                throw new ArgumentException("Ya existe un auto con ese nombre.");

            Participantes.Add(auto);
        }
        public void IniciarCarrera() 
        {
            if (Participantes.Count < 3)
                throw new InvalidOperationException("Se requieren minimo 3 Carros registados para iniciar la carrera");
            if (String.IsNullOrEmpty(Clima))
                throw new InvalidOperationException("Debe seleccionar un clima antes de empezar la carrera.");
            CarreraIniciada = true;
        }

        public string Turno() 
        {
            if (!CarreraIniciada || CarreraFinalizada)
                return "La Carrera no esta activa.";
            string info = "";

            foreach (var auto in Participantes)
            { 
                int DistBase = random.Next(5,16);
                auto.Avanzar(DistBase, Clima);
            }

            if (random.NextDouble() < 0.3) 
            { 
                int ubicObstaculo = random.Next(Participantes.Count);
                Participantes[ubicObstaculo].Obstaculo();
                info += $"\n !Obstaculo para {Participantes[ubicObstaculo].Nombre}! Pierde 5 metros.";

            }

            foreach (var auto in Participantes) 
            {
                if (auto.DistanciaRecorrida >= 150) 
                { 
                    CarreraFinalizada = true;
                    Ganador = auto;
                    info += $"\n¡{auto.Nombre} ha ganado la carrera!";
                    break;
                }
            }
            return info;

        }
        public void Reiniciar()
        {
            Participantes.Clear();
            Clima = "";
            CarreraIniciada = false;
            CarreraFinalizada = false;
            Ganador = null;
        }


    }
}
