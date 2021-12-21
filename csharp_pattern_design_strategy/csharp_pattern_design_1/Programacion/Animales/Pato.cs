public abstract class Pato
{
	protected Pato() { }

	public INadar comportamiento_nadar;
	public IQuack comportamiento_quack;

	public void SetComportamientoQuack(IQuack a_comportamiento_quack)
	{
		comportamiento_quack = a_comportamiento_quack;
	}

	public void SetComportamientoNadar(INadar a_comportamineto_nadar)
	{
		comportamiento_nadar = a_comportamineto_nadar;
	}


	public void Quakear()
	{
		comportamiento_quack.Respirar();
		comportamiento_quack.Quack();
	}

	public void Nadar()
	{
		comportamiento_nadar.Nadar();
	}

	public abstract void Display();

}

