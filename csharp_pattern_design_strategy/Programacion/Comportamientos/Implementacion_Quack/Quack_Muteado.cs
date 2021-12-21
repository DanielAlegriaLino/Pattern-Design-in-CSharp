using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Quack_Muteado : IQuack
{
	public void Quack()
	{
		Console.WriteLine("El silencio cual ataud");
	}

	public void Respirar()
	{
		Console.WriteLine("No tiene pulmones, asi que no hace nada");
	}
}
