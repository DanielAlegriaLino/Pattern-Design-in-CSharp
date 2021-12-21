using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_unit_testing_unix_1.Programacion.Comportamientos.Implementacion_Quack
{
    internal class Quack_Squeak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Este pato no habla, pero hace un chillido coqueto");
        }

        public void Respirar()
        {
            Console.WriteLine("Este pato toma aire a travez de su silbato");
        }
    }
}
