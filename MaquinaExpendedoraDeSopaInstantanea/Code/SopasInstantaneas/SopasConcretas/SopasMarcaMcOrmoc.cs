public abstract class SopaInstantanaMcOrmoc: SopaGenerica 
{
	public override string getMarca()
	{
		return "McOrmoc";
	}
}
sealed public class SopaMcOrmocDePollo : SopaInstantanaMcOrmoc
{
	public override string getNombre()
	{
		return "Sopa McroMyRey";
	}

	public override int getPrecio()
	{
		return 10;
	}

	public override string getSabor()
	{
		return "Pollo";
	}
}

sealed public class SopaMcOrmocDePuerco : SopaInstantanaMcOrmoc
{
	public override string getNombre()
	{
		return "McroChancho Exprezz";
	}

	public override int getPrecio()
	{
		return 13;
	}

	public override string getSabor()
	{
		return "Puerco";
	}
}