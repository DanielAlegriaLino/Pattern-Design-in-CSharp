using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace csharp_unit_testing_unix_1.Comportamientos
{
    internal class Quack_Feroz : Comportamiento_Quack
    {
        public void Quack() 
        {
            WriteLine("Hacer un quakido de macho alfa");
        }
        
        public void Respirar() 
        {
            WriteLine();
        }


    }
}
