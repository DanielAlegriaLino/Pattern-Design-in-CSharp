public abstract class SopaInstantaneaMarchick : SopaGenerica
{
	public override string getMarca()
	{
		return "Marchick";
	}
}

public sealed class SopaMarchickDePollo : SopaInstantaneaMarchick
{
	public override string getNombre()
	{
		return "Sopa Extra Krispy Crunching Pro";
	}

	public override int getPrecio()
	{
		return 9;
	}

	public override string getSabor()
	{
		return "Pollo";
	}
}

public sealed class SopaMarchukinDeRes : SopaInstantaneaMarchick
{
	public override string getNombre()
	{
		return "Sopa Mc Bovino Exxxtra Juicy";
	}

	public override int getPrecio()
	{
		return 20;
	}

	public override string getSabor()
	{
		return "Res";
	}
}

public sealed class SopaMarchukinDeCordero : SopaInstantaneaMarchick
{
	public override string getNombre()
	{
		return "Beeeestialidad de Sopa";
	}

	public override int getPrecio()
	{
		return 18;
	}


	public override string getSabor()
	{
		return "Cordero";
	}
}