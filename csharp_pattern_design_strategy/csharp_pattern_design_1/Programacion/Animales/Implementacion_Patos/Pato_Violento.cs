public class Pato_Violento : Pato
{


	//Constructor
	public Pato_Violento()
	{
		//Se definene los comportamientos
		comportamiento_quack = new Quack_Feroz() { };
		comportamiento_nadar = new Nadar_Veloz() { };
	}


	//Metodos que modifican comportamientos en RunTime
	public void Cansarse()
	{
		Console.WriteLine("El pato se ha cansado");
		SetComportamientoNadar(new Nadar_SoloFlotar { });
		SetComportamientoQuack(new Quack_Cansado() { });
	}

	public void RecuperarEnergia()
	{
		Console.WriteLine("El pato se ha recuperado");
		SetComportamientoQuack(new Quack_Feroz { });
		SetComportamientoNadar(new Nadar_Veloz() { });
	}

	public override void Display()
	{
		Console.WriteLine("Mostrar imagen de pato violento.jpg");
	}

}
