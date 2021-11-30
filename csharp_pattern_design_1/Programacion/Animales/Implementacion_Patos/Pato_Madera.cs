using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pato_Madera : Pato
{
	public Pato_Madera()
	{
		comportamiento_nadar = new Nadar_SoloFlotar();
		comportamiento_quack = new Quack_Muteado();
	}

	public void TomarCoheteEspacial()
	{
		Console.WriteLine("El pato ha adquirido un cohete espacial");
		SetComportamientoNadar(new Nadar_Veloz());
	}

	public override void Display()
	{
		Console.WriteLine("Sale una imagen de un pato de madera");
	}
}

