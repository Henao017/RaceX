using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceX
{
    public class AutoFactory
    {
        public static Auto CrearAuto(string tipo, string nombre ) 
        {
            switch (tipo)
            {
                case "Deportivo":
                    return new AutoDeportivo(nombre);
                case "Todo Terreno":
                    return new AutoTodoTerreno(nombre);
                case "Hibrido":
                    return new AutoHibrido(nombre);
                default:
                    throw new ArgumentException("Tipo de auto inválido");
            }
        }
    }
}
